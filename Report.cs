using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAgentOperation
{
    internal class Report
    {
        public string Summary;
        public int UrgencyLevel = 4;
        public Agent SubmittedBy = new Agent("aaa",2);

        
    }
}
