/*
   Copyright 2011 repetier repetierdev@googlemail.com

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.IO;
using System.Timers;
using System.Threading;
using System.Windows.Forms;
using RepetierHost.view.utils;
using System.Globalization;

namespace RepetierHost.model
{
    /// <summary>
    /// Connection has changed.
    /// </summary>
    /// <param name="msg"></param>
    public delegate void OnPrinterConnectionChange(string msg);
    public delegate void OnPrinterAction(string action);
    public delegate void OnLogCleared();
    public delegate void OnLogAppend(LogLine line);
    public delegate void OnLogRemoveLast(LogLine line);
    public delegate void OnTempUpdate(int extruder, int printbed);
    public delegate void OnJobProgress(float percent);
    public delegate void OnTempMonitor(UInt32 time, int temp, int target, int output);
    public delegate void OnTempHistory(TemperatureEntry ent);
    public delegate void OnResponse(string response);
    public class PrinterConnection
    {
        public event OnPrinterConnectionChange eventConnectionChange;
        public event OnPrinterAction eventPrinterAction;
        public event OnLogCleared eventLogCleared;
        //public event OnLogAppend eventLogAppend;
        //public event OnLogRemoveLast eventLogRemoveLast;
        public event OnLogAppend eventLogUpdate;
        public event OnTempUpdate eventTempChange;
        public event OnJobProgress eventJobProgress;
        public event OnTempMonitor eventTempMonitor;
        public event OnResponse eventResponse;
        public event OnTempHistory eventTempHistory;
        TextWriter logWriter = null;
        public GCodeAnalyzer analyzer = new GCodeAnalyzer(false);
        public bool connected = false;
        // ======== Printer data =============
        public string printerName = "default";
        public int transferProtocol = 0; // 0 = auto, 1 = force ascii, 2 = force binary
        public int binaryVersion = 0;
        public int baud = 57600;
        public float addPrintingTime = 8;
        public bool garbageCleared = false; // Skip old output
        public Parity parity = Parity.None;
        public StopBits stopbits = StopBits.One;
        public int databits = 8;
        public SerialPort serial = null;
        public string port = "COM10";
        public float travelFeedRate = 4800;
        public float printFeedRate = 2400;
        public float maxZFeedRate = 100;
        public float disposeX = 130;
        public float disposeY = 0;
        public float disposeZ = 0;
        public bool afterJobGoDispose = true;
        public bool afterJobDisableExtruder = true;
        public bool afterJobDisablePrintbed = true;
        public bool afterJobDisableMotors = false;
        public bool sdcardMounted = true;
        string read = "";
        public LinkedList<LogLine> logList = new LinkedList<LogLine>();
        public LinkedList<LogLine> newLogs = new LinkedList<LogLine>();
        public int maxLogLines = 1000;
        bool readyForNextSend = true;
        public bool pingpong = false;
        public LinkedList<GCode> injectCommands = new LinkedList<GCode>();
        public LinkedList<GCode> history = new LinkedList<GCode>();
        LinkedListNode<GCode> resendNode = null;
        public EEPROMStorage eeprom = new EEPROMStorage();
        public EEPROMMarlinStorage eepromm = new EEPROMMarlinStorage();
        public Printjob job;
        private Object nextlineLock = new Object();
        // Printer data
        public string machine = "unknown";
        public string firmware = "";
        public string firmware_url = "";
        public string protocol = "";
        public int numberExtruder = 1;
        public int extruderTemp;
        public int bedTemp;
        public int extruderOutput = -1;
        public float x, y, z, e;
        public bool paused = false;
        public bool logM105 = false;
        public int lastline = 0;
        long lastReceived = 0;
        public bool autocheckTemp = true;
        public long autocheckInterval = 3000;
        private long lastAutocheck = 0;
        System.Timers.Timer timer = null;
        private int resendError = 0;
        public int linesSend = 0, errorsReceived = 0;
        public int bytesSend = 0;
        bool ignoreNextOk = false;
        private ManualResetEvent injectLock = new ManualResetEvent(true);
        string nextPrinterAction = null;
        private long lastCommandSend = DateTime.Now.Ticks;
        private string lastPrinterAction = "";
        public int receiveCacheSize = 63;
        public LinkedList<int> nackLines = new LinkedList<int>(); // Lines, whoses receivement were not acknowledged
        Thread readThread = null;
        VirtualPrinter virtualPrinter;
        public bool isVirtualActive = false;
        Thread writeThread = null;
        static AutoResetEvent writeEvent;
        public float lastlogprogress = -1000;
        public string filterCommand = "yourFilter #in #out";
        public bool runFilterEverySlice = false;
        public bool isRepetier = false;
        public bool isMarlin = false;
        public bool isSprinter = false;
        public int speedMultiply = 100;

        public PrinterConnection()
        {
            virtualPrinter = new VirtualPrinter();
            if (Environment.OSVersion.Platform == PlatformID.Unix)
                port = "/dev/ttyUSB0";
            job = new Printjob(this);
            timer = new System.Timers.Timer();
            timer.Interval = 100;
            timer.AutoReset = true;
            timer.Elapsed += handleTimer;
            timer.Start();

            try
            {
                string dir = Main.globalSettings.Workdir;
                if (dir.Length > 0 && Main.globalSettings.LogEnabled)
                    logWriter = new StreamWriter(dir + Path.DirectorySeparatorChar + "repetier.log");
            }
            catch
            {
                logWriter = null;
            }
            writeEvent = new AutoResetEvent(false);
        }
        public void Destroy()
        {

            if (serial != null) close();
            if (logWriter != null)
            {
                logWriter.Close();
            }
        }
        public bool hasInjectedMCommand(int code)
        {
            bool has = false;
            lock (history)
            {
                foreach (GCode co in injectCommands)
                {
                    if (co.hasM && co.M == code)
                    {
                        has = true;
                        break;
                    }
                }
            }
            return has;
        }
        void handleTimer(object sender, EventArgs e)
        {
            if (nextPrinterAction != null && !nextPrinterAction.Equals(lastPrinterAction))
            {
                lastPrinterAction = nextPrinterAction;
                try
                {
                    if (eventPrinterAction != null)
                        Main.main.Invoke(eventPrinterAction, nextPrinterAction);
                }
                catch { }
                nextPrinterAction = null;
            }
            if (((serial == null || connected == false) && !isVirtualActive) || garbageCleared == false) return;
            long actTime = DateTime.Now.Ticks / 10000;
            if (autocheckTemp && actTime - lastAutocheck > autocheckInterval && job.exclusive == false)
            {
                lastAutocheck = actTime;
                // only inject temp check, if not present. Some commands
                // take a long time and it makes no sense, to push 30 M105
                // commands as soon as it's ready.
                bool found = false;
                lock (history)
                {
                    foreach (GCode co in injectCommands)
                    {
                        if (co.hasM && co.M == 105)
                        {
                            found = true;
                            break;
                        }
                    }
                }
                if (!found)
                {
                    GetInjectLock();
                    injectManualCommand("M105");
                    ReturnInjectLock();
                }
            }
            if ((!pingpong && nackLines.Count == 0) || (pingpong && readyForNextSend)) TrySendNextLine();

            // If the reprap starts sending response it should finish soon
            else if (resendError < 4 && read.Length > 0 && lastReceived - actTime > 400)
            {
                // force response, even if we
                // get a resend request
                log("Reset output. After some wait, I got only " + read, false, 2);
                read = "";
                if (pingpong)
                    readyForNextSend = true;
                else
                {
                    lock (nackLines)
                    {
                        if (nackLines.Count > 0)
                            nackLines.RemoveFirst();
                    }
                }
                TrySendNextLine();
            }

        }
        LogLine useNextLog = null;

        public static void logInfo(string text)
        {
            Main.conn.log(text, false, 3);
        }
        public void log(string t, bool response, int level)
        {
            LogLine l;
            bool update = false;
            if (logM105 && t.IndexOf("M105") >= 0) return;
            if (useNextLog != null)
            {
                l = useNextLog;
                l.text = t;
                l.response = response;
                l.level = level;
                update = true;
                useNextLog = null;
            }
            else
                l = new LogLine(t, response, level);
            if (logWriter != null)
            {
                if (!response)
                {
                    lock (logWriter)
                    {
                        logWriter.WriteLine("< " + l.text);
                    }
                }
            }
            lock (logList)
            {
                if (l.text.Length > 0 && l.text[l.text.Length - 1] == 27)
                {
                    //useNextLog = l;
                    l.text = l.text.Substring(0, l.text.Length - 1);
                }
                if (!update) logList.AddLast(l);
            }
            if (logList.Count > maxLogLines)
            {
                LogLine removed = null;
                lock (logList)
                {
                    removed = logList.First.Value;
                    logList.RemoveFirst();
                }
                /* if (eventLogRemoveLast!=null)
                 {
                     try
                     {
                         Main.main.Invoke(eventLogRemoveLast, removed);
                     }
                     catch { } // Closing the app can cause an exception, if event comes after Main handle is destroyed
                 }*/
            }
            if (!update /*&& eventLogAppend!=null*/)
                try
                {
                    lock (newLogs)
                    {
                        newLogs.AddLast(l);
                    }
                    //Main.main.Invoke(eventLogAppend, l);
                }
                catch { } // Closing the app can cause an exception, if event comes after Main handle is destroyed

            if (update && eventLogUpdate != null)
                try
                {
                    Main.main.Invoke(eventLogUpdate, l);
                }
                catch { } // Closing the app can cause an exception, if event comes after Main handle is destroyed
        }
        private void StoreHistory(GCode gcode)
        {
            history.AddLast(gcode);
            log(gcode.getAscii(true, true), false, 0);
            if (history.Count > 40)
                history.RemoveFirst();
        }
        private int receivedCount()
        {
            int n = 0;
            lock (nackLines)
            {
                foreach (int i in nackLines)
                    n += i;
            }
            return n;
        }
        public void ResendLine(int line)
        {
            resendError++;
            errorsReceived++;
            if (pingpong)
                readyForNextSend = true;
            else
                nackLines.Clear(); // printer flushed all coming commands

            LinkedListNode<GCode> node = history.Last;
            if (resendError > 5 || node == null)
            {
                log("Receiving only error messages. Stopped communication.", false, 2);
                close();
                RepetierHost.view.SoundConfig.PlayError(false);
                return; // give up, something is terribly wrong
            }
            line &= 65535;
            do
            {
                GCode gc = node.Value;
                if (gc.hasN && (gc.N & 65535) == line)
                {
                    resendNode = node;
                    if (binaryVersion != 0)
                    {
                        int send = receivedCount();
                        serial.DiscardOutBuffer();
                        System.Threading.Thread.Sleep(send * 10000 / baud); // Wait for buffer to empty
                        byte[] buf = new byte[32];
                        for (int i = 0; i < 32; i++) buf[i] = 0;
                        serial.Write(buf, 0, 32);
                        System.Threading.Thread.Sleep(320000 / baud); // Wait for buffer to empty
                    }
                    else
                    {
                        System.Threading.Thread.Sleep(receiveCacheSize * 10000 / baud); // Wait for buffer to empty
                    }
                    TrySendNextLine();
                    return;
                }
                if (node.Previous == null) return;
                node = node.Previous;
            } while (true);
        }
        public void pause(string text)
        {
            if (paused) return;
            paused = true;
            PauseInfo.ShowPause(text);
            //MessageBox.Show(Main.main, text, "Printer paused", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //paused = false;
        }
        public void TrySendNextLine()
        {
            writeEvent.Set(); // Reactivate write look
        }
        public void WriteLoop()
        {
            bool abort = false;
            do
            {
                try
                {
                    while (true)
                    {
                        if (pingpong && !readyForNextSend)
                        {
                            writeEvent.WaitOne(1);
                        }
                        else if (serial == null && !isVirtualActive)
                        {
                            // Not ready yet
                            writeEvent.WaitOne(1);
                        }
                        else
                            writeEvent.WaitOne(1);
                        while (TrySendNextLine2()) { }
                    }
                }
                catch (ThreadAbortException)
                {
                    abort = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            } while (abort == false);
        }
        public bool TrySendNextLine2()
        {
            string logtext = null;
            int loglevel = 0;
            float logprogress = -1;
            string printeraction = null;
            GCode historygc = null;
            GCode hostCommand = null;
            if (!garbageCleared) return false;
            try
            {
                lock (nextlineLock)
                {
                    if (pingpong && !readyForNextSend) return false;
                    if (serial == null && !isVirtualActive) return false; // Not ready yet
                    if (!isVirtualActive && !serial.IsOpen) // someone unplugged the cord?
                    {
                        close();
                        return false;
                    }
                    GCode gc = null;
                    try
                    {
                        // first resolve old communication problems
                        if (resendNode != null)
                        {
                            gc = resendNode.Value;
                            if (binaryVersion == 0)
                            {
                                string cmd = gc.getAscii(true, true);
                                if (!pingpong && receivedCount() + cmd.Length + 2 > receiveCacheSize) return false; // printer cache full
                                if (pingpong) readyForNextSend = false;
                                else { lock (nackLines) { nackLines.AddLast(cmd.Length + 2); } }
                                serial.WriteLine(cmd);
                                bytesSend += cmd.Length + 2;
                            }
                            else
                            {
                                byte[] cmd = gc.getBinary(binaryVersion);
                                if (!pingpong && receivedCount() + cmd.Length > receiveCacheSize) return false; // printer cache full
                                if (pingpong) readyForNextSend = false;
                                else { lock (nackLines) { nackLines.AddLast(cmd.Length); } }
                                serial.Write(cmd, 0, cmd.Length);
                                bytesSend += cmd.Length;
                            }
                            linesSend++;
                            lastCommandSend = DateTime.Now.Ticks;
                            resendNode = resendNode.Next;
                            logtext = "Resend: " + gc.getAscii(true, true);
                            //  if (resendNode == null) readyForNextSend = true;
                            //readyForNextSend = false;
                            return true;
                        }
                        if (resendError > 0) resendError--; // Drop error counter
                        // then check for manual commands
                        if (injectCommands.Count > 0)
                        {
                            lock (history)
                            {
                                gc = injectCommands.First.Value;
                                if (gc.hostCommand)
                                {
                                    hostCommand = gc;
                                }
                                else
                                {
                                    gc.N = ++lastline;
                                    if (isVirtualActive)
                                    {
                                        if (!pingpong && receivedCount() + gc.orig.Length > receiveCacheSize) { --lastline; return false; } // printer cache full
                                        if (pingpong) readyForNextSend = false;
                                        else { lock (nackLines) { nackLines.AddLast(gc.orig.Length); } }
                                        virtualPrinter.receiveLine(gc);
                                        bytesSend += gc.orig.Length;
                                    }
                                    else
                                        if (binaryVersion == 0 || gc.forceAscii)
                                        {
                                            string cmd = gc.getAscii(true, true);
                                            if (!pingpong && receivedCount() + cmd.Length + 2 > receiveCacheSize) { --lastline; return false; } // printer cache full
                                            if (pingpong) readyForNextSend = false;
                                            else { lock (nackLines) { nackLines.AddLast(cmd.Length); } }
                                            serial.WriteLine(cmd);
                                            bytesSend += cmd.Length + 2;
                                        }
                                        else
                                        {
                                            byte[] cmd = gc.getBinary(binaryVersion);
                                            if (!pingpong && receivedCount() + cmd.Length > receiveCacheSize) { --lastline; return false; } // printer cache full
                                            if (pingpong) readyForNextSend = false;
                                            else { lock (nackLines) { nackLines.AddLast(cmd.Length); } }
                                            serial.Write(cmd, 0, cmd.Length);
                                            bytesSend += cmd.Length;
                                        }
                                }
                                injectCommands.RemoveFirst();
                            }
                            if (!gc.hostCommand)
                            {
                                linesSend++;
                                lastCommandSend = DateTime.Now.Ticks;
                                historygc = gc;
                            }
                            analyzer.Analyze(gc);
                            if (job.dataComplete == false)
                            {
                                if (injectCommands.Count == 0)
                                {
                                    printeraction = "Idle";
                                }
                                else
                                {
                                    printeraction = injectCommands.Count.ToString() + " commands waiting";
                                }
                            }
                            return true;
                        }
                        // do we have a printing job?
                        if (job.dataComplete && !paused)
                        {
                            lock (history)
                            {
                                gc = job.PeekData();
                                if (gc.hostCommand)
                                {
                                    hostCommand = gc;
                                }
                                else
                                {
                                    gc.N = ++lastline;
                                    if (isVirtualActive)
                                    {
                                        if (!pingpong && receivedCount() + gc.orig.Length > receiveCacheSize) { --lastline; return false; } // printer cache full
                                        if (pingpong) readyForNextSend = false;
                                        else { lock (nackLines) { nackLines.AddLast(gc.orig.Length); } }
                                        virtualPrinter.receiveLine(gc);
                                        bytesSend += gc.orig.Length;
                                    }
                                    else
                                        if (binaryVersion == 0 || gc.forceAscii)
                                        {
                                            string cmd = gc.getAscii(true, true);
                                            if (!pingpong && receivedCount() + cmd.Length + 2 > receiveCacheSize) { --lastline; return false; } // printer cache full
                                            if (pingpong) readyForNextSend = false;
                                            else { lock (nackLines) { nackLines.AddLast(cmd.Length + 2); } }
                                            serial.WriteLine(cmd);
                                            bytesSend += cmd.Length + 2;
                                        }
                                        else
                                        {
                                            byte[] cmd = gc.getBinary(binaryVersion);
                                            if (!pingpong && receivedCount() + cmd.Length > receiveCacheSize) { --lastline; return false; } // printer cache full
                                            if (pingpong) readyForNextSend = false;
                                            else { lock (nackLines) { nackLines.AddLast(cmd.Length); } }
                                            serial.Write(cmd, 0, cmd.Length);
                                            bytesSend += cmd.Length;
                                        }
                                    historygc = gc;
                                }
                                job.PopData();
                            }
                            if (!gc.hostCommand)
                            {
                                linesSend++;
                                lastCommandSend = DateTime.Now.Ticks;
                                printeraction = "Printing...ETA " + job.ETA;
                                if (job.maxLayer > 0)
                                    printeraction += " Layer " + analyzer.layer + "/" + job.maxLayer;
                                logprogress = job.PercentDone;
                            }
                            analyzer.Analyze(gc);
                            return true;
                        }
                    }
                    catch (InvalidOperationException ex)
                    {
                        logtext = "Error sending data:" + ex;
                        loglevel = 2;
                    }
                }
            }
            finally
            {
                // need to extract log/event calls because they cause deadlocks inside
                // the lock statement.
                if (hostCommand != null)
                    Main.main.Invoke(Main.main.executeHostCall, hostCommand);
                if (historygc != null)
                    StoreHistory(historygc);
                if (logtext != null)
                    log(logtext, false, loglevel);
                if (printeraction != null)
                    firePrinterAction(printeraction);
                if (logprogress >= 0 && Math.Abs(lastlogprogress - logprogress) > 0.3 && eventJobProgress != null)
                {
                    lastlogprogress = logprogress;
                    Main.main.Invoke(eventJobProgress, job.PercentDone);
                }
            }
            return false;
        }
        /// <summary>
        /// Clean log.
        /// </summary>
        public void clearLog()
        {
            logList.Clear();
            if (eventLogCleared != null)
                eventLogCleared();
        }
        public void open()
        {
            if (writeThread == null)
            {
                writeThread = new Thread(new ThreadStart(this.WriteLoop));
                writeThread.Start();
            }
            isMarlin = isRepetier = false;
            try
            {
                if (port.Equals("Virtual printer"))
                {
                    isVirtualActive = true;
                    virtualPrinter.open();
                    GCode gc = new GCode();
                    gc.Parse("M105");
                    virtualPrinter.receiveLine(gc);
                    connected = true;
                    if (transferProtocol < 2)
                        binaryVersion = 0;
                    else binaryVersion = transferProtocol - 1;
                    readyForNextSend = true;
                    nackLines.Clear();
                    ignoreNextOk = false;
                    linesSend = errorsReceived = bytesSend = 0;
                    gc.Parse("N0 M110");
                    virtualPrinter.receiveLine(gc);
                    gc.Parse("M115");
                    virtualPrinter.receiveLine(gc);
                    gc.Parse("M105");
                    virtualPrinter.receiveLine(gc);
                    if (eventConnectionChange != null)
                        eventConnectionChange("Connected");
                    Main.main.Invoke(Main.main.UpdateJobButtons);
                    return;
                }
                isVirtualActive = false;
                if (Main.IsMono)
                    serial = new SerialPort();
                else
                    serial = new ProtectedSerialPort();
                garbageCleared = false;
                serial.PortName = port;
                serial.BaudRate = baud;
                serial.Parity = parity;
                serial.DataBits = databits;
                serial.StopBits = stopbits;
                if (!Main.IsMono)
                    serial.DataReceived += received;
                serial.ErrorReceived += error;
                serial.RtsEnable = false;
                serial.DtrEnable = false;
                serial.Open();
              //  serial.DtrEnable = true;
             //   Thread.Sleep(400);
             //   serial.DtrEnable = false;
                // If we didn't restart the connection we need to eat
                // all unread data on this port.
                serial.DiscardInBuffer();
                /*while(serial.BytesToRead > 0)
                {
                    string indata = serial.ReadExisting();
                }*/
                serial.WriteLine("M105");
                connected = true;
                if (transferProtocol < 2)
                    binaryVersion = 0;
                else binaryVersion = transferProtocol - 1;
                readyForNextSend = true;
                nackLines.Clear();
                ignoreNextOk = false;
                linesSend = errorsReceived = bytesSend = 0;
                if (readThread == null && Main.IsMono)
                {
                    readThread = new Thread(new ThreadStart(this.ReadThread));
                    readThread.Start();
                }
                GetInjectLock();
                injectManualCommand("N0 M110"); // Make sure we tal about the same linenumbers
                injectManualCommand("M115"); // Check firmware
                injectManualCommand("M105"); // Read temperature
                ReturnInjectLock();
                if (eventConnectionChange != null)
                    eventConnectionChange("Connected");
                Main.main.Invoke(Main.main.UpdateJobButtons);
            }
            catch (IOException ex)
            {
                serial = null;
                log(ex.Message, true, 2);
                if (eventConnectionChange != null)
                    eventConnectionChange("Conn. error");
                RepetierHost.view.SoundConfig.PlayError(false);
            }
        }

        public void close()
        {
            if (writeThread != null)
            {
                writeThread.Abort();
                writeThread = null;
            }
            if (isVirtualActive)
            {
                isVirtualActive = false;
                connected = false;
                virtualPrinter.close();
                job.KillJob();
                history.Clear();
                injectCommands.Clear();
                resendNode = null;
                comErrorsReceived = 0;
                if (eventConnectionChange != null)
                    try
                    {
                        Main.main.Invoke(eventConnectionChange, "Disconnected");
                    }
                    catch { } // Closing the app can cause an exception, if event comes after Main handle is destroyed
                firePrinterAction("Idle");
                Main.main.Invoke(Main.main.UpdateJobButtons);
                return;
            }
            if (serial == null) return;
            if (job.mode == 1)
                job.KillJob();
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            connected = false;
            if (readThread != null)
                readThread.Abort();
            readThread = null;
            //  lock (nextlineLock)
            // {
            try
            {
                serial.Close();
                serial.Dispose();
            }
            catch (Exception) { }
            serial = null;
            // }
            job.KillJob();
            history.Clear();
            injectCommands.Clear();
            resendNode = null;
            comErrorsReceived = 0;
            if (eventConnectionChange != null)
                try
                {
                    Main.main.Invoke(eventConnectionChange, "Disconnected");
                }
                catch { } // Closing the app can cause an exception, if event comes after Main handle is destroyed
            firePrinterAction("Idle");
            Main.main.Invoke(Main.main.UpdateJobButtons);
        }

        public void firePrinterAction(string s)
        {
            nextPrinterAction = s;
        }
        int comErrorsReceived = 0;
        private void error(Object sender, SerialErrorReceivedEventArgs e)
        {
            comErrorsReceived++;
            log("Serial com error:" + e.ToString(), false, 2);
            if (comErrorsReceived == 10)
                close();
        }
        /// <summary>
        /// Mono version as mono does not execute received event.
        /// </summary>
        private void ReadThread()
        {
            try
            {
                while (true)
                {
                    Thread.Sleep(2);
                    if (!connected || serial == null || !serial.IsOpen) continue; // Not connected
                    if (serial.BytesToRead > 0)
                    {
                        try
                        {
                            string indata = serial.ReadExisting();
                            //Console.Write(indata);
                            read += indata.Replace('\r', '\n');
                            do
                            {
                                int pos = read.IndexOf('\n');
                                if (pos < 0) break;
                                string response = read.Substring(0, pos);
                                read = read.Substring(pos + 1);
                                if (response.Length > 0)
                                {
                                    analyzeResponse(response);
                                }
                                TrySendNextLine();
                            } while (true);
                        }
                        catch (ThreadAbortException)
                        {
                            return;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }

                        lastReceived = DateTime.Now.Ticks / 10000;
                    }
                }
            }
            catch (ThreadAbortException)
            {
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void VirtualResponse(string response)
        {
            if (response.Length > 0)
            {
                analyzeResponse(response);
            }
            TrySendNextLine();
            lastReceived = DateTime.Now.Ticks / 10000;
        }
        private void received(object sender,
                        SerialDataReceivedEventArgs e)
        {
            if (serial == null) return;
            string indata = serial.ReadExisting();
            read += indata.Replace('\r', '\n');
            do
            {
                int pos = read.IndexOf('\n');
                if (pos < 0) break;
                string response = read.Substring(0, pos);
                read = read.Substring(pos + 1);
                if (response.Length > 0)
                {
                    analyzeResponse(response);
                }
                TrySendNextLine();
            } while (true);
            lastReceived = DateTime.Now.Ticks / 10000;
        }
        /// <summary>
        /// Send a print command, that does not belong to a print job.
        /// </summary>
        /// <param name="command">GCode command</param>
        public void injectManualCommand(string command)
        {
            GCode gc = new GCode();
            gc.Parse(command);
            if (gc.comment) return;
            lock (history)
                injectCommands.AddLast(gc);
            if (job.dataComplete == false)
            {
                if (injectCommands.Count == 0)
                {
                    firePrinterAction("Idle");
                }
                else
                {
                    firePrinterAction(injectCommands.Count.ToString() + " commands waiting");
                }
            }
        }
        public void injectManualCommandFirst(string command)
        {
            GCode gc = new GCode();
            gc.Parse(command);
            if (gc.comment) return;
            lock (history)
                injectCommands.AddFirst(gc);
            if (job.dataComplete == false)
            {
                if (injectCommands.Count == 0)
                {
                    firePrinterAction("Idle");
                }
                else
                {
                    firePrinterAction(injectCommands.Count.ToString() + " commands waiting");
                }
            }
        }
        private Object injectLockLock = new Object();
        public void GetInjectLock()
        {
            try
            {
                injectLock.WaitOne();
                injectLock.Reset();
            }
            catch (Exception e)
            {
                firePrinterAction(e.ToString());
            }
            /*lock(injectLockLock) {
                while(!injectLock) {}
                injectLock = false;
            }*/
        }
        public void ReturnInjectLock()
        {
            injectLock.Set();
        }
        /// <summary>
        /// Analyzes a response from the printer.
        /// Updates data and sends events according to the data.
        /// </summary>
        /// <param name="res"></param>
        public void analyzeResponse(string res)
        {
            res = res.Trim();
            int level = 0;
            if (logWriter != null)
            {
                DateTime time = DateTime.Now;
                lock (logWriter)
                {
                    logWriter.WriteLine("> " + time.Hour.ToString("00") + ":" + time.Minute.ToString("00") + ":" +
                    time.Second.ToString("00") + "." + time.Millisecond.ToString("000") + " : " + res);
                }
            }
            if (eventResponse != null)
            {
                eventResponse(res);
            }
            string h = extract(res, "FIRMWARE_NAME:");
            if (h != null)
            {
                level = 3;
                firmware = h;
                if (h.IndexOf("Repetier") >= 0)
                {
                    isRepetier = true;
                }
                if (h.IndexOf("Marlin") >= 0) isMarlin = true;                
                if (isMarlin || isRepetier) // Activate special menus and function
                {
                    Main.main.Invoke(Main.main.UpdateEEPROM);
                    injectManualCommand("M220 S" + speedMultiply.ToString());
                }
                Main.main.Invoke(Main.main.FirmwareDetected);
            }
            h = extract(res, "FIRMWARE_URL:");
            if (h != null)
            {
                level = 3;
                firmware_url = h;
            }
            h = extract(res, "PROTOCOL_VERSION:");
            if (h != null)
            {
                level = 3;
                protocol = h;
            }
            h = extract(res, "MACHINE_TYPE:");
            if (h != null)
            {
                level = 3;
                machine = h;
            }
            h = extract(res, "EXTRUDER_COUNT:");
            if (h != null)
            {
                level = 3;
                if (!int.TryParse(h, out numberExtruder)) numberExtruder = 1;
            }
            h = extract(res, "X:");
            if (h != null)
            {
                level = 3;
                float.TryParse(h, NumberStyles.Float, GCode.format, out x);
                analyzer.x = x;
                analyzer.hasXHome = true;
            }
            h = extract(res, "Y:");
            if (h != null)
            {
                level = 3;
                float.TryParse(h, NumberStyles.Float, GCode.format, out y);
                analyzer.y = y;
                analyzer.hasYHome = true;
            }
            h = extract(res, "Z:");
            if (h != null)
            {
                level = 3;
                float.TryParse(h, NumberStyles.Float, GCode.format, out z);
                analyzer.z = z;
                analyzer.hasZHome = true;
            }
            h = extract(res, "E:");
            if (h != null)
            {
                level = 3;
                float.TryParse(h, NumberStyles.Float, GCode.format, out e);
                analyzer.e = e;
            }
            if ((h = extract(res, "SpeedMultiply:")) != null)
            {
                int.TryParse(h,out speedMultiply);
                if (speedMultiply < 25) speedMultiply = 25;
                if (speedMultiply > 300) speedMultiply = 300;
                analyzer.fireChanged();
            }
            if ((h = extract(res, "TargetExtr0:")) != null)
            {
                if (analyzer.activeExtruder == 0)
                    int.TryParse(h,out analyzer.extruderTemp);
                analyzer.fireChanged();
            }
            if ((h = extract(res, "TargetExtr1:")) != null)
            {
                if (analyzer.activeExtruder == 1)
                    int.TryParse(h,out analyzer.extruderTemp);
                analyzer.fireChanged();
            }
            if ((h = extract(res, "TargetBed:")) != null)
            {
                int.TryParse(h,out analyzer.bedTemp);
                analyzer.fireChanged();
            }
            if ((h = extract(res, "Fanspeed:")) != null)
            {
                int.TryParse(h, out analyzer.fanVoltage);
                analyzer.fireChanged();
            }

            bool tempChange = false;
            h = extract(res, "T:");
            if (h != null)
            {
                level = -1; // dont log, we see result in status
                if (h.IndexOf('.') > 0) h = h.Substring(0, h.IndexOf('.'));
                int.TryParse(h, out extruderTemp);
                tempChange = true;
                extruderOutput = -1;
                h = extract(res, "@:");
                int.TryParse(h, out extruderOutput);
                if (isMarlin) extruderOutput *= 2;
            }
            h = extract(res, "B:");
            if (h != null)
            {
                level = -1; // don't log, we see result in status
                if (h.IndexOf('.') > 0) h = h.Substring(0, h.IndexOf('.'));
                int.TryParse(h, out bedTemp);
                tempChange = true;
            }
            if (isRepetier)
            { // Repetier specific answers
                if (res.StartsWith("EPR:"))
                {
                    eeprom.Add(res);
                }
            }
            if (isMarlin)
            { // Marlin specifix answers
                if (res.StartsWith("echo:") && (res.IndexOf("M92") > 0) || (res.IndexOf("M203") > 0) || (res.IndexOf("M201") > 0) ||
                    (res.IndexOf("M204") > 0) || (res.IndexOf("M205") > 0) || (res.IndexOf("M301") > 0))
                {
                    eepromm.Add(res);
                }
            }
            if (res.StartsWith("MTEMP:")) // Temperature monitor 
            {
                level = -1; // this happens to often to log. Temperture monitor i sthe log
                string[] sl = res.Substring(6).Split(' ');
                if (sl.Length == 4)
                {
                    UInt32 time;
                    int temp, target, output;
                    UInt32.TryParse(sl[0], out time);
                    int.TryParse(sl[1], out temp);
                    int.TryParse(sl[2], out target);
                    int.TryParse(sl[3], out output);
                    if (time > 0 && eventTempMonitor != null)
                    {
                        try
                        {
                            Main.main.Invoke(eventTempMonitor, time, temp, target, output);
                        }
                        catch { }
                    }
                    if (eventTempHistory != null)
                    {
                        TemperatureEntry te = new TemperatureEntry(analyzer.tempMonitor, temp, output, analyzer.bedTemp, analyzer.extruderTemp);
                        Main.main.Invoke(eventTempHistory, te);
                    }
                }
            }
            h = extract(res, "REPETIER_PROTOCOL:");
            if (h != null)
            {
                level = 3;
                int.TryParse(h, out binaryVersion);
                if (transferProtocol == 1) binaryVersion = 0; // force ascii transfer
            }
            if (res.Equals("start") || (garbageCleared == false && res.IndexOf("start") != -1))
            {
                lastline = 0;
                job.KillJob(); // continuing the old job makes no sense, better save the plastic
                resendNode = null;
                sdcardMounted = true;
                history.Clear();
                analyzer.start();
                readyForNextSend = true;
                nackLines.Clear();
                garbageCleared = true;
            }
            if (extract(res, "Error:") != null)
            {
                level = 2;
                RepetierHost.view.SoundConfig.PlayError(false);
            }
            if (tempChange && eventTempChange != null)
            {
                Main.main.Invoke(eventTempChange, extruderTemp, bedTemp);
            }
            if (tempChange && eventTempHistory != null)
            {
                TemperatureEntry te = new TemperatureEntry(extruderTemp, bedTemp, analyzer.bedTemp, analyzer.extruderTemp);
                if (extruderOutput >= 0)
                    te.output = extruderOutput;
                Main.main.Invoke(eventTempHistory, te);
            }
            h = extract(res, "Resend:");
            if (h != null)
            {
                level = 1;
                log(res, true, level);
                int line;
                int.TryParse(h, out line);
                ignoreNextOk = true;
                ResendLine(line);
            }
            else if (res.StartsWith("ok"))
            {
                garbageCleared = true;
                if (Main.main.logView.switchACK.On)
                    log(res, true, level);
                if (!ignoreNextOk)  // ok in response of resend?
                {
                    if (pingpong) readyForNextSend = true;
                    else
                    {
                        lock (nackLines)
                        {
                            if (nackLines.Count > 0)
                                nackLines.RemoveFirst();
                        }
                    }
                    resendError = 0;
                    TrySendNextLine();
                }
                else
                    ignoreNextOk = false;
            }
            else if (res.Equals("wait") && DateTime.Now.Ticks - lastCommandSend > 5000)
            {
                if (Main.main.logView.switchACK.On)
                    log(res, true, level);
                if (pingpong) readyForNextSend = true;
                else
                {
                    lock (nackLines)
                    {
                        if (nackLines.Count > 0)
                            nackLines.Clear();
                    }
                }
                resendError = 0;
                TrySendNextLine();
            }
            else if (level >= 0 && garbageCleared) log(res, true, level);

        }
        private string extract(string source, string ident)
        {
            int pos = 0;
            do
            {
                pos = source.IndexOf(ident, pos == 0 ? pos : pos + 1);
                if (pos < 0) return null;
            } while (pos > 0 && source[pos - 1] != ' ');
            int start = pos + ident.Length;
            int end = start;
            while (end < source.Length && source[end] != ' ') end++;
            return source.Substring(start, end - start);
        }
        public void doDispose()
        {
            if (analyzer.hasXHome == false || analyzer.hasYHome == false) return; // don't know where we are
            float dx = disposeX - analyzer.xOffset - (analyzer.relative ? analyzer.x : 0);
            float dy = disposeY - analyzer.yOffset - (analyzer.relative ? analyzer.y : 0);
            string zextra = "";
            GetInjectLock();
            injectManualCommand("G1 X" + dx.ToString(GCode.format) + " Y" + dy.ToString(GCode.format) + " F" + travelFeedRate.ToString(GCode.format));
            if (analyzer.hasZHome && analyzer.z - analyzer.zOffset < disposeZ && disposeZ > 0 && disposeZ < Main.printerSettings.PrintAreaHeight)
            {
                float dz = disposeZ - analyzer.zOffset - (analyzer.relative ? analyzer.z : 0);
                zextra = "G1 Z" + dz.ToString(GCode.format) + " F" + maxZFeedRate.ToString(GCode.format);
                injectManualCommand(zextra);
            }
            ReturnInjectLock();
        }
    }
}
