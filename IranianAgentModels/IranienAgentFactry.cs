using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranianAgentModels
{
    public class IranienAgentFactry
    {
        private string[] Sensorym = { "basic", "phone", "movement", "thermal" };
        private string[] AgentsNams = { "Achmed", "Puzi", "Mostafa", "chaminy" };
        private string[] AgentRancs = { "junior", "advanced", "commander" };

        public IranianAgentModel CreatIraninAgent()
        {
            Random rnd = new Random();
            string ranc = AgentRancs[rnd.Next(0, AgentRancs.Length)];
            List<string> sensors = new List<string>();
            int amount=0;
            switch (ranc)
            {
                case "junior":
                    {
                        amount = 2;
                        break;
                    }
                case "advanced":
                    { 
                        amount = 3;
                        break;
                    }
                case "commander":
                    {
                        amount = 4;
                        break;
                    }
            }
            for (int i=0; i<amount; i++)
            {
                sensors.Add(Sensorym[rnd.Next(0, Sensorym.Length)]);
            }
            IranianAgentModel NewAgent = new IranianAgentModel(AgentsNams[rnd.Next(0, AgentsNams.Length)], ranc, sensors);
            return NewAgent;
        }
        



    }
}
