using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Adapter.WildCats
{
    public class Tiger : IWildCat
    {
        public string Breed { get { return "Simple tiger"; } }

        public void Growl()
        {
            Console.WriteLine("Grrrrrrr");
        }

        public void Scratch()
        {
            Console.WriteLine("I 'm very angry, and scratch and stay on die");
        }
    }
}
