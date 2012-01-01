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
using OpenTK;
//using OpenTK.Graphics;
using OpenTK.Platform;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using System.Windows.Forms;

namespace RepetierHost.model
{
    public class GCodePoint
    {
        public float e;
        public float dist;
        public Vector3 p;
    }
    public class GCodePath
    {
        public int drawMethod = -1;
        public float[] positions = null;
        public float[] normals = null;
        public int[] elements = null;
        public int[] buf = new int[3];
        public LinkedList<GCodePoint> points = new LinkedList<GCodePoint>();
        public void Add(Vector3 v, float e, float d)
        {
            GCodePoint pt = new GCodePoint();
            pt.p = v;
            pt.e = e;
            pt.dist = d;
            points.AddLast(pt);
            drawMethod = -1; // invalidate old 
        }
        public float lastDist
        {
            get { return points.Last.Value.dist; }
        }
        public void Free()
        {
            if (elements != null)
            {
                elements = null;
                normals = null;
                positions = null;
                points.Clear();
                GL.DeleteBuffers(3, buf);
            }
        }
        public void UpdateVBO()
        {
            if (points.Count < 2) return;
            if (elements != null)
                GL.DeleteBuffers(3, buf);
            int method = Main.threeDSettings.filamentVisualization;
            float h = Main.threeDSettings.layerHeight;
            float wfac = Main.threeDSettings.widthOverHeight;
            float w = h * wfac;
            bool fixedH = Main.threeDSettings.useLayerHeight;
            float dfac = (float)(Math.PI * Main.threeDSettings.filamentDiameter * Main.threeDSettings.filamentDiameter * 0.25 / wfac);
            int nv = 8 * (method - 1), i;
            if (method == 1) nv = 4;
            if (method == 0) nv = 1;
            int n = nv * (method == 0 ? 1 : 2) * (points.Count - 1);
            if (method != 0) positions = new float[n * 3]; else positions = new float[3 * points.Count];
            if (method != 0) normals = new float[n * 3]; else normals = null;
            if (method != 0) elements = new int[(points.Count - 1) * nv * 4]; else elements = new int[n * 2];
            int pos = 0;
            int npos = 0;
            int vpos = 0;
            if (method > 0)
            {
                float alpha, dalpha = (float)Math.PI * 2f / nv;
                float[] dir = new float[3];
                float[] dirs = new float[3];
                float[] diru = new float[3];
                float[] norm = new float[3];
                float laste = 0;
                float dh = 0.5f * h;
                float dw = 0.5f * w;
                bool first = true;
                Vector3 last = new Vector3();
                w *= 0.5f;
                int nv2 = 2 * nv;
                foreach (GCodePoint pt in points)
                {
                    Vector3 v = pt.p;
                    if (first)
                    {
                        last = v;
                        laste = pt.e;
                        first = false;
                        continue;
                    }
                    bool isLast = pt == points.Last.Value;
                    dir[0] = v.X - last.X;
                    dir[1] = v.Y - last.Y;
                    dir[2] = v.Z - last.Z;
                    if (!fixedH)
                    {
                        float dist = (float)Math.Sqrt(dir[0] * dir[0] + dir[1] * dir[1] + dir[2] * dir[2]);
                        if (dist > 0)
                        {
                            h = (float)Math.Sqrt((pt.e - laste) * dfac / dist);
                            w = h * wfac;
                            dh = 0.5f * h;
                            dw = 0.5f * w;
                        }
                    }
                    GCodeVisual.normalize(ref dir);
                    dirs[0] = -dir[1];
                    dirs[1] = dir[0];
                    dirs[2] = dir[2];
                    diru[0] = diru[1] = 0;
                    diru[2] = 1;
                    alpha = 0;
                    float c, s;
                    int b = vpos / 3;
                    for (i = 0; i < nv; i++)
                    {
                        c = (float)Math.Cos(alpha) * dh;
                        s = (float)Math.Sin(alpha) * dw;
                        norm[0] = (float)(s * dirs[0] + c * diru[0]);
                        norm[1] = (float)(s * dirs[1] + c * diru[1]);
                        norm[2] = (float)(s * dirs[2] + c * diru[2]);
                        GCodeVisual.normalize(ref norm);
                        elements[pos++] = b + i * 2;//1
                        elements[pos++] = b + (i * 2 + nv2 - 2) % nv2;//2
                        elements[pos++] = b + (i * 2 + nv2 - 1) % nv2;//3
                        elements[pos++] = b + (i * 2 + 1);//4
                        normals[npos++] = norm[0];
                        normals[npos++] = norm[1];
                        normals[npos++] = norm[2];
                        normals[npos++] = norm[0];
                        normals[npos++] = norm[1];
                        normals[npos++] = norm[2];
                        positions[vpos++] = last.X + s * dirs[0] + c * diru[0];
                        positions[vpos++] = last.Y + s * dirs[1] + c * diru[1];
                        positions[vpos++] = last.Z - dh + s * dirs[2] + c * diru[2];
                        positions[vpos++] = v.X + s * dirs[0] + c * diru[0];
                        positions[vpos++] = v.Y + s * dirs[1] + c * diru[1];
                        positions[vpos++] = v.Z - dh + s * dirs[2] + c * diru[2];
                        alpha += dalpha;
                    }
                    last = v;
                    laste = pt.e;
                }
                GL.GenBuffers(3, buf);
                GL.BindBuffer(BufferTarget.ArrayBuffer, buf[0]);
                GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(positions.Length * sizeof(float)), positions, BufferUsageHint.StaticDraw);
                GL.BindBuffer(BufferTarget.ArrayBuffer, buf[1]);
                GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(normals.Length * sizeof(float)), normals, BufferUsageHint.StaticDraw);
                GL.BindBuffer(BufferTarget.ElementArrayBuffer, buf[2]);
                GL.BufferData(BufferTarget.ElementArrayBuffer, (IntPtr)(elements.Length * sizeof(int)), elements, BufferUsageHint.StaticDraw);
            }
            else
            {
                // Draw edges
                bool first = true;
                foreach (GCodePoint pt in points)
                {
                    Vector3 v = pt.p;
                    positions[vpos++] = v.X;
                    positions[vpos++] = v.Y;
                    positions[vpos++] = v.Z;

                    if (!first)
                    {
                        elements[pos] = pos / 2;
                        elements[pos + 1] = pos / 2 + 1;
                        pos += 2;
                    }
                    first = false;
                }
                GL.GenBuffers(3, buf);
                GL.BindBuffer(BufferTarget.ArrayBuffer, buf[0]);
                GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(positions.Length * sizeof(float)), positions, BufferUsageHint.StaticDraw);
                GL.BindBuffer(BufferTarget.ElementArrayBuffer, buf[2]);
                GL.BufferData(BufferTarget.ElementArrayBuffer, (IntPtr)(elements.Length * sizeof(int)), elements, BufferUsageHint.StaticDraw);
            }
            drawMethod = method;
        }
    }
    public class GCodeVisual : ThreeDModel
    {
        LinkedList<GCodePath> segments = new LinkedList<GCodePath>();
        GCodeAnalyzer ana = new GCodeAnalyzer(true);
        public GCode act = null;
        public float lastFilHeight = 999;
        public float lastFilWidth = 999;
        public float lastFilDiameter = 999;
        public bool lastFilUseHeight = true;
        public float laste = -999;
        public float hotFilamentLength = 1000;
        public float minHotDist = 0;
        public float[] defaultColor = new float[4];
        public float[] hotColor = new float[4];
        public float[] curColor = new float[4];
        public bool liveView = false; // Is live view of print. If true, color transion for end is shown
        public float totalDist = 0; // Total print travel distance
        private int method=0;
        bool recompute;
        float wfac;
        float h,w;
        bool fixedH;
        float dfac;
        float lastx = 1e20f, lasty = 0, lastz = 0;
        bool changed = false;
        public bool startOnClear = false;

        public GCodeVisual()
        {
            ana = new GCodeAnalyzer(true);
            startOnClear = true;
            ana.eventPosChanged += OnPosChange;
        }
        public GCodeVisual(GCodeAnalyzer a)
        {
            ana = a;
            startOnClear = false;
            ana.eventPosChanged += OnPosChange;
        }

        /// <summary>
        /// Add a GCode line to be visualized.
        /// </summary>
        /// <param name="g"></param>
        public void AddGCode(GCode g)
        {
            act = g;
            ana.Analyze(g);
            laste = ana.emax;
        }
        /// <summary>
        /// Remove all drawn lines.
        /// </summary>
        public override void Clear()
        {
            foreach (GCodePath p in segments)
                p.Free();
            segments.Clear();
            lastx = 1e20f; // Don't ignore first point if it was the last! 
            totalDist = 0;
            if (startOnClear)
                ana.start();
        }
        void OnPosChange(GCode act, float x, float y, float z)
        {
            float locDist = (float)Math.Sqrt((x - lastx) * (x - lastx) + (y - lasty) * (y - lasty) + (z - lastz) * (z - lastz));
            bool isLastPos = locDist < 0.00001;
            if (!act.hasG || (act.G > 1 && act.G != 28)) return;
            if (segments.Count == 0 || laste >= ana.e) // start new segment
            {
                if (!isLastPos) // no move, no action
                {
                    GCodePath p = new GCodePath();
                    p.Add(new Vector3(x, y, z), ana.emax, totalDist);
                    if (segments.Count > 0 && segments.Last.Value.points.Count == 1)
                    {
                        segments.RemoveLast();
                    }
                    segments.AddLast(p);
                    changed = true;
                }
            }
            else
            {
                if (!isLastPos)
                {
                    totalDist += locDist;
                    segments.Last.Value.Add(new Vector3(x, y, z), ana.emax, totalDist);
                    changed = true;
                }
            }
            lastx = x;
            lasty = y;
            lastz = z;
            laste = ana.emax;
        }
        public void ParseText(string text, bool clear)
        {
            GCode gc = new GCode();
            if (clear)
                Clear();
            foreach (string s in text.Split('\n'))
            {
                gc.Parse(s);
                AddGCode(gc);
            }
        }
        public static void normalize(ref float[] n)
        {
            float d = (float)Math.Sqrt(n[0] * n[0] + n[1] * n[1] + n[2] * n[2]);
            n[0] /= d;
            n[1] /= d;
            n[2] /= d;
        }
        public void setColor(float dist)
        {
            if (!liveView || dist < minHotDist)
                GL.Material(MaterialFace.FrontAndBack, MaterialParameter.AmbientAndDiffuse, defaultColor);
            else
            {
                float fak = (totalDist - dist) / hotFilamentLength; // 1 = default 0 = hot
                float fak2 = 1 - fak;
                curColor[0] = defaultColor[0] * fak + hotColor[0] * fak2;
                curColor[1] = defaultColor[1] * fak + hotColor[1] * fak2;
                curColor[2] = defaultColor[2] * fak + hotColor[2] * fak2;
                GL.Material(MaterialFace.FrontAndBack, MaterialParameter.AmbientAndDiffuse, curColor);
            }
        }
        public void drawSegment(GCodePath path)
        {
            if (Main.threeDSettings.useVBOs && path.lastDist < minHotDist)
            {
                GL.EnableClientState(ArrayCap.VertexArray);
                if (method != 0)
                    GL.EnableClientState(ArrayCap.NormalArray);
                if (path.drawMethod != method || recompute)
                    path.UpdateVBO();
                if (path.elements == null) return;
                GL.BindBuffer(BufferTarget.ArrayBuffer, path.buf[0]);
                GL.VertexPointer(3, VertexPointerType.Float, 0, 0);
                if (method != 0)
                {
                    GL.BindBuffer(BufferTarget.ArrayBuffer, path.buf[1]);
                    GL.NormalPointer(NormalPointerType.Float, 0, 0);
                }
                GL.BindBuffer(BufferTarget.ElementArrayBuffer, path.buf[2]);
                if (method == 0)
                    GL.DrawElements(BeginMode.Lines, path.elements.Length, DrawElementsType.UnsignedInt, 0);

                else
                    GL.DrawElements(BeginMode.Quads, path.elements.Length, DrawElementsType.UnsignedInt, 0);
                GL.DisableClientState(ArrayCap.VertexArray);
                GL.DisableClientState(ArrayCap.NormalArray);
            }
            else
            {
                if (method > 0)
                {
                    int nv = 8 * (method - 1), i;
                    if (method == 1) nv = 4;
                    float alpha, dalpha = (float)Math.PI * 2f / nv;
                    float[] dir = new float[3];
                    float[] dirs = new float[3];
                    float[] diru = new float[3];
                    float[] n = new float[3];
                    float dh = 0.5f * h;
                    float dw = 0.5f * w;
                    if (path.points.Count < 2) return;
                    GL.Begin(BeginMode.Quads);
                    bool first = true;
                    Vector3 last = new Vector3();
                    foreach (GCodePoint pt in path.points)
                    {
                        Vector3 v = pt.p;
                        setColor(pt.dist);
                        if (first)
                        {
                            last = v;
                            first = false;
                            continue;
                        }
                        bool isLast = pt == path.points.Last.Value;
                        dir[0] = v.X - last.X;
                        dir[1] = v.Y - last.Y;
                        dir[2] = v.Z - last.Z;
                        if (!fixedH)
                        {
                            float dist = (float)Math.Sqrt(dir[0] * dir[0] + dir[1] * dir[1] + dir[2] * dir[2]);
                            if (dist > 0)
                            {
                                h = (float)Math.Sqrt((pt.e - laste) * dfac / dist);
                                w = h * wfac;
                                dh = 0.5f * h;
                                dw = 0.5f * w;
                            }
                        }
                        normalize(ref dir);
                        dirs[0] = -dir[1];
                        dirs[1] = dir[0];
                        dirs[2] = dir[2];
                        diru[0] = diru[1] = 0;
                        diru[2] = 1;
                        alpha = 0;
                        float c = (float)Math.Cos(alpha) * dh;
                        float s = (float)Math.Sin(alpha) * dw;
                        n[0] = (float)(s * dirs[0] + c * diru[0]);
                        n[1] = (float)(s * dirs[1] + c * diru[1]);
                        n[2] = (float)(s * dirs[2] + c * diru[2]);
                        normalize(ref n);
                        GL.Normal3(n[0], n[1], n[2]);
                        for (i = 0; i < nv; i++)
                        {
                            GL.Vertex3(last.X + s * dirs[0] + c * diru[0], last.Y + s * dirs[1] + c * diru[1], last.Z - dh + s * dirs[2] + c * diru[2]);
                            GL.Vertex3(v.X + s * dirs[0] + c * diru[0], v.Y + s * dirs[1] + c * diru[1], v.Z - dh + s * dirs[2] + c * diru[2]);
                            alpha += dalpha;
                            c = (float)Math.Cos(alpha) * dh;
                            s = (float)Math.Sin(alpha) * dw;
                            n[0] = (float)(s * dirs[0] + c * diru[0]);
                            n[1] = (float)(s * dirs[1] + c * diru[1]);
                            n[2] = (float)(s * dirs[2] + c * diru[2]);
                            normalize(ref n);
                            GL.Normal3(n[0], n[1], n[2]);
                            GL.Vertex3(v.X + s * dirs[0] + c * diru[0], v.Y + s * dirs[1] + c * diru[1], v.Z - dh + s * dirs[2] + c * diru[2]);
                            GL.Vertex3(last.X + s * dirs[0] + c * diru[0], last.Y + s * dirs[1] + c * diru[1], last.Z - dh + s * dirs[2] + c * diru[2]);
                        }
                        last = v;
                    }

                    GL.End();

                }
                else if (method == 0)
                {
                    // Draw edges
                    GL.Material(
                        MaterialFace.Front,
                        MaterialParameter.Emission,defaultColor);

                    if (path.points.Count < 2) return;
                    GL.Begin(BeginMode.Lines);
                    bool first = true;
                    foreach (GCodePoint pt in path.points)
                    {
                        Vector3 v = pt.p;
                        if (liveView && pt.dist >= minHotDist)
                        {
                            float fak = (totalDist - pt.dist) / hotFilamentLength; // 1 = default 0 = hot
                            float fak2 = 1 - fak;
                            curColor[0] = defaultColor[0] * fak + hotColor[0] * fak2;
                            curColor[1] = defaultColor[1] * fak + hotColor[1] * fak2;
                            curColor[2] = defaultColor[2] * fak + hotColor[2] * fak2;
                            GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Emission, curColor);
                        }

                        GL.Vertex3(v);
                        if (!first && pt != path.points.Last.Value)
                            GL.Vertex3(v);
                        first = false;
                    }
                    GL.End();
                }
            }

        }
        public override void Paint()
        {
            changed = false;
            if (Main.threeDSettings.checkDisableFilamentVisualization.Checked) return; // Disabled too much for card
            hotFilamentLength = Main.threeDSettings.hotFilamentLength;
            minHotDist = totalDist - hotFilamentLength;
            //long timeStart = DateTime.Now.Ticks;
            Color col;
            col = Main.threeDSettings.filament.BackColor;
            defaultColor[0] = (float)col.R / 255.0f;
            defaultColor[1] = (float)col.G / 255.0f;
            defaultColor[2] = (float)col.B / 255.0f;
            defaultColor[3] = 1;
            col = Main.threeDSettings.hotFilament.BackColor;
            hotColor[0] = (float)col.R / 255.0f;
            hotColor[1] = (float)col.G / 255.0f;
            hotColor[2] = (float)col.B / 255.0f;
            hotColor[3] = curColor[3] = 1;
            //           GL.Material(MaterialFace.FrontAndBack, MaterialParameter.AmbientAndDiffuse, new OpenTK.Graphics.Color4(col.R, col.G, col.B, 255));
            GL.Material(MaterialFace.FrontAndBack, MaterialParameter.AmbientAndDiffuse, defaultColor);
            GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Emission, new OpenTK.Graphics.Color4(0, 0, 0, 0));
            GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Specular, new float[] { 1.0f, 1.0f, 1.0f, 1.0f });
            GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Shininess, 50f);
            method = Main.threeDSettings.filamentVisualization;
            wfac = Main.threeDSettings.widthOverHeight;
            h = Main.threeDSettings.layerHeight;
            w = h * wfac;
            fixedH = Main.threeDSettings.useLayerHeight;
            dfac = (float)(Math.PI * Main.threeDSettings.filamentDiameter * Main.threeDSettings.filamentDiameter * 0.25 / wfac);
            recompute = lastFilHeight != h || lastFilWidth != w || fixedH != lastFilUseHeight || dfac != lastFilDiameter;
            lastFilHeight = h;
            lastFilWidth = w;
            lastFilDiameter = dfac;
            lastFilUseHeight = fixedH;
            foreach (GCodePath path in segments)
            {
                drawSegment(path);
            }
            // timeStart = DateTime.Now.Ticks - timeStart;
            //  double time = (double)timeStart * 0.1;
            // Main.conn.log("OpenGL paint time " + time.ToString("0.0", GCode.format) + " microseconds",false,4);
        }
        public override bool Changed
        {
            get
            {
                return changed;
            }
        }
    }
}
