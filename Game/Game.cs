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
        private IranienAgentFactry IAG = new IranienAgentFactry();
        public void StartGame()
        {
            
            string sensor;
            List<string> CorntSensorim = new List<string>();
            IranianAgentModel invastageter = IAG.CreatIraninAgent();
            Console.WriteLine($"welcom to the investation game you are plaing agentst {invastageter.Name}");
            foreach (string sensn in invastageter.GetSensedivSensor())
            {
                CorntSensorim.Add(sensn);
            }
            while (invastageter.Conter < invastageter.GetSensedivSensor().Count)
            {
                
                sensor = ShowCoice();
                SensorModel s = new SensorModel(sensor);
                if (s.Activate(invastageter) && CorntSensorim.Contains(sensor) )
                {
                    invastageter.Conter += 1;
                    Console.WriteLine($"you gest {invastageter.Conter} / {invastageter.GetSensedivSensor().Count}");
                    invastageter.Sensorim.Add(sensor);
                    CorntSensorim.Remove(sensor);
                    
                }
                else
                {
                    Console.WriteLine($"agent is not senidiv to this type of sensor you gest {invastageter.Conter} / {invastageter.GetSensedivSensor().Count}");
                }
                
            }


        }
        public string ShowCoice()
        {
            string sensor = "";
            bool flag = true;
            Console.WriteLine("please  enter whot sensor you woould whant to atach to the agent:");
            Console.WriteLine("to atach basic click 1:");
            Console.WriteLine("to atach phone click 2:");
            Console.WriteLine("to atach movement click 3:");
            Console.WriteLine("to atach thermal click 4:");
            
            while(flag)
            {
                sensor = Console.ReadLine()!;
                switch (sensor)
                {
                    case "1":
                        {
                            sensor = "basic";
                            flag = false;
                            break;
                        }
                    case "2":
                        {
                            sensor = "phone";
                            flag = false;
                            break;
                        }
                    case "3":
                        {
                            sensor = "movement";
                            flag = false;
                            break;
                        }
                    case "4":
                        {
                            sensor = "thermal";
                            flag = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("The sensor is not volid.");
                            Console.WriteLine("please enter a volid sensor.");
                            break;
                        }

                }
            }
            return sensor;
        }
        
        
    }
}
