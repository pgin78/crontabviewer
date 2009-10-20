using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaciejRogozinski.CrontabViewer.Engine
{
    /// <summary>
    /// Base class for a crontab task.
    /// </summary>
    public abstract class CrontabTask
    {
        private String taskName;
        /// <summary>
        /// Crontab task name.
        /// </summary>
        public String TaskName
        {
            get
            {
                return this.taskName;
            }
            set
            {
                this.taskName = value;
            }
        }
    }
}
