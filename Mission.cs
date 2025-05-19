using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAgentOperation
{
    internal class Mission
    {
        public string MissionName;
        public string TargetLocation;
        public Agent NewAgent;


        public Mission(string MissionName, string TargetLocation)
        {
            this.MissionName = MissionName;
            this.TargetLocation = TargetLocation;
        }

        public void AssignedAgent(string codeName, int clearanceLevel)
        {
            NewAgent = new Agent(codeName, clearanceLevel);
        }

        public void Brief()
        {
            Console.WriteLine($"Mission: {MissionName}, Target: {TargetLocation}, agent:  {NewAgent.CodeName}");
        }
    }
}
