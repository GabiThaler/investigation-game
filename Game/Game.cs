using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using IranianAgentModels;
using SensorModels;


namespace investigation_game.Game
{
    public class Game
    {
        public void StartGame()
        {
            
            string sensor;
            List<string> CorntSensorim = new List<string>();
            IranianAgentModel invastageter =new IranianAgentModel("Achmed", "junior agent",new List<string> { "basic","phone"});
            int Max = invastageter.GetSensedivSensor().Count;
            int cornt = 0;
            Console.WriteLine($"welcom to the investation game you are plaing agentst {invastageter.Name}");
            Console.WriteLine($"the agent is sensitive to {invastageter.GetSensedivSensor()[0]} and {invastageter.GetSensedivSensor()[1]}");
            foreach (string sensn in invastageter.GetSensedivSensor())
            {
                CorntSensorim.Add(sensn);
            }
            while (cornt<Max)
            {
                Console.WriteLine("please  enter whot sensor you woould whant to atach to the agent");
                sensor = Console.ReadLine();
                SensorModel s = new SensorModel(sensor);
                if (s.Activate(invastageter) && CorntSensorim.Contains(sensor) )
                {
                    cornt += 1;
                    Console.WriteLine($"you gest {cornt} / {Max}");
                    invastageter.Sensorim.Add(sensor);
                    CorntSensorim.Remove(sensor);
                    //invastageter.Conter += 1;
                }
                else
                {
                    Console.WriteLine($"agent is not senidiv to this type of sensor you gest {cornt}/ {Max}");
                }
                
            }
           
           


        }
        
        
    }
}
