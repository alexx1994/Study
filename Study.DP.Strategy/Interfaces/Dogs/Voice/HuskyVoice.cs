﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Strategy.Interfaces.Dogs.Voice
{
    public class HuskyVoice : IVoiceble
    {
        public void Voice()
        {
            Console.WriteLine("AWOOOOO!");
        }
    }
}
