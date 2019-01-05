using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Decorator.Beverage
{
    public class Coffee : BeverageBase
    {
        public Coffee()
        {
            Description = "This is a coffee";
        }

        public override double GetCost()
        {
            return 45;
        }
    }
}
