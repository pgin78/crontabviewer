using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaciejRogozinski.CrontabViewer.Engine
{
    /// <summary>
    /// List containing crontab rule instances.
    /// </summary>
    public class CrontabInstanceList : CrontabTaskList<CrontabInstance>
    {
        /// <summary>
        /// Filters instance list by date range.
        /// Only instances in specified period are returned.
        /// This method changes list content.
        /// TODO: probably would be better if this could return a new list, changing list that is already binded to a control can be dangerous
        /// </summary>
        /// <param name="from">specifies left border of date range</param>
        /// <param name="to">specifies right border of date range</param>
        public void FilterByTime(DateTime from, DateTime to)
        {
            DateTime d1 = new DateTime(from.Year, from.Month, from.Day, from.Hour, from.Minute, 0);
            DateTime d2 = new DateTime(to.Year, to.Month, to.Day, to.Hour, to.Minute, 0);
            List<CrontabInstance> l = this.FindAll(
                delegate(CrontabInstance c)
                {
                    if ((c.Date >= d1) &&
                        (c.Date <= d2))
                    {
                        return true;
                    }
                    return false;
                });

            this.Clear();
            this.AddRange(l);
        }

        /// <summary>
        /// Sorts instance list by time of task execution.
        /// Sorting is done in descending order.
        /// </summary>
        public void SortByTimeDesc()
        {
            this.Sort(delegate(CrontabInstance c1, CrontabInstance c2)
              {
                  return c1.Date.CompareTo(c2.Date);
              });
        }
    }

}
