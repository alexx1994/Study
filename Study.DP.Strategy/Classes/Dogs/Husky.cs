using Study.DP.Strategy.Interfaces.Dogs.Voice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Strategy.Classes.Dogs
{
    public class Husky : DogBasic
    {
        public Husky()
        {
            voiceBehaviour = new HuskyVoice();
        }

        public override void Display()
        {
            Console.WriteLine("Hi, i'm Husky dog!");
        }
    }
}
