using Study.DP.Adapter.HomeCats;
using Study.DP.Adapter.WildCats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Adapter.Adapters
{
    public class HomeCatAdapter : IHomeCat
    {
        private IWildCat _wildCat;

        public HomeCatAdapter(IWildCat wildCat)
        {
            _wildCat = wildCat;
        }
        public string Name {
            get { return _wildCat.Breed; }
            set { }
        }

        public void Meow()
        {
            _wildCat.Growl();
        }

        public void Scratch()
        {
            _wildCat.Scratch();
        }
    }
}
