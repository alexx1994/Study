using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Decorator.Beverage
{
    public class GreenTea : BeverageBase
    {
        public GreenTea()
        {
            Description = "This is a green tea";
        }

        public override double GetCost()
        {
            return 38;
        }
    }
}
