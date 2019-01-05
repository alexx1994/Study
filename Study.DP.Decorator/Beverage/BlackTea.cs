using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Decorator.Beverage
{
    public class BlackTea : BeverageBase
    {
        public BlackTea ()
        {
            Description = "This is a black tea";
        }

        public override double GetCost()
        {
            return 45;
        }
    }
}
