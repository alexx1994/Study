using Study.PD.Facade.WashingMashine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.PD.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var water = new WaterManagingSubSystem();
            var thermo = new Thermo();
            var engine = new Engine();
            var dryer = new Dryer();

            var washingMachine = new WashingMachine(dryer, engine, thermo, water);

            // Cotton
            Console.WriteLine();
            Console.WriteLine("Cotton");
            washingMachine.WashCotton();

            // Wool
            Console.WriteLine();
            Console.WriteLine("Wool");
            washingMachine.WashWool();

            Console.ReadLine();
        }
    }
}
