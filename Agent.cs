using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAgentOperation
{
    internal class Agent
    {
        public string CodeName;
        private int ClearanceLevel;

        public Agent(string codeName, int clearanceLevel)
        {
            this.CodeName = codeName;
            this.ClearanceLevel = clearanceLevel;
        }

        public void Report()
        {
            Console.WriteLine($"Agent {CodeName} reporting. Clearance Level: {ClearanceLevel}");
        }

        public void GetClearanceLevel()
        {
            Console.WriteLine($"your ClearanceLevel  is {ClearanceLevel}");
        }


        public void SetClearanceLevel(int level)
        {
            if (level < 1 || level > 5)
            {
                Console.WriteLine("Enter numbers only between 1 and 5.");
            }
            else
            {
                ClearanceLevel = level;
            }

        }
    }
}
