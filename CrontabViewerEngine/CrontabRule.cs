using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaciejRogozinski.CrontabViewer.Engine
{
    /// <summary>
    /// Describes single crontab rule.
    /// Used mainly for instance computation.
    /// </summary>
    public class CrontabRule :CrontabTask
    {
        private CrontabRawRule crontabRawRule;
        /// <summary>
        /// Representation of the rule in crontab style.
        /// </summary>
        public CrontabRawRule CrontabRawRule
        {
            get
            {
                return this.crontabRawRule;
            }
            set
            {
                this.crontabRawRule = value;
            }
        }

        private bool isExcluded = false;
        /// <summary>
        /// Is crontab rule excluded from instance view?
        /// True if the rule is mark as excluded and is not taken into consideration during
        /// crontab rule instance creation.
        /// </summary>
        public bool IsExcluded
        {
            get
            {
                return this.isExcluded;
            }
            set
            {
                this.isExcluded = value;
            }
        }
        
        private List<int> month;
        /// <summary>
        /// Contains months (1 - 12) at which the crontab task should be run or -1.
        /// -1 means * in crontab notation, specifies all possible values for a field.
        /// </summary>
        public List<int> Month
        {
            get
            {
                return this.month;
            }
        }
        private List<int> weekday;
        /// <summary>
        /// Contains days of week (0 - 6) (Sunday=0, Monday=1, etc.) at which the crontab task should be run or -1.
        /// -1 means * in crontab notation, specifies all possible values for a field.
        /// </summary>
        public List<int> Weekday
        {
            get
            {
                return this.weekday;
            }
        }
        private List<int> day;
        /// <summary>
        /// Contains days of month (1 - 31) at which the crontab task should be run or -1.
        /// -1 means * in crontab notation, specifies all possible values for a field.
        /// </summary>
        public List<int> Day
        {
            get
            {
                return this.day;
            }
        }
        private List<int> hour;
        /// <summary>
        /// Contains hours (0 - 23) at which the crontab task should be run or -1.
        /// -1 means * in crontab notation, specifies all possible values for a field.
        /// </summary>
        public List<int> Hour
        {
            get
            {
                return this.hour;
            }
        }
        private List<int> minute;
        /// <summary>
        /// Contains minutes (0 - 59) at which the crontab task should be run or -1.
        /// -1 means * in crontab notation, specifies all possible values for a field.
        /// </summary>
        public List<int> Minute
        {
            get
            {
                return this.minute;
            }
        }

        /// <summary>
        /// Creates default, empty crontab rule object.
        /// </summary>
        public CrontabRule()
        {
            this.weekday = new List<int>();
            this.minute = new List<int>();

            this.hour = new List<int>();
            this.day = new List<int>();
            this.weekday = new List<int>();
            this.month = new List<int>();
        }

        /// <summary>
        /// Creates crontab rule object based on contab raw rule.
        /// </summary>
        public CrontabRule(CrontabRawRule c)
            : this()
        {
            this.CrontabRawRule = c;
        }

        /// <summary>
        /// Creates list of task instances based on the crontab rule.
        /// </summary>
        /// <param name="selectedDay">Date for which instances are created.</param>
        /// <returns>Task instance list containing instances created for a specified date.</returns>
        public CrontabInstanceList GetInstanceList(DateTime selectedDay)
        {
            CrontabRuleParser parser = new CrontabRuleParser(this, selectedDay);
            return parser.GetRuleInstances();
        }
}
}
