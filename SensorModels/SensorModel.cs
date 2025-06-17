
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IranianAgentModels;

namespace SensorModels
{
    public class SensorModel
    {
        private string Type { get; }
        public SensorModel(string type)
        {
            Type = type;
        }

        public bool Activate(IranianAgentModel investageter)
        {
            bool Answer = false;
            List<string> CorntSensidivSensor= investageter.GetSensedivSensor();
            if (CorntSensidivSensor.Contains(Type))
            {
                Answer = true;
            }
            
            return Answer;
        }


    }
}
