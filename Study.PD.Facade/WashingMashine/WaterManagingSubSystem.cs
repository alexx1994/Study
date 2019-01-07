using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.PD.Facade.WashingMashine
{
    public class WaterManagingSubSystem
    {
        public void FillWater(int liters)
        {
            Console.WriteLine("Fiil with {0} liters of waters", liters);
        }

        public void EmptyWater()
        {
            Console.WriteLine("Empty water tank");
        }
    }
}
