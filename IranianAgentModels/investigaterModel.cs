using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IranianAgentModels
{
    public class IranianAgentModel
    {
        public string Name { get; set; }
        public string Ranc { get; set; }
        private List<string> SensedivSensor = new List<string>();
        public List<string> Sensorim = new List<string>();
        public int Conter = 0;
        public IranianAgentModel(string name, string ranc, List<string> sensedivSensor)
        {
            Name = name;
            Ranc = ranc;
            SensedivSensor = sensedivSensor;
        }
        public List<string> GetSensedivSensor()
        {
            return SensedivSensor;
        }
    }
}
        

