using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAgentOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agent unit = new Agent("matan",3);
            Report report = new Report
            {
                Summary = "Enemy activity detected.",
                UrgencyLevel = 4,
                SubmittedBy = unit
            };
            MissionControl control = new MissionControl();
            control.AnalyzeReport(report);





        }
    }
}
