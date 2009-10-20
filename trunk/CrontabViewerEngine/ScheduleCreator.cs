using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaciejRogozinski.CrontabViewer.Engine
{
    /// <summary>
    /// Template for crontab schedule report creation.
    /// </summary>
    /// <typeparam name="T">collection containing crontab instances</typeparam>
    /// <typeparam name="R">schedule report generated based on crontab instances</typeparam>
    public abstract class CrontabScheduleReportCreator<T, R> where T : CrontabInstanceList
    {
        protected T list;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        public CrontabScheduleReportCreator(T list)
        {
            this.list = list;
        }

        /// <summary>
        /// Creates schedule report generated based on crontab instances.
        /// </summary>
        /// <returns>Schedule report generated based on crontab instances.</returns>
        public abstract R GetScheduleReport();
    }
}
