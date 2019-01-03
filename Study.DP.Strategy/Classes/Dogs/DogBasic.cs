using Study.DP.Strategy.Interfaces.Dogs.Voice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Strategy.Classes.Dogs
{
    public abstract class DogBasic
    {
        protected IVoiceble voiceBehaviour;
        public DogBasic()
        {
            voiceBehaviour = new NormalVoice();
        }

        public void SetVoiceBehaviour(IVoiceble newVoiceBehaviour)
        {
            voiceBehaviour = newVoiceBehaviour;
        }

        public abstract void Display();

        public void Run()
        {
            Console.WriteLine("I'm run!");
        }

        public void Voice()
        {
            voiceBehaviour.Voice();
        }

    }
}
