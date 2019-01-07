using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.PD.Facade.WashingMashine
{
    public class Dryer
    {
        public void Dry(int second, int intensity)
        {
            Console.WriteLine("Drying {0} seconds with intensity {1}", second, intensity);
        }
    }
}
