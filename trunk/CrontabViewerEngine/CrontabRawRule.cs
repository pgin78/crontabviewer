using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MaciejRogozinski.CrontabViewer.Engine
{
    /// <summary>
    /// Describes single crontab raw rule.
    /// Used mailny for crontab presentation purposes.
    /// </summary>
    public class CrontabRawRule : CrontabTask
    {
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
        
        private String month;
        /// <summary>
        /// Contains month numbers at which the crontab task should be run.
        /// Uses standard crontab notation.
        /// </summary>
        public String Month
        {
            set
            {
                this.month = value;
            }
            get
            {
                return this.month;
            }
        }
        private String weekday;
        /// <summary>
        /// Contains day of week numbers at which the crontab task should be run.
        /// Uses standard crontab notation.
        /// </summary>
        public String Weekday
        {
            set
            {
                this.weekday = value;
            }
            get
            {
                return this.weekday;
            }
        }
        private String day;
        /// <summary>
        /// Contains day of month numbers at which the crontab task should be run.
        /// Uses standard crontab notation.
        /// </summary>
        public String Day
        {
            set
            {
                this.day = value;
            }
            get
            {
                return this.day;
            }
        }
        private String hour;
        /// <summary>
        /// Contains hour numbers at which the crontab task should be run.
        /// Uses standard crontab notation.
        /// </summary>
        public String Hour
        {
            set
            {
                this.hour = value;
            }
            get
            {
                return this.hour;
            }
        }
        private String minute;
        /// <summary>
        /// Contains minute numbers at which the crontab task should be run.
        /// Uses standard crontab notation.
        /// </summary>
        public String Minute
        {
            set
            {
                this.minute = value;
            }
            get
            {
                return this.minute;
            }
        }

        /// <summary>
        /// Tanslates raw crontab rule into 'computer' readable rule described by CrontabRule class.
        /// </summary>
        /// <returns>Crontab rule in 'computer' readable format.</returns>
        public CrontabRule GetRule()
        {
            CrontabRule r = new CrontabRule(this);

            r.Minute.AddRange(this.parseValue(this.Minute));
            r.Hour.AddRange(this.parseValue(this.Hour));
            r.Day.AddRange(this.parseValue(this.Day));
            r.Month.AddRange(this.parseValue(this.Month));
            r.Weekday.AddRange(this.parseValue(this.Weekday));
            r.IsExcluded = this.isExcluded;
            r.TaskName = this.TaskName;
            return r;
        }


        /// <summary>
        /// Allows parsing crontab rule values.
        /// </summary>
        /// <param name="s">value to be parsed</param>
        /// <returns>Collection of crontab rule values.</returns>
        private IEnumerable<int> parseValue(String s)
        {

            //TODO:needs a correction, 2-6,9,10 is read as 2-6, 6,9,10 or something similar
            List<int> l = new List<int>();
            Regex reg = new Regex(@"([0-9]+)-([0-9]+)", RegexOptions.Multiline);
            if (reg.IsMatch(s))
            {
                MatchCollection mc = reg.Matches(s);
                foreach (Match m in mc)
                {
                    int i1 = int.Parse(m.Groups[1].ToString());
                    int i2 = int.Parse(m.Groups[2].ToString());
                    if (i1 >= i2)
                    {
                        for (int i = i1; i <= 23; i++)
                        {
                            l.Add(i);
                        }
                        for (int i = 0; i <= i2; i++)
                        {
                            l.Add(i);
                        }
                    }
                    else
                    {
                        for (int i = 0; i <= (i2 - i1); i++)
                        {
                            l.Add(i + i1);
                        }
                    }
                }
            }
            s = reg.Replace(s, string.Empty);

            reg = new Regex(@"(([0-9]+\s*\,+\s*)+(\s*[0-9]+))");
            if (reg.IsMatch(s))
            {
                Match m = reg.Match(s);
                string[] numbers = m.Groups[0].ToString().Split(',');
                int res = 0;
                foreach (string n in numbers)
                {
                    if (int.TryParse(n, out res))
                    {
                        l.Add(res);
                    }

                }
            }
            s = reg.Replace(s, string.Empty);

            reg = new Regex(@"([0-9]+)", RegexOptions.Singleline);
            if (reg.IsMatch(s))
            {
                Match m = reg.Match(s);
                int i1 = int.Parse(m.Groups[1].ToString());
                l.Add(i1);
            }
            //TODO: can hour-part of crontab entry contain * and at the same time something else?
            reg = new Regex(@"\*", RegexOptions.Singleline);
            if (reg.IsMatch(s))
            {
                l.Add(-1);
            }
            return l;
        }
    }
}
