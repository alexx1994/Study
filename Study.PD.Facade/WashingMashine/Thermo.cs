using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.PD.Facade.WashingMashine
{
    public class Thermo
    {
        public void WarmUp(int dagrees)
        {
            Console.WriteLine("Warm for {0} dagrees", dagrees);
        }
    }
}
