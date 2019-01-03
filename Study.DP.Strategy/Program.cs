using Study.DP.Strategy.Classes.Dogs;
using Study.DP.Strategy.Interfaces.Dogs.Voice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DogBasic> dogs = new List<DogBasic>();

            dogs.Add(new Husky());
            dogs.Add(new Shepherd());
            dogs.Add(new ShibaInu());

            foreach (var dog in dogs)
            {
                dog.Display();
                dog.Run();
                dog.Voice();

                Console.WriteLine();
            }

            DogBasic upgradableDog = new UpgradableDog();
            upgradableDog.Display();
            upgradableDog.Run();
            upgradableDog.Voice();

            upgradableDog.SetVoiceBehaviour(new HuskyVoice());
            upgradableDog.Voice();

            Console.ReadKey();
        }
    }
}
