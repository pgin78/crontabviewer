using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaciejRogozinski.CrontabViewer.Engine;
using System.IO;
using System.Text.RegularExpressions;
using System.Reflection;
//TODO: add background worker for time consuming operation ie. generating instances
//TODO: add statistic, number of read/discarded tasks
namespace MaciejRogozinski.CrontabViewer
{
    public partial class MainWindow : BaseForm
    {
        /// <summary>
        /// Defines states of a main window view.
        /// </summary>
        public enum MainWindowView { InstanceView, RuleView, ScheduleView };

        private MainWindowView activeView = MainWindowView.RuleView;
        /// <summary>
        /// Get, sets view for a main window.
        /// Causes some controls to change state or visibility depending on the view.
        /// </summary>
        public MainWindowView ActiveView
        {
            get
            {
                return this.activeView;
            }
            set
            {
                this.activeView = value;

                switch (this.activeView)
                {
                    case MainWindowView.RuleView:
                        this.rulesToolStripMenuItem.Checked = true;
                        this.instancesToolStripMenuItem.Checked = false;
                        this.scheduleToolStripMenuItem.Checked = false;

                        this.rulesContextMenuItem.Checked = true;
                        this.instancesContextMenuItem.Checked = false;
                        this.scheduleContextStripMenuItem.Checked = false;

                        this.rulesReportToolStripMenuItem.Checked = true;
                        this.instancesReportToolStripMenuItem.Checked = false;
                        this.scheduleReportToolStripMenuItem.Checked = false;

                        this.filterToolStripMenuItem.Enabled = true;
                        this.findToolStripMenuItem.Enabled = true;
                        break;

                    case MainWindowView.InstanceView:
                        this.rulesToolStripMenuItem.Checked = false;
                        this.instancesToolStripMenuItem.Checked = true;
                        this.scheduleToolStripMenuItem.Checked = false;

                        this.rulesContextMenuItem.Checked = false;
                        this.instancesContextMenuItem.Checked = true;
                        this.scheduleContextStripMenuItem.Checked = false;

                        this.rulesReportToolStripMenuItem.Checked = false;
                        this.instancesReportToolStripMenuItem.Checked = true;
                        this.scheduleReportToolStripMenuItem.Checked = false;

                        this.filterToolStripMenuItem.Enabled = true;
                        this.findToolStripMenuItem.Enabled = true;

                        this.RefreshInstanceList();
                        break;
                    case MainWindowView.ScheduleView:
                        this.rulesToolStripMenuItem.Checked = false;
                        this.instancesToolStripMenuItem.Checked = false;
                        this.scheduleToolStripMenuItem.Checked = true;

                        this.rulesContextMenuItem.Checked = false;
                        this.instancesContextMenuItem.Checked = false;
                        this.scheduleContextStripMenuItem.Checked = true;

                        this.rulesReportToolStripMenuItem.Checked = false;
                        this.instancesReportToolStripMenuItem.Checked = false;
                        this.scheduleReportToolStripMenuItem.Checked = true;


                        this.filterToolStripMenuItem.Enabled = false;
                        this.findToolStripMenuItem.Enabled = false;
                        break;

                }
            }
        }
        private FilterWindow.FilterMode filterMode = FilterWindow.FilterModeDefault;
        /// <summary>
        /// Gets, sets filter mode.
        /// </summary>
        public FilterWindow.FilterMode FilterMode
        {
            set
            {
                this.filterMode = value;
            }
            get
            {
                return this.filterMode;
            }
        }

        /// <summary>
        /// List of crontab rules.
        /// </summary>
        private CrontabRuleList ruleList;
        /// <summary>
        /// List of crontab instances.
        /// A crontab instance is a single execution of a crontab rule.
        /// </summary>
        private CrontabInstanceList instanceList;
        /// <summary>
        /// stores crontab file name
        /// </summary>
        private string crontabFileName = String.Empty;
        /// <summary>
        /// defines if crontab file is open or not
        /// </summary>
        private bool isFileOpen = false;

        private String[] excludedByFilterNames;
        /// <summary>
        /// Gets, sets filter text.
        /// </summary>
        public String[] ExcludedByFilterNames
        {
            set
            {
                this.excludedByFilterNames = value;
            }
            get
            {
                return this.excludedByFilterNames;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.excludedByFilterNames = new String[] { };
            this.ruleGridView.AutoGenerateColumns = false;
            this.timeFilterTo.Value = this.timeFilterFrom.Value.AddHours(1);
            this.RefreshRuleList();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.crontabFileName = this.openFileDialog.FileName;
                this.findToolStripMenuItem.Enabled = true;
                this.filterToolStripMenuItem.Enabled = true;
                this.isFileOpen = true;
                this.instanceControlPanel.Enabled = true;
                this.RefreshRuleList();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.RefreshInstanceList();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enableTimeFilter_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked)
            {
                this.timeFilterFrom.Enabled = true;
                this.timeFilterTo.Enabled = true;
                this.FilterButton.Enabled = true;
            }
            else
            {
                this.timeFilterFrom.Enabled = false;
                this.timeFilterTo.Enabled = false;
                this.FilterButton.Enabled = false;
                this.RefreshInstanceList();
            }
        }

        /// <summary>
        /// Refreshes rule grid view.
        /// Allows to apply filters to a list of rules.
        /// Also refreshes instance grid view.
        /// </summary>
        public void RefreshRuleList()
        {
            if (this.isFileOpen)
            {
                CrontabRawRuleReader r = new CrontabRawRuleReader(this.crontabFileName);
                this.ruleList = r.GetRuleList();
                if (this.FilterMode == FilterWindow.FilterMode.Exclude)
                {
                    this.ruleList = this.ruleList.FilterByNames(this.ExcludedByFilterNames, true);
                }
                else
                {
                    this.ruleList = this.ruleList.FilterByNames(this.ExcludedByFilterNames, false);
                }
            }
            else
            {
                this.ruleList = new CrontabRuleList();
            }
            this.ruleGridView.DataSource = this.ruleList;
            this.RefreshInstanceList();
        }

        /// <summary>
        /// Refreshes instance grid view.
        /// Allows to apply filters to a list of instances.
        /// </summary>
        public void RefreshInstanceList()
        {
            this.instanceList = this.ruleList.GetInstanceList(this.dateFilter.Value);
            if (this.enableTimeFilter.Checked)
            {
                this.instanceList.FilterByTime(this.timeFilterFrom.Value, this.timeFilterTo.Value);
            }
            this.instanceGridView.DataSource = this.instanceList;
            this.RefreshScheduleBrowser();
        }

        /// <summary>
        /// Refreshes schedule report.
        /// </summary>
        public void RefreshScheduleBrowser()
        {
            CrontabHtmlScheduleCreator cr = new CrontabHtmlScheduleCreator(this.instanceList);
            this.scheduleBrowser.DocumentText = "<html><body>" + cr.GetScheduleReport() + "</body></html>";
        }

        private void prevDayBtn_Click(object sender, EventArgs e)
        {
            this.dateFilter.Value = this.dateFilter.Value.AddDays(-1);
            this.timeFilterFrom.Value = this.timeFilterFrom.Value.AddDays(-1);
            this.timeFilterTo.Value = this.timeFilterTo.Value.AddDays(-1);
            this.RefreshInstanceList();
        }

        private void nextDayBtn_Click(object sender, EventArgs e)
        {
            this.dateFilter.Value = this.dateFilter.Value.AddDays(1);
            this.timeFilterFrom.Value = this.timeFilterFrom.Value.AddDays(1);
            this.timeFilterTo.Value = this.timeFilterTo.Value.AddDays(1);
            this.RefreshInstanceList();
        }

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterWindow f = new FilterWindow();
            f.FilterLines = this.excludedByFilterNames;
            f.ShowDialog(this);
        }

        private void ruleGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this.ruleList[e.RowIndex].IsExcluded = !this.ruleList[e.RowIndex].IsExcluded;
                this.ruleGridView.DataSource = this.ruleList;
                this.ruleGridView.Refresh();
                this.RefreshInstanceList();
            }
        }

        private string BindProperty(object property, string propertyName)
        {
            string retValue = "";

            if (propertyName.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;

                leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                arrayProperties = property.GetType().GetProperties();

                foreach (PropertyInfo propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        retValue = BindProperty(
                          propertyInfo.GetValue(property, null),
                          propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;

                propertyType = property.GetType();
                propertyInfo = propertyType.GetProperty(propertyName);
                retValue = propertyInfo.GetValue(property, null).ToString();
            }

            return retValue;
        }

        private void ruleGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((this.ruleGridView.Rows[e.RowIndex].DataBoundItem != null)
                && (this.ruleGridView.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(
                            this.ruleGridView.Rows[e.RowIndex].DataBoundItem,
                            this.ruleGridView.Columns[e.ColumnIndex].DataPropertyName
                          );
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            this.RefreshInstanceList();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.tabControl.SelectedIndex)
            {
                case 0:
                    this.ActiveView = MainWindowView.RuleView;
                    break;

                case 1:
                    this.ActiveView = MainWindowView.InstanceView;
                    if (this.isFileOpen)
                    {
                        this.RefreshInstanceList();
                    }
                    break;
                case 2:
                    this.ActiveView = MainWindowView.ScheduleView;
                    break;

            }
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectTab(2);
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectTab(0);
        }

        private void instancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectTab(1);
        }

        private void copyAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.scheduleBrowser.Document.ExecCommand("SelectAll", false, null);
            this.scheduleBrowser.Document.ExecCommand("Copy", false, null);
            this.scheduleBrowser.Document.ExecCommand("Unselect", false, null);
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindWindow f = new FindWindow();
            f.ShowDialog(this);
        }

        private void ruleGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1
                && this.ruleGridView.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                this.ruleList[e.RowIndex].IsExcluded = !this.ruleList[e.RowIndex].IsExcluded;
                this.ruleGridView.DataSource = this.ruleList;
                this.ruleGridView.Refresh();
                this.RefreshInstanceList();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox f = new AboutBox();
            f.ShowDialog();
        }

        /// <summary>
        /// Allows to find task by name.
        /// Depending on the type of view it searches in the rules or in the instances.
        /// </summary>
        /// <param name="taskName">task name to be found</param>
        /// <param name="position">current position for a search, usefull for 'find next' option</param>
        /// <returns>position of a found task or FindWindow.DEFAULT_POSITION if the task was not found</returns>
        public int FindTaskByName(string taskName, int position)
        {
            int i = FindWindow.DEFAULT_POSITION;
            switch(this.ActiveView)
            {
                case MainWindowView.RuleView:
                    i = this.ruleList.GetPosByTaskName(taskName, position);
                    if (i > FindWindow.DEFAULT_POSITION)
                    {
                        this.ruleGridView.Rows[i].Selected = true;
                        this.ruleGridView.CurrentCell = this.ruleGridView.Rows[i].Cells[0];
                    }
                    else
                    {
                        this.ruleGridView.Rows[position].Selected = false;
                    }
                    return i;
                case MainWindowView.InstanceView:
                    i = this.instanceList.GetPosByTaskName(taskName, position);
                    if (i > FindWindow.DEFAULT_POSITION)
                    {
                        this.instanceGridView.Rows[i].Selected = true;
                        this.instanceGridView.CurrentCell = this.instanceGridView.Rows[i].Cells[0];
                    }
                    else
                    {
                        this.instanceGridView.Rows[position].Selected = false;
                    }
                    return i;
            }
            return FindWindow.DEFAULT_POSITION;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.findToolStripMenuItem.Enabled = false;
            this.filterToolStripMenuItem.Enabled = false;
            this.crontabFileName = string.Empty;
            this.isFileOpen = false;

            this.RefreshRuleList();
            this.instanceControlPanel.Enabled = false;
        }

        private void dateFilter_ValueChanged(object sender, EventArgs e)
        {
            this.timeFilterFrom.Value = this.dateFilter.Value;
            this.timeFilterTo.Value = this.dateFilter.Value;
            this.RefreshInstanceList();
        }
    }
}
