using Study.DP.Observer.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Observer.Widgets
{
    public class TwitterWidget : IObserver, IWidget
    {
        private string _twitter;
        private ISubject _subject;

        public TwitterWidget(ISubject subject)
        {
            _subject = subject;
            _subject.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine("Twitter: {0}", _twitter);
        }

        public void RemoveFromSubject()
        {
            _subject.RemoveObserver(this);
        }

        public void Update(string instagram, string twitter)
        {
            _twitter = twitter;
            Display();
        }
    }
}
