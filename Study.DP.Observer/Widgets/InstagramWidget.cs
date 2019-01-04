using Study.DP.Observer.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Observer.Widgets
{
    public class InstagramWidget : IWidget
    {
        private string _instagram;
        
        public void Display()
        {
            Console.WriteLine("Instagram: {0}", _instagram);
        }
        
        public void Update(object sender, NewsEventArgs e)
        {
            _instagram = e.Instagram;
            Display();
        }
    }
}
