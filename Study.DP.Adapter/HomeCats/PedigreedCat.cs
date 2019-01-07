using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Adapter.HomeCats
{
    public class PedigreedCat : IHomeCat
    {
        public string Name { get; set; }

        public void Meow()
        {
            Console.WriteLine("Urrr urrr");
        }

        public void Scratch()
        {
            Console.WriteLine("I 'm not scratch!");
        }

    }
}
