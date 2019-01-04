using Study.DP.Observer.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Observer.Widgets
{
    public class TwitterWidget : IWidget
    {
        private string _twitter;

        public void Display()
        {
            Console.WriteLine("Twitter: {0}", _twitter);
        }
        
        public void Update(object sender, NewsEventArgs e)
        {
            _twitter = e.Twitter;
            Display();
        }
    }
}
