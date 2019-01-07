using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Adapter.HomeCats
{
    public class YardCat : IHomeCat
    {
        public void Meow()
        {
            Console.WriteLine("miau miau");
        }

        public void Scratch()
        {
            Console.WriteLine("I 'm scrathc, but not angry!");
        }

        public string Name { get; set; }

    }
}
