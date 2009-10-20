using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaciejRogozinski.CrontabViewer.Engine
{
    public class CrontabInstance:CrontabTask
    {
        private DateTime date;
        public DateTime Date 
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }
    }
}
