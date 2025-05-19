using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAgentOperation
{
    internal class IntelTools
    {
        public static string EncryptMessage(string msg) => new string(msg.Reverse().ToArray());
        

        public static string LogTransmission(string agentName, string message) => $"{agentName} sent encrypted message: {message}";



    }
}
