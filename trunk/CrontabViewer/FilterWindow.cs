using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaciejRogozinski.CrontabViewer
{
    public partial class FilterWindow : Form
    {
        /// <summary>
        /// Define modes of filtering.
        /// </summary>
        public enum FilterMode
        { 
            /// <summary>
            /// defines excluding mode
            /// some rows will be excluded from a result
            /// </summary>
            Exclude, 
            /// <summary>
            /// define show only mode
            /// only some rows will be shown, others will be excluded
            /// </summary>
            ShowOnly 
        };
        /// <summary>
        /// Default mode for a filter.
        /// </summary>
        public const FilterMode FilterModeDefault = FilterMode.Exclude;
        /// <summary>
        /// Text that is used to filter out results.
        /// </summary>
        public String[] FilterLines
        {
            set
            {
                this.textBox1.Lines = value;
            }
        }

        public FilterWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets filter mode.
        /// </summary>
        /// <returns>Filtering mode.</returns>
        public FilterMode GetFilterMode()
        {
            switch (this.filterModeComboBox.SelectedIndex)
            {
                case 0:
                    return FilterMode.Exclude;
                case 1:
                    return FilterMode.ShowOnly;
            }
            return FilterModeDefault;
        }

        /// <summary>
        /// Sets filter mode.
        /// </summary>
        /// <param name="m">filter mode</param>
        private void SetFilterMode(FilterMode m)
        {
            switch (m)
            {
                case FilterMode.Exclude:
                    this.filterModeComboBox.SelectedIndex = 0;
                    break;
                case FilterMode.ShowOnly:
                    this.filterModeComboBox.SelectedIndex = 1;
                    break;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            ((MainWindow)this.Owner).ExcludedByFilterNames = this.textBox1.Lines;
            ((MainWindow)this.Owner).FilterMode = this.GetFilterMode();
            ((MainWindow)this.Owner).RefreshRuleList();
            this.Close();
        }

        private void FilterWindow_Activated(object sender, EventArgs e)
        {
            this.SetFilterMode(((MainWindow)this.Owner).FilterMode);
        }


    }
}
