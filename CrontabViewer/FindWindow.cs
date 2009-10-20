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
    public partial class FindWindow : Form
    {
        /// <summary>
        /// default position for a search
        /// </summary>
        public const int DEFAULT_POSITION = -1;
        /// <summary>
        /// stores current posistion for a search, usefull for 'find next' option
        /// </summary>
        private int position = DEFAULT_POSITION;

        public FindWindow()
        {
            InitializeComponent();
            
        }

        private void findNextButton_Click(object sender, EventArgs e)
        {
            if (this.searchTextBox.Text != string.Empty)
            {

                this.position = ((MainWindow)this.Owner).FindTaskByName(this.searchTextBox.Text, this.position);
            }
            this.searchTextBox.Focus();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            this.position = DEFAULT_POSITION;
        }

    }
}
