using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaciejRogozinski.CrontabViewer.Engine
{
    public class CrontabHtmlScheduleCreator:CrontabScheduleReportCreator<CrontabInstanceList,string>
    {
        /// <summary>
        /// Creates crontab report creator base on crontab instance list.
        /// </summary>
        /// <param name="list">list of crontab instances</param>
        public CrontabHtmlScheduleCreator(CrontabInstanceList list)
            : base(list)
        {
        }

        /// <summary>
        /// Creates schedule report generated based on crontab instances.
        /// </summary>
        /// <returns>Schedule report generated based on crontab instances.</returns>
        public override string GetScheduleReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<style>table{width:100%;}.hours{width:50px;text-align:center;}.minutes{width:50px}</style>");
            if (this.list.Count == 0)
            {
                return sb.ToString();
            }
            int hour = this.list.Count > 0 ? this.list[0].Date.Hour : 0;
            sb.Append(this.list[0].Date.ToString("yyyy-MM-dd"));
            sb.Append(" (");
            sb.Append(this.list[0].Date.DayOfWeek);
            sb.Append(")</br></br>");

            //hours
            sb.Append("<table border=1><tr><td class=\"hours\">");
            sb.Append(this.list[0].Date.ToString("HH"));
            sb.Append(":00");
            sb.Append("</br>-</br>");
            sb.Append(this.list[0].Date.ToString("HH"));
            sb.Append(":59");
            sb.Append("</td><td>");

            foreach (CrontabInstance i in this.list)
            {

                if (i.Date.Hour != hour)
                {
                    sb.Append("</td></tr></table>");
                    sb.Append("<table border=1><tr><td class=\"hours\">");
                    sb.Append(i.Date.ToString("HH"));
                    sb.Append(":00");
                    sb.Append("</br>-</br>");
                    sb.Append(i.Date.ToString("HH"));
                    sb.Append(":59");
                    sb.Append("</td><td>");
                }

                sb.Append("<table border=1><tr><td class=\"minutes\">");
                sb.Append(i.Date.Minute);
                sb.Append("</td><td>");
                sb.Append(i.TaskName);
                sb.Append("</td></tr></table>");
                hour = i.Date.Hour;
            }
            sb.Append("</td></tr></table>");
            return sb.ToString();
        }
    }
}
