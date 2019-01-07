using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Adapter.HomeCats
{
    public interface IHomeCat
    {
        string Name { get; set; }
        void Meow();
        void Scratch();
    }
}
