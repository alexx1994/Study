using Study.DP.Adapter.HomeCats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Adapter
{
    public class CatInfoPrint
    {
        public static void PrintCatInfo(IHomeCat cat)
        {
            Console.WriteLine("Cats information: ");
            Console.WriteLine("Cat name: {0}", cat.Name);
            Console.WriteLine("Meow type: ");
            cat.Meow();
            Console.WriteLine("Scratch type: ");
            cat.Scratch();

            Console.WriteLine();
        }
    }
}
