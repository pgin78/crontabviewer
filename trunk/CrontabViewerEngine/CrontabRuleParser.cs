using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaciejRogozinski.CrontabViewer.Engine
{
    /// <summary>
    /// Tool for crontab rule parsing. 
    /// Takes crontab rules and produces crontab rule instances.
    /// </summary>
    class CrontabRuleParser
    {
        /// <summary>
        /// list of crontab rules
        /// </summary>
        private CrontabRuleList rules;
        /// <summary>
        /// list of crontab rule instances
        /// </summary>
        private CrontabInstanceList instances;
        /// <summary>
        /// selected date, used for producing instances from rules
        /// </summary>
        private DateTime selectedDay;

        /// <summary>
        /// Creates default, parser object.
        /// </summary>
        public CrontabRuleParser()
        {
            this.rules = new CrontabRuleList();
            this.instances = new CrontabInstanceList();
        }

        /// <summary>
        /// Create crontab parser based on crontab rule and selected date.
        /// </summary>
        /// <param name="cr">crontab rule from which instances should be created</param>
        /// <param name="selectedDay">selected date for which instances should be created</param>
        public CrontabRuleParser(CrontabRule cr, DateTime selectedDay)
            : this()
        {
            this.rules.Add(cr);
            this.selectedDay = selectedDay;
        }

        /// <summary>
        /// Create crontab parser based on crontab rule list and selected date.
        /// </summary>
        /// <param name="cr">crontab rule list from which instances should be created</param>
        /// <param name="selectedDay">selected date for which instances should be created</param>
        public CrontabRuleParser(CrontabRuleList cr, DateTime selectedDay)
            : this()
        {
            this.rules.AddRange(cr);
            this.selectedDay = selectedDay;
        }

        /// <summary>
        /// Produces instances based on supplied crontab rules.
        /// </summary>
        /// <returns>List of crontab rule instances generated for selected date.</returns>
        public CrontabInstanceList GetRuleInstances()
        {
            foreach (CrontabRule r in this.rules)
            {
                if (r.IsExcluded)
                {
                    continue;
                }
                this.parseMonths(r.TaskName, r.Month, r.Weekday, r.Day, r.Hour, r.Minute);
            }
            return this.instances;
        }

        private void parseMinutes(string taskName, int month, int day, int hour, IEnumerable<int> minutes)
        {
            if ((minutes.Count() == 1) && (minutes.ElementAt(0) == -1))
            {
                for (int i = 0; i <= 23; i++)
                {
                    DateTime dt = new DateTime(this.selectedDay.Year, month, day, hour, i, 0);
                    CrontabInstance c = new CrontabInstance();
                    c.Date = dt;
                    c.TaskName = taskName;
                    this.instances.Add(c);
                }
            }
            else
            {
                foreach (int minute in minutes)
                {
                    DateTime dt = new DateTime(this.selectedDay.Year, month, day, hour, minute, 0);
                    CrontabInstance c = new CrontabInstance();
                    c.Date = dt;
                    c.TaskName = taskName;
                    this.instances.Add(c);
                }
            }
        }

        private void parseHours(string taskName, int month, int day, IEnumerable<int> hours, IEnumerable<int> minutes)
        {
            if ((hours.Count() == 1) && (hours.ElementAt(0) == -1))
            {
                for (int i = 0; i <= 23; i++)
                {
                    parseMinutes(taskName, month, day, i, minutes);
                }
            }
            else
            {
                foreach (int hour in hours)
                {
                    parseMinutes(taskName, month, day, hour, minutes);
                }
            }
        }

        private void parseDays(string taskName, int month, int weekday, IEnumerable<int> days, IEnumerable<int> hours, IEnumerable<int> minutes)
        {
            if (((days.Count() == 1) && (days.ElementAt(0) == -1))||
                days.Contains(this.selectedDay.Day))
            {
                parseHours(taskName, month, this.selectedDay.Day, hours, minutes);
            }
        }

        private void parseWeekdays(string taskName, int month, IEnumerable<int> weekdays, IEnumerable<int> days, IEnumerable<int> hours, IEnumerable<int> minutes)
        {
            if (((weekdays.Count() == 1) && (weekdays.ElementAt(0) == -1))||
                weekdays.Contains((int)this.selectedDay.DayOfWeek)
                )
            {
                parseDays(taskName, this.selectedDay.Month, (int)this.selectedDay.DayOfWeek, days, hours, minutes);
            }
        }

        private void parseMonths(string taskName, IEnumerable<int> months, IEnumerable<int> weekdays, IEnumerable<int> days, IEnumerable<int> hours, IEnumerable<int> minutes)
        {
            if (((months.Count() == 1) && (months.ElementAt(0) == -1))||
                months.Contains(this.selectedDay.Month))
            {
                parseWeekdays(taskName, this.selectedDay.Month, weekdays, days, hours, minutes);
            }
        }
    }
}
