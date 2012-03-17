namespace RepetierHost
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStartHistory = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripEndHistory = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eeprom = new System.Windows.Forms.ToolStripMenuItem();
            this.skeinforgeSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threeDSettingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.repetierSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internalSlicingParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slicerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeSlicerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slic3rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.externalSlic3rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skeinforgeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.slic3rConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.externalSlic3rConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skeinforgeConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.externalSlic3rSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skeinforgeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.killSlicingProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printerInformationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSDCardManager = new System.Windows.Forms.ToolStripMenuItem();
            this.testCaseGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repetierHostHomepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.slic3rHomepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skeinforgeHomepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.repRapWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repRapForumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thingiverseNewestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thingiversePopularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutRepetierHostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.toolConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTempReading = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.fpsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolConnect = new System.Windows.Forms.ToolStripSplitButton();
            this.toolLoad = new System.Windows.Forms.ToolStripSplitButton();
            this.toolRunJob = new System.Windows.Forms.ToolStripButton();
            this.toolKillJob = new System.Windows.Forms.ToolStripButton();
            this.toolStripSDCard = new System.Windows.Forms.ToolStripButton();
            this.toolShowLog = new System.Windows.Forms.ToolStripButton();
            this.toolShowFilament = new System.Windows.Forms.ToolStripButton();
            this.toolStripEmergencyButton = new System.Windows.Forms.ToolStripButton();
            this.toolPrinterSettings = new System.Windows.Forms.ToolStripButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.openGCode = new System.Windows.Forms.OpenFileDialog();
            this.saveJobDialog = new System.Windows.Forms.SaveFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.splitLog = new System.Windows.Forms.SplitContainer();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabModel = new System.Windows.Forms.TabPage();
            this.stlComposer1 = new RepetierHost.view.STLComposer();
            this.tabGCode = new System.Windows.Forms.TabPage();
            this.splitJob = new System.Windows.Forms.SplitContainer();
            this.editor = new RepetierHost.view.RepetierEditor();
            this.tabPrint = new System.Windows.Forms.TabPage();
            this.splitContainerPrinterGraphic = new System.Windows.Forms.SplitContainer();
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.splitLog.Panel1.SuspendLayout();
            this.splitLog.SuspendLayout();
            this.tab.SuspendLayout();
            this.tabModel.SuspendLayout();
            this.tabGCode.SuspendLayout();
            this.splitJob.Panel1.SuspendLayout();
            this.splitJob.SuspendLayout();
            this.tabPrint.SuspendLayout();
            this.splitContainerPrinterGraphic.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.slicerToolStripMenuItem,
            this.windowsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1018, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadGCodeToolStripMenuItem,
            this.toolStripStartHistory,
            this.toolStripEndHistory,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadGCodeToolStripMenuItem
            // 
            this.loadGCodeToolStripMenuItem.Name = "loadGCodeToolStripMenuItem";
            this.loadGCodeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.loadGCodeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.loadGCodeToolStripMenuItem.Text = "&Load G-Code";
            this.loadGCodeToolStripMenuItem.Click += new System.EventHandler(this.toolGCodeLoad_Click);
            // 
            // toolStripStartHistory
            // 
            this.toolStripStartHistory.Name = "toolStripStartHistory";
            this.toolStripStartHistory.Size = new System.Drawing.Size(160, 6);
            // 
            // toolStripEndHistory
            // 
            this.toolStripEndHistory.Name = "toolStripEndHistory";
            this.toolStripEndHistory.Size = new System.Drawing.Size(160, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printerSettingsToolStripMenuItem,
            this.eeprom,
            this.skeinforgeSettingsToolStripMenuItem,
            this.threeDSettingsMenu,
            this.repetierSettingsToolStripMenuItem,
            this.internalSlicingParameterToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.settingsToolStripMenuItem.Text = "&Config";
            // 
            // printerSettingsToolStripMenuItem
            // 
            this.printerSettingsToolStripMenuItem.Name = "printerSettingsToolStripMenuItem";
            this.printerSettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printerSettingsToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.printerSettingsToolStripMenuItem.Text = "&Printer settings";
            this.printerSettingsToolStripMenuItem.Click += new System.EventHandler(this.printerSettingsToolStripMenuItem_Click);
            // 
            // eeprom
            // 
            this.eeprom.Enabled = false;
            this.eeprom.Name = "eeprom";
            this.eeprom.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.eeprom.Size = new System.Drawing.Size(252, 22);
            this.eeprom.Text = "Firmware EEPROM settings";
            this.eeprom.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // skeinforgeSettingsToolStripMenuItem
            // 
            this.skeinforgeSettingsToolStripMenuItem.Name = "skeinforgeSettingsToolStripMenuItem";
            this.skeinforgeSettingsToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.skeinforgeSettingsToolStripMenuItem.Text = "Skeinforge settings";
            this.skeinforgeSettingsToolStripMenuItem.Click += new System.EventHandler(this.skeinforgeSettingsToolStripMenuItem_Click);
            // 
            // threeDSettingsMenu
            // 
            this.threeDSettingsMenu.Name = "threeDSettingsMenu";
            this.threeDSettingsMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3)));
            this.threeDSettingsMenu.Size = new System.Drawing.Size(252, 22);
            this.threeDSettingsMenu.Text = "3D settings";
            this.threeDSettingsMenu.Click += new System.EventHandler(this.threeDSettingsMenu_Click);
            // 
            // repetierSettingsToolStripMenuItem
            // 
            this.repetierSettingsToolStripMenuItem.Name = "repetierSettingsToolStripMenuItem";
            this.repetierSettingsToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.repetierSettingsToolStripMenuItem.Text = "Repetier settings";
            this.repetierSettingsToolStripMenuItem.Click += new System.EventHandler(this.repetierSettingsToolStripMenuItem_Click);
            // 
            // internalSlicingParameterToolStripMenuItem
            // 
            this.internalSlicingParameterToolStripMenuItem.Name = "internalSlicingParameterToolStripMenuItem";
            this.internalSlicingParameterToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.internalSlicingParameterToolStripMenuItem.Text = "Internal slicing parameter";
            this.internalSlicingParameterToolStripMenuItem.Click += new System.EventHandler(this.internalSlicingParameterToolStripMenuItem_Click);
            // 
            // slicerToolStripMenuItem
            // 
            this.slicerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeSlicerToolStripMenuItem,
            this.slic3rToolStripMenuItem,
            this.externalSlic3rToolStripMenuItem,
            this.skeinforgeToolStripMenuItem1,
            this.toolStripSeparator1,
            this.slic3rConfigurationToolStripMenuItem,
            this.externalSlic3rConfigurationToolStripMenuItem,
            this.skeinforgeConfigurationToolStripMenuItem,
            this.toolStripMenuItem4,
            this.externalSlic3rSetupToolStripMenuItem,
            this.skeinforgeToolStripMenuItem2,
            this.toolStripMenuItem3,
            this.killSlicingProcessToolStripMenuItem});
            this.slicerToolStripMenuItem.Name = "slicerToolStripMenuItem";
            this.slicerToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.slicerToolStripMenuItem.Text = " Slicer";
            // 
            // activeSlicerToolStripMenuItem
            // 
            this.activeSlicerToolStripMenuItem.Enabled = false;
            this.activeSlicerToolStripMenuItem.Name = "activeSlicerToolStripMenuItem";
            this.activeSlicerToolStripMenuItem.Size = new System.Drawing.Size(346, 22);
            this.activeSlicerToolStripMenuItem.Text = "Active slicer";
            // 
            // slic3rToolStripMenuItem
            // 
            this.slic3rToolStripMenuItem.Checked = true;
            this.slic3rToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.slic3rToolStripMenuItem.Name = "slic3rToolStripMenuItem";
            this.slic3rToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.slic3rToolStripMenuItem.Size = new System.Drawing.Size(346, 22);
            this.slic3rToolStripMenuItem.Text = "Internal Slic3r";
            this.slic3rToolStripMenuItem.Click += new System.EventHandler(this.slic3rToolStripMenuItem_Click);
            // 
            // externalSlic3rToolStripMenuItem
            // 
            this.externalSlic3rToolStripMenuItem.Name = "externalSlic3rToolStripMenuItem";
            this.externalSlic3rToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.externalSlic3rToolStripMenuItem.Size = new System.Drawing.Size(346, 22);
            this.externalSlic3rToolStripMenuItem.Text = "External Slic3r";
            this.externalSlic3rToolStripMenuItem.Click += new System.EventHandler(this.externalSlic3rToolStripMenuItem_Click);
            // 
            // skeinforgeToolStripMenuItem1
            // 
            this.skeinforgeToolStripMenuItem1.Name = "skeinforgeToolStripMenuItem1";
            this.skeinforgeToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.skeinforgeToolStripMenuItem1.Size = new System.Drawing.Size(346, 22);
            this.skeinforgeToolStripMenuItem1.Text = "Skeinforge";
            this.skeinforgeToolStripMenuItem1.Click += new System.EventHandler(this.skeinforgeToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(343, 6);
            // 
            // slic3rConfigurationToolStripMenuItem
            // 
            this.slic3rConfigurationToolStripMenuItem.Name = "slic3rConfigurationToolStripMenuItem";
            this.slic3rConfigurationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.D1)));
            this.slic3rConfigurationToolStripMenuItem.Size = new System.Drawing.Size(346, 22);
            this.slic3rConfigurationToolStripMenuItem.Text = "Internal Slic3r configuration";
            this.slic3rConfigurationToolStripMenuItem.Click += new System.EventHandler(this.slic3rConfigurationToolStripMenuItem_Click);
            // 
            // externalSlic3rConfigurationToolStripMenuItem
            // 
            this.externalSlic3rConfigurationToolStripMenuItem.Name = "externalSlic3rConfigurationToolStripMenuItem";
            this.externalSlic3rConfigurationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.D2)));
            this.externalSlic3rConfigurationToolStripMenuItem.Size = new System.Drawing.Size(346, 22);
            this.externalSlic3rConfigurationToolStripMenuItem.Text = "External Slic3r configuration";
            this.externalSlic3rConfigurationToolStripMenuItem.Click += new System.EventHandler(this.externalSlic3rConfigurationToolStripMenuItem_Click);
            // 
            // skeinforgeConfigurationToolStripMenuItem
            // 
            this.skeinforgeConfigurationToolStripMenuItem.Name = "skeinforgeConfigurationToolStripMenuItem";
            this.skeinforgeConfigurationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.D3)));
            this.skeinforgeConfigurationToolStripMenuItem.Size = new System.Drawing.Size(346, 22);
            this.skeinforgeConfigurationToolStripMenuItem.Text = "Skeinforge configuration";
            this.skeinforgeConfigurationToolStripMenuItem.Click += new System.EventHandler(this.skeinforgeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(343, 6);
            // 
            // externalSlic3rSetupToolStripMenuItem
            // 
            this.externalSlic3rSetupToolStripMenuItem.Name = "externalSlic3rSetupToolStripMenuItem";
            this.externalSlic3rSetupToolStripMenuItem.Size = new System.Drawing.Size(346, 22);
            this.externalSlic3rSetupToolStripMenuItem.Text = "Slic3r setup";
            this.externalSlic3rSetupToolStripMenuItem.Click += new System.EventHandler(this.externalSlic3rSetupToolStripMenuItem_Click);
            // 
            // skeinforgeToolStripMenuItem2
            // 
            this.skeinforgeToolStripMenuItem2.Name = "skeinforgeToolStripMenuItem2";
            this.skeinforgeToolStripMenuItem2.Size = new System.Drawing.Size(346, 22);
            this.skeinforgeToolStripMenuItem2.Text = "Skeinforge setup";
            this.skeinforgeToolStripMenuItem2.Click += new System.EventHandler(this.skeinforgeSettingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(343, 6);
            // 
            // killSlicingProcessToolStripMenuItem
            // 
            this.killSlicingProcessToolStripMenuItem.Name = "killSlicingProcessToolStripMenuItem";
            this.killSlicingProcessToolStripMenuItem.Size = new System.Drawing.Size(346, 22);
            this.killSlicingProcessToolStripMenuItem.Text = "Kill slicing process";
            this.killSlicingProcessToolStripMenuItem.Click += new System.EventHandler(this.killSlicingProcessToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temperatureMonitorToolStripMenuItem,
            this.printerInformationsToolStripMenuItem,
            this.jobStatusToolStripMenuItem,
            this.menuSDCardManager,
            this.testCaseGeneratorToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.windowsToolStripMenuItem.Text = "&Printer";
            // 
            // temperatureMonitorToolStripMenuItem
            // 
            this.temperatureMonitorToolStripMenuItem.Name = "temperatureMonitorToolStripMenuItem";
            this.temperatureMonitorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.temperatureMonitorToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.temperatureMonitorToolStripMenuItem.Text = "Temperature monitor";
            this.temperatureMonitorToolStripMenuItem.Click += new System.EventHandler(this.temperatureMonitorToolStripMenuItem_Click);
            // 
            // printerInformationsToolStripMenuItem
            // 
            this.printerInformationsToolStripMenuItem.Name = "printerInformationsToolStripMenuItem";
            this.printerInformationsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.printerInformationsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.printerInformationsToolStripMenuItem.Text = "Printer information";
            this.printerInformationsToolStripMenuItem.Click += new System.EventHandler(this.printerInformationsToolStripMenuItem_Click);
            // 
            // jobStatusToolStripMenuItem
            // 
            this.jobStatusToolStripMenuItem.Name = "jobStatusToolStripMenuItem";
            this.jobStatusToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.J)));
            this.jobStatusToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.jobStatusToolStripMenuItem.Text = "Job status";
            this.jobStatusToolStripMenuItem.Click += new System.EventHandler(this.jobStatusToolStripMenuItem_Click);
            // 
            // menuSDCardManager
            // 
            this.menuSDCardManager.Name = "menuSDCardManager";
            this.menuSDCardManager.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.menuSDCardManager.Size = new System.Drawing.Size(225, 22);
            this.menuSDCardManager.Text = "SD card manager";
            this.menuSDCardManager.Click += new System.EventHandler(this.toolStripSDCard_Click);
            // 
            // testCaseGeneratorToolStripMenuItem
            // 
            this.testCaseGeneratorToolStripMenuItem.Name = "testCaseGeneratorToolStripMenuItem";
            this.testCaseGeneratorToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.testCaseGeneratorToolStripMenuItem.Text = "Test case generator";
            this.testCaseGeneratorToolStripMenuItem.Click += new System.EventHandler(this.testCaseGeneratorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repetierHostHomepageToolStripMenuItem,
            this.manualToolStripMenuItem,
            this.toolStripMenuItem2,
            this.slic3rHomepageToolStripMenuItem,
            this.skeinforgeHomepageToolStripMenuItem,
            this.toolStripSeparator2,
            this.repRapWebsiteToolStripMenuItem,
            this.repRapForumToolStripMenuItem,
            this.thingiverseNewestToolStripMenuItem,
            this.thingiversePopularToolStripMenuItem,
            this.toolStripMenuItem1,
            this.aboutRepetierHostToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // repetierHostHomepageToolStripMenuItem
            // 
            this.repetierHostHomepageToolStripMenuItem.Name = "repetierHostHomepageToolStripMenuItem";
            this.repetierHostHomepageToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.repetierHostHomepageToolStripMenuItem.Text = "Repetier-Host homepage";
            this.repetierHostHomepageToolStripMenuItem.Click += new System.EventHandler(this.repetierHostHomepageToolStripMenuItem_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(204, 6);
            // 
            // slic3rHomepageToolStripMenuItem
            // 
            this.slic3rHomepageToolStripMenuItem.Name = "slic3rHomepageToolStripMenuItem";
            this.slic3rHomepageToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.slic3rHomepageToolStripMenuItem.Text = "Slic3r homepage";
            this.slic3rHomepageToolStripMenuItem.Click += new System.EventHandler(this.slic3rHomepageToolStripMenuItem_Click);
            // 
            // skeinforgeHomepageToolStripMenuItem
            // 
            this.skeinforgeHomepageToolStripMenuItem.Name = "skeinforgeHomepageToolStripMenuItem";
            this.skeinforgeHomepageToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.skeinforgeHomepageToolStripMenuItem.Text = "Skeinforge homepage";
            this.skeinforgeHomepageToolStripMenuItem.Click += new System.EventHandler(this.skeinforgeHomepageToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // repRapWebsiteToolStripMenuItem
            // 
            this.repRapWebsiteToolStripMenuItem.Name = "repRapWebsiteToolStripMenuItem";
            this.repRapWebsiteToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.repRapWebsiteToolStripMenuItem.Text = "RepRap website";
            this.repRapWebsiteToolStripMenuItem.Click += new System.EventHandler(this.repRapWebsiteToolStripMenuItem_Click);
            // 
            // repRapForumToolStripMenuItem
            // 
            this.repRapForumToolStripMenuItem.Name = "repRapForumToolStripMenuItem";
            this.repRapForumToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.repRapForumToolStripMenuItem.Text = "RepRap forum";
            this.repRapForumToolStripMenuItem.Click += new System.EventHandler(this.repRapForumToolStripMenuItem_Click);
            // 
            // thingiverseNewestToolStripMenuItem
            // 
            this.thingiverseNewestToolStripMenuItem.Name = "thingiverseNewestToolStripMenuItem";
            this.thingiverseNewestToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.thingiverseNewestToolStripMenuItem.Text = "Thingiverse newest";
            this.thingiverseNewestToolStripMenuItem.Click += new System.EventHandler(this.thingiverseNewestToolStripMenuItem_Click);
            // 
            // thingiversePopularToolStripMenuItem
            // 
            this.thingiversePopularToolStripMenuItem.Name = "thingiversePopularToolStripMenuItem";
            this.thingiversePopularToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.thingiversePopularToolStripMenuItem.Text = "Thingiverse popular";
            this.thingiversePopularToolStripMenuItem.Click += new System.EventHandler(this.thingiversePopularToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(204, 6);
            // 
            // aboutRepetierHostToolStripMenuItem
            // 
            this.aboutRepetierHostToolStripMenuItem.Name = "aboutRepetierHostToolStripMenuItem";
            this.aboutRepetierHostToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.aboutRepetierHostToolStripMenuItem.Text = "&About Repetier-Host";
            this.aboutRepetierHostToolStripMenuItem.Click += new System.EventHandler(this.aboutRepetierHostToolStripMenuItem_Click);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolConnection,
            this.toolTempReading,
            this.toolAction,
            this.toolProgress,
            this.fpsLabel});
            this.status.Location = new System.Drawing.Point(0, 508);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.status.Size = new System.Drawing.Size(1018, 22);
            this.status.TabIndex = 1;
            this.status.Text = "statusStrip1";
            // 
            // toolConnection
            // 
            this.toolConnection.Name = "toolConnection";
            this.toolConnection.Size = new System.Drawing.Size(86, 17);
            this.toolConnection.Text = "Not connected";
            // 
            // toolTempReading
            // 
            this.toolTempReading.Name = "toolTempReading";
            this.toolTempReading.Size = new System.Drawing.Size(12, 17);
            this.toolTempReading.Text = "-";
            // 
            // toolAction
            // 
            this.toolAction.Name = "toolAction";
            this.toolAction.Size = new System.Drawing.Size(26, 17);
            this.toolAction.Text = "Idle";
            // 
            // toolProgress
            // 
            this.toolProgress.Name = "toolProgress";
            this.toolProgress.Size = new System.Drawing.Size(214, 16);
            // 
            // fpsLabel
            // 
            this.fpsLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(34, 17);
            this.fpsLabel.Text = "- FPS";
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolConnect,
            this.toolLoad,
            this.toolRunJob,
            this.toolKillJob,
            this.toolStripSDCard,
            this.toolShowLog,
            this.toolShowFilament,
            this.toolStripEmergencyButton,
            this.toolPrinterSettings});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1018, 54);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolConnect
            // 
            this.toolConnect.Image = ((System.Drawing.Image)(resources.GetObject("toolConnect.Image")));
            this.toolConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolConnect.Name = "toolConnect";
            this.toolConnect.Size = new System.Drawing.Size(68, 51);
            this.toolConnect.Text = "Connect";
            this.toolConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolConnect.ToolTipText = "Connect printer";
            this.toolConnect.ButtonClick += new System.EventHandler(this.toolConnect_Click);
            // 
            // toolLoad
            // 
            this.toolLoad.Image = ((System.Drawing.Image)(resources.GetObject("toolLoad.Image")));
            this.toolLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLoad.Name = "toolLoad";
            this.toolLoad.Size = new System.Drawing.Size(49, 51);
            this.toolLoad.Text = "Load";
            this.toolLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolLoad.ToolTipText = "Load file";
            this.toolLoad.ButtonClick += new System.EventHandler(this.toolGCodeLoad_Click);
            // 
            // toolRunJob
            // 
            this.toolRunJob.Image = ((System.Drawing.Image)(resources.GetObject("toolRunJob.Image")));
            this.toolRunJob.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRunJob.Name = "toolRunJob";
            this.toolRunJob.Size = new System.Drawing.Size(52, 51);
            this.toolRunJob.Text = "Run job";
            this.toolRunJob.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolRunJob.Click += new System.EventHandler(this.toolPrintJob_Click);
            // 
            // toolKillJob
            // 
            this.toolKillJob.Enabled = false;
            this.toolKillJob.Image = ((System.Drawing.Image)(resources.GetObject("toolKillJob.Image")));
            this.toolKillJob.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolKillJob.Name = "toolKillJob";
            this.toolKillJob.Size = new System.Drawing.Size(48, 51);
            this.toolKillJob.Text = "Kill Job";
            this.toolKillJob.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolKillJob.Click += new System.EventHandler(this.toolKillJob_Click);
            // 
            // toolStripSDCard
            // 
            this.toolStripSDCard.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSDCard.Image")));
            this.toolStripSDCard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSDCard.Name = "toolStripSDCard";
            this.toolStripSDCard.Size = new System.Drawing.Size(50, 51);
            this.toolStripSDCard.Text = "SDCard";
            this.toolStripSDCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripSDCard.ToolTipText = "SDCard management";
            this.toolStripSDCard.Click += new System.EventHandler(this.toolStripSDCard_Click);
            // 
            // toolShowLog
            // 
            this.toolShowLog.Checked = true;
            this.toolShowLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolShowLog.Image = ((System.Drawing.Image)(resources.GetObject("toolShowLog.Image")));
            this.toolShowLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolShowLog.Name = "toolShowLog";
            this.toolShowLog.Size = new System.Drawing.Size(71, 51);
            this.toolShowLog.Text = "Toggle Log";
            this.toolShowLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolShowLog.ToolTipText = "Hide log";
            this.toolShowLog.CheckedChanged += new System.EventHandler(this.toolShowLog_CheckedChanged);
            this.toolShowLog.Click += new System.EventHandler(this.toolShowLog_Click);
            // 
            // toolShowFilament
            // 
            this.toolShowFilament.Image = ((System.Drawing.Image)(resources.GetObject("toolShowFilament.Image")));
            this.toolShowFilament.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolShowFilament.Name = "toolShowFilament";
            this.toolShowFilament.Size = new System.Drawing.Size(87, 51);
            this.toolShowFilament.Text = "Show filament";
            this.toolShowFilament.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolShowFilament.Click += new System.EventHandler(this.toolShowFilament_Click);
            // 
            // toolStripEmergencyButton
            // 
            this.toolStripEmergencyButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripEmergencyButton.AutoToolTip = false;
            this.toolStripEmergencyButton.BackColor = System.Drawing.Color.White;
            this.toolStripEmergencyButton.Enabled = false;
            this.toolStripEmergencyButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripEmergencyButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripEmergencyButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEmergencyButton.Image")));
            this.toolStripEmergencyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEmergencyButton.Name = "toolStripEmergencyButton";
            this.toolStripEmergencyButton.Size = new System.Drawing.Size(96, 51);
            this.toolStripEmergencyButton.Text = "Emergency stop";
            this.toolStripEmergencyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripEmergencyButton.Click += new System.EventHandler(this.toolStripEmergencyButton_Click);
            // 
            // toolPrinterSettings
            // 
            this.toolPrinterSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolPrinterSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolPrinterSettings.Image")));
            this.toolPrinterSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPrinterSettings.Name = "toolPrinterSettings";
            this.toolPrinterSettings.Size = new System.Drawing.Size(90, 51);
            this.toolPrinterSettings.Text = "Printer settings";
            this.toolPrinterSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolPrinterSettings.Click += new System.EventHandler(this.printerSettingsToolStripMenuItem_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "connect.png");
            this.imageList.Images.SetKeyName(1, "disconnect.png");
            this.imageList.Images.SetKeyName(2, "runjob32.png");
            this.imageList.Images.SetKeyName(3, "pauseicon.png");
            this.imageList.Images.SetKeyName(4, "preview.png");
            this.imageList.Images.SetKeyName(5, "previewoff.png");
            // 
            // openGCode
            // 
            this.openGCode.DefaultExt = "gcode";
            this.openGCode.Filter = "GCode/STL-Files|*.gcode;*.stl|All files|*.*";
            this.openGCode.Title = "Import G-Code";
            // 
            // saveJobDialog
            // 
            this.saveJobDialog.DefaultExt = "gcode";
            this.saveJobDialog.Filter = "GCode|*.gcode|All files|*.*";
            this.saveJobDialog.Title = "Save G-Code";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // splitLog
            // 
            this.splitLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLog.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitLog.Location = new System.Drawing.Point(0, 78);
            this.splitLog.Name = "splitLog";
            this.splitLog.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitLog.Panel1
            // 
            this.splitLog.Panel1.Controls.Add(this.tab);
            this.splitLog.Size = new System.Drawing.Size(1018, 430);
            this.splitLog.SplitterDistance = 332;
            this.splitLog.TabIndex = 4;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabModel);
            this.tab.Controls.Add(this.tabGCode);
            this.tab.Controls.Add(this.tabPrint);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1016, 330);
            this.tab.TabIndex = 3;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
            // 
            // tabModel
            // 
            this.tabModel.BackColor = System.Drawing.SystemColors.Control;
            this.tabModel.Controls.Add(this.stlComposer1);
            this.tabModel.Location = new System.Drawing.Point(4, 22);
            this.tabModel.Name = "tabModel";
            this.tabModel.Size = new System.Drawing.Size(1008, 304);
            this.tabModel.TabIndex = 2;
            this.tabModel.Text = "Object placements";
            // 
            // stlComposer1
            // 
            this.stlComposer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stlComposer1.Location = new System.Drawing.Point(0, 0);
            this.stlComposer1.Margin = new System.Windows.Forms.Padding(4);
            this.stlComposer1.Name = "stlComposer1";
            this.stlComposer1.Size = new System.Drawing.Size(1008, 304);
            this.stlComposer1.TabIndex = 0;
            // 
            // tabGCode
            // 
            this.tabGCode.AutoScroll = true;
            this.tabGCode.BackColor = System.Drawing.SystemColors.Control;
            this.tabGCode.Controls.Add(this.splitJob);
            this.tabGCode.Location = new System.Drawing.Point(4, 22);
            this.tabGCode.Name = "tabGCode";
            this.tabGCode.Padding = new System.Windows.Forms.Padding(3);
            this.tabGCode.Size = new System.Drawing.Size(1008, 304);
            this.tabGCode.TabIndex = 1;
            this.tabGCode.Text = "G-Code visual editor";
            // 
            // splitJob
            // 
            this.splitJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitJob.BackColor = System.Drawing.Color.Transparent;
            this.splitJob.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitJob.Location = new System.Drawing.Point(3, 3);
            this.splitJob.Name = "splitJob";
            // 
            // splitJob.Panel1
            // 
            this.splitJob.Panel1.Controls.Add(this.editor);
            this.splitJob.Size = new System.Drawing.Size(1001, 295);
            this.splitJob.SplitterDistance = 500;
            this.splitJob.TabIndex = 3;
            // 
            // editor
            // 
            this.editor.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.editor.autopreview = true;
            this.editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editor.Location = new System.Drawing.Point(0, 0);
            this.editor.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.editor.MaxLayer = 0;
            this.editor.MinimumSize = new System.Drawing.Size(160, 138);
            this.editor.Name = "editor";
            this.editor.ShowMaxLayer = 0;
            this.editor.ShowMinLayer = 0;
            this.editor.ShowMode = 0;
            this.editor.Size = new System.Drawing.Size(500, 295);
            this.editor.TabIndex = 0;
            // 
            // tabPrint
            // 
            this.tabPrint.BackColor = System.Drawing.SystemColors.Control;
            this.tabPrint.Controls.Add(this.splitContainerPrinterGraphic);
            this.tabPrint.Location = new System.Drawing.Point(4, 22);
            this.tabPrint.Name = "tabPrint";
            this.tabPrint.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrint.Size = new System.Drawing.Size(1008, 304);
            this.tabPrint.TabIndex = 0;
            this.tabPrint.Text = "Manual control";
            // 
            // splitContainerPrinterGraphic
            // 
            this.splitContainerPrinterGraphic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPrinterGraphic.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerPrinterGraphic.Location = new System.Drawing.Point(3, 3);
            this.splitContainerPrinterGraphic.Name = "splitContainerPrinterGraphic";
            // 
            // splitContainerPrinterGraphic.Panel1
            // 
            this.splitContainerPrinterGraphic.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainerPrinterGraphic.Size = new System.Drawing.Size(1002, 298);
            this.splitContainerPrinterGraphic.SplitterDistance = 465;
            this.splitContainerPrinterGraphic.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 530);
            this.Controls.Add(this.splitLog);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Main";
            this.Text = "Repetier-Host V0.40";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.splitLog.Panel1.ResumeLayout(false);
            this.splitLog.ResumeLayout(false);
            this.tab.ResumeLayout(false);
            this.tabModel.ResumeLayout(false);
            this.tabGCode.ResumeLayout(false);
            this.splitJob.Panel1.ResumeLayout(false);
            this.splitJob.ResumeLayout(false);
            this.tabPrint.ResumeLayout(false);
            this.splitContainerPrinterGraphic.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripEndHistory;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutRepetierHostToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolConnection;
        private System.Windows.Forms.ToolStripStatusLabel toolAction;
        private System.Windows.Forms.ToolStripProgressBar toolProgress;
        private System.Windows.Forms.SplitContainer splitContainerPrinterGraphic;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printerSettingsToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.OpenFileDialog openGCode;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperatureMonitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skeinforgeSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threeDSettingsMenu;
        private System.Windows.Forms.ToolStripMenuItem printerInformationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repetierSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repetierHostHomepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        public System.Windows.Forms.ToolStripButton toolRunJob;
        public System.Windows.Forms.ToolStripButton toolKillJob;
        public System.Windows.Forms.ToolStripStatusLabel fpsLabel;
        private System.Windows.Forms.ToolStripMenuItem testCaseGeneratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internalSlicingParameterToolStripMenuItem;
        public System.Windows.Forms.TabControl tab;
        public System.Windows.Forms.TabPage tabPrint;
        public System.Windows.Forms.TabPage tabModel;
        public System.Windows.Forms.ToolStripButton toolStripSDCard;
        public System.Windows.Forms.ToolStripMenuItem menuSDCardManager;
        public System.Windows.Forms.SaveFileDialog saveJobDialog;
        public System.Windows.Forms.TabPage tabGCode;
        private System.Windows.Forms.SplitContainer splitJob;
        public RepetierHost.view.RepetierEditor editor;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripSplitButton toolConnect;
        private System.Windows.Forms.SplitContainer splitLog;
        private System.Windows.Forms.ToolStripButton toolShowLog;
        public System.Windows.Forms.ToolStripStatusLabel toolTempReading;
        private System.Windows.Forms.ToolStripSeparator toolStripStartHistory;
        private System.Windows.Forms.ToolStripSplitButton toolLoad;
        private System.Windows.Forms.ToolStripMenuItem slicerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeSlicerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem slic3rConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skeinforgeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem slic3rHomepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skeinforgeHomepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem repRapWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repRapForumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thingiverseNewestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thingiversePopularToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem slic3rToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem skeinforgeToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem skeinforgeConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolShowFilament;
        private System.Windows.Forms.ToolStripButton toolStripEmergencyButton;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem killSlicingProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolPrinterSettings;
        public RepetierHost.view.STLComposer stlComposer1;
        public System.Windows.Forms.ToolStripMenuItem eeprom;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem externalSlic3rSetupToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem externalSlic3rToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem externalSlic3rConfigurationToolStripMenuItem;
    }
}

