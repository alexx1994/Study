using Study.DP.Decorator.Beverage;
using Study.DP.Decorator.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageBase blackTea = new BlackTea();
            BeverageBase greenTea = new GreenTea();
            BeverageBase coffee = new Coffee();

            Display(blackTea);
            Display(greenTea);
            Display(coffee);
            Console.WriteLine("----------------------");

            BeverageBase americano = new Milk(new Coffee());
            Display(americano);
            
            BeverageBase americanoWithSugar = new Sugar(new Milk(new Coffee()));
            Display(americanoWithSugar);

            Console.ReadLine();
        }

        static void Display(BeverageBase beverage)
        {
            Console.WriteLine("Description: {0} Price: {1}", beverage.GetDescription(), beverage.GetCost());
        }
    }
}
