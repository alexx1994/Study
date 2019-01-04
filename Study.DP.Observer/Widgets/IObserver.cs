using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Observer.Widgets
{
    public interface IObserver
    {
        void Update(string instagram, string twitter);
        void RemoveFromSubject();
    }
}
