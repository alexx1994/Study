using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.PD.Facade.WashingMashine
{
    public class Engine
    {
        public void Rotate()
        {
            Console.WriteLine("Start rotate");
        }

        public void Stop()
        {
            Console.WriteLine("Stop rotate");
        }
    }
}
