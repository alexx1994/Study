using Study.DP.Adapter.Adapters;
using Study.DP.Adapter.HomeCats;
using Study.DP.Adapter.WildCats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IHomeCat vaska = new YardCat();
            vaska.Name = "Vaska";
            CatInfoPrint.PrintCatInfo(vaska);

            IHomeCat wagner = new PedigreedCat();
            wagner.Name = "Wagner";
            CatInfoPrint.PrintCatInfo(wagner);
            
            IWildCat tiger = new Tiger();
            HomeCatAdapter adapter = new HomeCatAdapter(tiger);
            CatInfoPrint.PrintCatInfo(adapter);

            Console.ReadLine();
        }
    }
}
