using Study.DP.Decorator.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Decorator.Decorators
{
    public class Sugar : BeverageDecoratorBase
    {
        private BeverageBase _beverage;

        public Sugar(BeverageBase beverage)
        {
            _beverage = beverage;
            Description += beverage.GetDescription() + " +Milk";
        }
        public override double GetCost()
        {
            return _beverage.GetCost() + 3;
        }
    }
}
