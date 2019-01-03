using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Strategy.Interfaces.Dogs.Voice
{
    public class NormalVoice : IVoiceble
    {
        public void Voice()
        {
            Console.WriteLine("Gav! Gav!");
        }
    }
}
