using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaciejRogozinski.CrontabViewer.Engine
{
    /// <summary>
    /// List containing raw, crontab rules.
    /// </summary>
    class CrontabRawRuleList : CrontabTaskList<CrontabRawRule>
    {

        /// <summary>
        /// Creates rule list based on crontab raw rules.
        /// </summary>
        /// <returns>Crontab rule list created based on crontab raw rules.</returns>
        public CrontabRuleList GetRuleList()
        {
            CrontabRuleList crl = new CrontabRuleList();
            foreach (CrontabRawRule cr in this)
            {
                //czy tutuj mogą wpadać nulle?
                crl.Add(cr.GetRule());
            }
            return crl;
        }     
    }
}
