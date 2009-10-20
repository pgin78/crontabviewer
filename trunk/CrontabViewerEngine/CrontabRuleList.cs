using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaciejRogozinski.CrontabViewer.Engine
{
    /// <summary>
    /// List containing crontab rules.
    /// </summary>
    public class CrontabRuleList : CrontabTaskList<CrontabRule>
    {
        /// <summary>
        /// Creates instance list for a selected date, based on crontab rules.
        /// </summary>
        /// <param name="selectedDay">selected date for which instances should be created</param>
        /// <returns>Crontab instance list created for a selected date, based on crontab rules.</returns>
        public CrontabInstanceList GetInstanceList(DateTime selectedDay)
        {
            CrontabInstanceList cil = new CrontabInstanceList();
            foreach (CrontabRule cr in this)
            {
                if (!cr.IsExcluded)
                {
                    //czy tutuj mogą wpadać nulle?
                    cil.AddRange(cr.GetInstanceList(selectedDay));
                }
            }
            cil.SortByTimeDesc();
            return cil;
        }

        /// <summary>
        /// Filters rule list by task names.
        /// Excludes specified instances from the list.
        /// Method creates a new, filtered rule list, rather than changing the existing one.
        /// </summary>
        /// <param name="names">Task name to be excluded from instance list.</param>
        /// <returns>New, filtered rule list.</returns>
        public CrontabRuleList FilterByNames(String[] names, bool exclude)
        {
            if (names.Length == 0)
            {
                return this;
            }
            List<CrontabRule> l = this.FindAll(
                (CrontabRule r) =>
                {
                    foreach (String n in names)
                    {
                        if (r.TaskName.Contains(n))
                        {
                            return !exclude;
                        }
                    }
                    return exclude;
                });
            CrontabRuleList list = new CrontabRuleList();
            list.AddRange(l);
            return list;
        }
    }
}
