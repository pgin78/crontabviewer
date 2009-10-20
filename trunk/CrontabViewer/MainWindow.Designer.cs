namespace MaciejRogozinski.CrontabViewer
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rulesContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instancesContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleContextStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.RulesTab = new System.Windows.Forms.TabPage();
            this.ruleGridView = new System.Windows.Forms.DataGridView();
            this.IsExcluded = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Minute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weekday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taskname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstancesTab = new System.Windows.Forms.TabPage();
            this.instancePanel = new System.Windows.Forms.Panel();
            this.instanceGridView = new System.Windows.Forms.DataGridView();
            this.instanceControlPanel = new System.Windows.Forms.Panel();
            this.FilterButton = new System.Windows.Forms.Button();
            this.enableTimeFilter = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeFilterTo = new System.Windows.Forms.DateTimePicker();
            this.timeFilterFrom = new System.Windows.Forms.DateTimePicker();
            this.prevDayBtn = new System.Windows.Forms.Button();
            this.nextDayBtn = new System.Windows.Forms.Button();
            this.dateFilter = new System.Windows.Forms.DateTimePicker();
            this.ScheduleTab = new System.Windows.Forms.TabPage();
            this.scheduleBrowser = new System.Windows.Forms.WebBrowser();
            this.scheduleBrowsertMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rulesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instancesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.copyAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.RulesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ruleGridView)).BeginInit();
            this.InstancesTab.SuspendLayout();
            this.instancePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instanceGridView)).BeginInit();
            this.instanceControlPanel.SuspendLayout();
            this.ScheduleTab.SuspendLayout();
            this.scheduleBrowsertMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(769, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesToolStripMenuItem,
            this.instancesToolStripMenuItem,
            this.scheduleToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Checked = true;
            this.rulesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // instancesToolStripMenuItem
            // 
            this.instancesToolStripMenuItem.Name = "instancesToolStripMenuItem";
            this.instancesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.instancesToolStripMenuItem.Text = "Instances";
            this.instancesToolStripMenuItem.Click += new System.EventHandler(this.instancesToolStripMenuItem_Click);
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.scheduleToolStripMenuItem.Text = "Schedule";
            this.scheduleToolStripMenuItem.Click += new System.EventHandler(this.scheduleToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem,
            this.findToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.Enabled = false;
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.filterToolStripMenuItem.Text = "Filter...";
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Enabled = false;
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.findToolStripMenuItem.Text = "Find...";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesContextMenuItem,
            this.instancesContextMenuItem,
            this.scheduleContextStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 70);
            // 
            // rulesContextMenuItem
            // 
            this.rulesContextMenuItem.Checked = true;
            this.rulesContextMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rulesContextMenuItem.Name = "rulesContextMenuItem";
            this.rulesContextMenuItem.Size = new System.Drawing.Size(132, 22);
            this.rulesContextMenuItem.Text = "Rules";
            this.rulesContextMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // instancesContextMenuItem
            // 
            this.instancesContextMenuItem.Name = "instancesContextMenuItem";
            this.instancesContextMenuItem.Size = new System.Drawing.Size(132, 22);
            this.instancesContextMenuItem.Text = "Instances";
            this.instancesContextMenuItem.Click += new System.EventHandler(this.instancesToolStripMenuItem_Click);
            // 
            // scheduleContextStripMenuItem
            // 
            this.scheduleContextStripMenuItem.Name = "scheduleContextStripMenuItem";
            this.scheduleContextStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.scheduleContextStripMenuItem.Text = "Schedule";
            this.scheduleContextStripMenuItem.Click += new System.EventHandler(this.scheduleToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testToolStripMenuItem.Text = "test";
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.RulesTab);
            this.tabControl.Controls.Add(this.InstancesTab);
            this.tabControl.Controls.Add(this.ScheduleTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(769, 500);
            this.tabControl.TabIndex = 9;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // RulesTab
            // 
            this.RulesTab.Controls.Add(this.ruleGridView);
            this.RulesTab.Location = new System.Drawing.Point(4, 4);
            this.RulesTab.Name = "RulesTab";
            this.RulesTab.Padding = new System.Windows.Forms.Padding(3);
            this.RulesTab.Size = new System.Drawing.Size(761, 474);
            this.RulesTab.TabIndex = 0;
            this.RulesTab.Text = "Rules";
            this.RulesTab.UseVisualStyleBackColor = true;
            // 
            // ruleGridView
            // 
            this.ruleGridView.AllowUserToAddRows = false;
            this.ruleGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ruleGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ruleGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ruleGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ruleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ruleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsExcluded,
            this.Minute,
            this.Hour,
            this.Day,
            this.Month,
            this.Weekday,
            this.Taskname});
            this.ruleGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ruleGridView.Location = new System.Drawing.Point(3, 3);
            this.ruleGridView.MultiSelect = false;
            this.ruleGridView.Name = "ruleGridView";
            this.ruleGridView.ReadOnly = true;
            this.ruleGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ruleGridView.Size = new System.Drawing.Size(755, 468);
            this.ruleGridView.TabIndex = 1;
            this.ruleGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ruleGridView_CellMouseClick);
            this.ruleGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ruleGridView_CellFormatting);
            this.ruleGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ruleGridView_RowHeaderMouseDoubleClick);
            // 
            // IsExcluded
            // 
            this.IsExcluded.DataPropertyName = "IsExcluded";
            this.IsExcluded.HeaderText = "IsExcluded";
            this.IsExcluded.Name = "IsExcluded";
            this.IsExcluded.ReadOnly = true;
            this.IsExcluded.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsExcluded.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsExcluded.Width = 84;
            // 
            // Minute
            // 
            this.Minute.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Minute.DataPropertyName = "CrontabRawRule.Minute";
            this.Minute.HeaderText = "Minute";
            this.Minute.Name = "Minute";
            this.Minute.ReadOnly = true;
            this.Minute.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Minute.Width = 64;
            // 
            // Hour
            // 
            this.Hour.DataPropertyName = "CrontabRawRule.Hour";
            this.Hour.HeaderText = "Hour";
            this.Hour.Name = "Hour";
            this.Hour.ReadOnly = true;
            this.Hour.Width = 55;
            // 
            // Day
            // 
            this.Day.DataPropertyName = "CrontabRawRule.Day";
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            this.Day.Width = 51;
            // 
            // Month
            // 
            this.Month.DataPropertyName = "CrontabRawRule.Month";
            this.Month.HeaderText = "Month";
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            this.Month.Width = 62;
            // 
            // Weekday
            // 
            this.Weekday.DataPropertyName = "CrontabRawRule.Weekday";
            this.Weekday.HeaderText = "Weekday";
            this.Weekday.Name = "Weekday";
            this.Weekday.ReadOnly = true;
            this.Weekday.Width = 78;
            // 
            // Taskname
            // 
            this.Taskname.DataPropertyName = "TaskName";
            this.Taskname.HeaderText = "Taskname";
            this.Taskname.Name = "Taskname";
            this.Taskname.ReadOnly = true;
            this.Taskname.Width = 82;
            // 
            // InstancesTab
            // 
            this.InstancesTab.Controls.Add(this.instancePanel);
            this.InstancesTab.Location = new System.Drawing.Point(4, 4);
            this.InstancesTab.Name = "InstancesTab";
            this.InstancesTab.Padding = new System.Windows.Forms.Padding(3);
            this.InstancesTab.Size = new System.Drawing.Size(761, 474);
            this.InstancesTab.TabIndex = 1;
            this.InstancesTab.Text = "Instances";
            this.InstancesTab.UseVisualStyleBackColor = true;
            // 
            // instancePanel
            // 
            this.instancePanel.Controls.Add(this.instanceGridView);
            this.instancePanel.Controls.Add(this.instanceControlPanel);
            this.instancePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instancePanel.Location = new System.Drawing.Point(3, 3);
            this.instancePanel.Name = "instancePanel";
            this.instancePanel.Size = new System.Drawing.Size(755, 468);
            this.instancePanel.TabIndex = 6;
            // 
            // instanceGridView
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.instanceGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.instanceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.instanceGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.instanceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instanceGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instanceGridView.Location = new System.Drawing.Point(0, 0);
            this.instanceGridView.MultiSelect = false;
            this.instanceGridView.Name = "instanceGridView";
            this.instanceGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.instanceGridView.Size = new System.Drawing.Size(755, 419);
            this.instanceGridView.TabIndex = 0;
            // 
            // instanceControlPanel
            // 
            this.instanceControlPanel.Controls.Add(this.FilterButton);
            this.instanceControlPanel.Controls.Add(this.enableTimeFilter);
            this.instanceControlPanel.Controls.Add(this.label2);
            this.instanceControlPanel.Controls.Add(this.label1);
            this.instanceControlPanel.Controls.Add(this.timeFilterTo);
            this.instanceControlPanel.Controls.Add(this.timeFilterFrom);
            this.instanceControlPanel.Controls.Add(this.prevDayBtn);
            this.instanceControlPanel.Controls.Add(this.nextDayBtn);
            this.instanceControlPanel.Controls.Add(this.dateFilter);
            this.instanceControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.instanceControlPanel.Enabled = false;
            this.instanceControlPanel.Location = new System.Drawing.Point(0, 419);
            this.instanceControlPanel.Name = "instanceControlPanel";
            this.instanceControlPanel.Size = new System.Drawing.Size(755, 49);
            this.instanceControlPanel.TabIndex = 2;
            // 
            // FilterButton
            // 
            this.FilterButton.Enabled = false;
            this.FilterButton.Location = new System.Drawing.Point(603, 13);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(75, 23);
            this.FilterButton.TabIndex = 8;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // enableTimeFilter
            // 
            this.enableTimeFilter.AutoSize = true;
            this.enableTimeFilter.Location = new System.Drawing.Point(306, 17);
            this.enableTimeFilter.Name = "enableTimeFilter";
            this.enableTimeFilter.Size = new System.Drawing.Size(103, 17);
            this.enableTimeFilter.TabIndex = 7;
            this.enableTimeFilter.Text = "Enable time filter";
            this.enableTimeFilter.UseVisualStyleBackColor = true;
            this.enableTimeFilter.CheckedChanged += new System.EventHandler(this.enableTimeFilter_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "From:";
            // 
            // timeFilterTo
            // 
            this.timeFilterTo.CustomFormat = "HH:mm";
            this.timeFilterTo.Enabled = false;
            this.timeFilterTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeFilterTo.Location = new System.Drawing.Point(543, 14);
            this.timeFilterTo.Name = "timeFilterTo";
            this.timeFilterTo.ShowUpDown = true;
            this.timeFilterTo.Size = new System.Drawing.Size(54, 20);
            this.timeFilterTo.TabIndex = 4;
            // 
            // timeFilterFrom
            // 
            this.timeFilterFrom.CustomFormat = "HH:mm";
            this.timeFilterFrom.Enabled = false;
            this.timeFilterFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeFilterFrom.Location = new System.Drawing.Point(454, 14);
            this.timeFilterFrom.Name = "timeFilterFrom";
            this.timeFilterFrom.ShowUpDown = true;
            this.timeFilterFrom.Size = new System.Drawing.Size(54, 20);
            this.timeFilterFrom.TabIndex = 3;
            // 
            // prevDayBtn
            // 
            this.prevDayBtn.Location = new System.Drawing.Point(10, 13);
            this.prevDayBtn.Name = "prevDayBtn";
            this.prevDayBtn.Size = new System.Drawing.Size(75, 23);
            this.prevDayBtn.TabIndex = 2;
            this.prevDayBtn.Text = "Previous";
            this.prevDayBtn.UseVisualStyleBackColor = true;
            this.prevDayBtn.Click += new System.EventHandler(this.prevDayBtn_Click);
            // 
            // nextDayBtn
            // 
            this.nextDayBtn.Location = new System.Drawing.Point(186, 13);
            this.nextDayBtn.Name = "nextDayBtn";
            this.nextDayBtn.Size = new System.Drawing.Size(75, 23);
            this.nextDayBtn.TabIndex = 1;
            this.nextDayBtn.Text = "Next";
            this.nextDayBtn.UseVisualStyleBackColor = true;
            this.nextDayBtn.Click += new System.EventHandler(this.nextDayBtn_Click);
            // 
            // dateFilter
            // 
            this.dateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFilter.Location = new System.Drawing.Point(91, 14);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.Size = new System.Drawing.Size(89, 20);
            this.dateFilter.TabIndex = 0;
            this.dateFilter.ValueChanged += new System.EventHandler(this.dateFilter_ValueChanged);
            // 
            // ScheduleTab
            // 
            this.ScheduleTab.Controls.Add(this.scheduleBrowser);
            this.ScheduleTab.Location = new System.Drawing.Point(4, 4);
            this.ScheduleTab.Name = "ScheduleTab";
            this.ScheduleTab.Size = new System.Drawing.Size(761, 474);
            this.ScheduleTab.TabIndex = 2;
            this.ScheduleTab.Text = "Schedule";
            this.ScheduleTab.UseVisualStyleBackColor = true;
            // 
            // scheduleBrowser
            // 
            this.scheduleBrowser.ContextMenuStrip = this.scheduleBrowsertMenuStrip;
            this.scheduleBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scheduleBrowser.IsWebBrowserContextMenuEnabled = false;
            this.scheduleBrowser.Location = new System.Drawing.Point(0, 0);
            this.scheduleBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.scheduleBrowser.Name = "scheduleBrowser";
            this.scheduleBrowser.Size = new System.Drawing.Size(761, 474);
            this.scheduleBrowser.TabIndex = 0;
            // 
            // scheduleBrowsertMenuStrip
            // 
            this.scheduleBrowsertMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesReportToolStripMenuItem,
            this.instancesReportToolStripMenuItem,
            this.scheduleReportToolStripMenuItem,
            this.toolStripMenuItem5,
            this.copyAllToolStripMenuItem});
            this.scheduleBrowsertMenuStrip.Name = "scheduleBrowsertMenuStrip";
            this.scheduleBrowsertMenuStrip.Size = new System.Drawing.Size(133, 98);
            // 
            // rulesReportToolStripMenuItem
            // 
            this.rulesReportToolStripMenuItem.Checked = true;
            this.rulesReportToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rulesReportToolStripMenuItem.Name = "rulesReportToolStripMenuItem";
            this.rulesReportToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.rulesReportToolStripMenuItem.Text = "Rules";
            this.rulesReportToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // instancesReportToolStripMenuItem
            // 
            this.instancesReportToolStripMenuItem.Name = "instancesReportToolStripMenuItem";
            this.instancesReportToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.instancesReportToolStripMenuItem.Text = "Instances";
            this.instancesReportToolStripMenuItem.Click += new System.EventHandler(this.instancesToolStripMenuItem_Click);
            // 
            // scheduleReportToolStripMenuItem
            // 
            this.scheduleReportToolStripMenuItem.Name = "scheduleReportToolStripMenuItem";
            this.scheduleReportToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.scheduleReportToolStripMenuItem.Text = "Schedule";
            this.scheduleReportToolStripMenuItem.Click += new System.EventHandler(this.scheduleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(129, 6);
            // 
            // copyAllToolStripMenuItem
            // 
            this.copyAllToolStripMenuItem.Name = "copyAllToolStripMenuItem";
            this.copyAllToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.copyAllToolStripMenuItem.Text = "Copy All";
            this.copyAllToolStripMenuItem.Click += new System.EventHandler(this.copyAllToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 524);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainWindow";
            this.Text = "           CrontabViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.WindowTitle = "           CrontabViewer";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.RulesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ruleGridView)).EndInit();
            this.InstancesTab.ResumeLayout(false);
            this.instancePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.instanceGridView)).EndInit();
            this.instanceControlPanel.ResumeLayout(false);
            this.instanceControlPanel.PerformLayout();
            this.ScheduleTab.ResumeLayout(false);
            this.scheduleBrowsertMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instancesToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instancesContextMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage RulesTab;
        private System.Windows.Forms.TabPage InstancesTab;
        private System.Windows.Forms.Panel instancePanel;
        private System.Windows.Forms.DataGridView instanceGridView;
        private System.Windows.Forms.Panel instanceControlPanel;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.CheckBox enableTimeFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker timeFilterTo;
        private System.Windows.Forms.DateTimePicker timeFilterFrom;
        private System.Windows.Forms.Button prevDayBtn;
        private System.Windows.Forms.Button nextDayBtn;
        private System.Windows.Forms.DateTimePicker dateFilter;
        private System.Windows.Forms.TabPage ScheduleTab;
        private System.Windows.Forms.WebBrowser scheduleBrowser;
        private System.Windows.Forms.DataGridView ruleGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsExcluded;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minute;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weekday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taskname;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleContextStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip scheduleBrowsertMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem rulesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instancesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem copyAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}