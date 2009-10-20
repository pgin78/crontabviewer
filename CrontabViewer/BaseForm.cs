using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaciejRogozinski.CrontabViewer
{
    public class BaseForm:Form
    {
        public BaseForm()
        {
            this.Text = Properties.Settings.Default.AppName;
        }

        public string WindowTitle
        {
            get
            {
                return this.Text;
            }
            set
            {
                this.Text = Properties.Settings.Default.AppName + " " + value;
            }
        }
    }
}
