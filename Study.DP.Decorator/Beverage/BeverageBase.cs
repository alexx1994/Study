﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Decorator.Beverage
{
    public abstract class BeverageBase
    {
        protected string Description = "";

        public string GetDescription()
        {
            return Description;
        }

        public abstract double GetCost();
    }
}
