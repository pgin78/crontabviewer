using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace MaciejRogozinski.CrontabViewer.Engine
{
    /// <summary>
    /// Tool for reading crontab files.
    /// Reads crontab file and produces crontab rule list.
    /// </summary>
    public class CrontabRawRuleReader
    {
        /// <summary>
        /// crontab file name
        /// </summary>
        private String filename;

        /// <summary>
        /// Creates reader for a specified file.
        /// </summary>
        /// <param name="filename">crontab file name</param>
        public CrontabRawRuleReader(String filename)
        {
            this.filename = filename;
        }

        /// <summary>
        /// Validates supplied crontab value.
        /// </summary>
        /// <param name="s">string to be validated</param>
        /// <returns>Returns empty string if supplied string failed validation, otherwise the valid string.</returns>
        private String validateRawValue(String s)
        {
            Regex reg = new Regex(@"([0-9]+)(-)([0-9]+)", RegexOptions.Singleline);
            if (reg.IsMatch(s))
            {
                return s;
            }
            reg = new Regex(@"([0-9]+)", RegexOptions.Singleline);
            if (reg.IsMatch(s))
            {
                return s;
            }
            reg = new Regex(@"\*", RegexOptions.Singleline);
            if (reg.IsMatch(s))
            {
                return s;
            }
            return String.Empty;
        }

        /// <summary>
        /// Reads crontab file and produces list of rules.
        /// </summary>
        /// <returns>List of crontab rules read from a file.</returns>
        public CrontabRuleList GetRuleList()
        {
            //TODO - can't parse */2 value format
            if (this.filename.Equals(string.Empty))
            {
                return new CrontabRuleList();
            }
            CrontabRuleList tasks = new CrontabRuleList();
            TextReader r = new StreamReader(this.filename);
            String line = String.Empty;
            while ((line = r.ReadLine()) != null)
            {
                Regex reg = new Regex(@"^\s*" +
                    @"(?<minute>(([0-9]+)\-([0-9]+))|([0-9]+)|(\*)|(([0-9]+\s*\,\s*)+(\s*[0-9]+)))\s+" +
                    @"(?<hour>(([0-9]+)\-([0-9]+))|([0-9]+)|(\*)|(([0-9]+\s*\,\s*)+(\s*[0-9]+)))\s+" +
                    @"(?<day>(([0-9]+)\-([0-9]+))|([0-9]+)|(\*)|(([0-9]+\s*\,\s*)+(\s*[0-9]+)))\s+" +
                    @"(?<month>(([0-9]+)\-([0-9]+))|([0-9]+)|(\*)|(([0-9]+\s*\,\s*)+(\s*[0-9]+)))\s+" +
                    @"(?<weekday>(([0-9]+)\-([0-9]+))|([0-9]+)|(\*)|(([0-9]+\s*\,\s*)+(\s*[0-9]+)))\s+" +
                    @"(?<taskName>.*)", RegexOptions.Singleline);
                if (reg.IsMatch(line))
                {
                    Match m = reg.Match(line);
                    GroupCollection gc = m.Groups;
                    //Console.WriteLine(gc["minute"]);
                    if (gc["minute"].Success && gc["hour"].Success && gc["day"].Success && gc["month"].Success && gc["weekday"].Success
                        && gc["taskName"].Success)
                    {
                        CrontabRawRule t = new CrontabRawRule();
                        t.Minute = this.validateRawValue(gc["minute"].Value);
                        t.Hour = this.validateRawValue(gc["hour"].Value);
                        t.Day = this.validateRawValue(gc["day"].Value);
                        t.Month = this.validateRawValue(gc["month"].Value);
                        t.Weekday = this.validateRawValue(gc["weekday"].Value);
                        t.TaskName = gc["taskName"].Value;
                        CrontabRule cr = t.GetRule();
                        tasks.Add(cr);
                    }
                }

            }
            r.Close();
            return tasks;
        }
    }
}
