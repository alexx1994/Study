using Study.DP.Strategy.Interfaces.Dogs.Voice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Strategy.Classes.Dogs
{
    public class UpgradableDog : DogBasic
    {
        public UpgradableDog()
        {
            voiceBehaviour = new NormalVoice();
        }

        public override void Display()
        {
            Console.WriteLine("Hi i'm upgradable dog!");
        }
    }
}
