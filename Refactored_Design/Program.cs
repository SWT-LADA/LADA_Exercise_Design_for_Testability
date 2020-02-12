using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactored_Design
{
    public class Program
    {
        
        
            public static void Main(string[] args)
            {
                IHeater heater = new Heater();
                ITempSensor tempSensor = new TempSensor();


                var ecs = new ECS(28, tempSensor, heater);

                ecs.Regulate();

                ecs.SetThreshold(20);

                ecs.Regulate();
            }
        
    }
    
}
