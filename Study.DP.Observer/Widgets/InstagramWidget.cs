using Study.DP.Observer.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Observer.Widgets
{
    public class InstagramWidget : IObserver, IWidget
    {
        private string _instagram;
        private ISubject _subject;

        public InstagramWidget(ISubject subject)
        {
            _subject = subject;
            _subject.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine("Instagram: {0}", _instagram);
        }

        public void RemoveFromSubject()
        {
            _subject.RemoveObserver(this);
        }

        public void Update(string instagram, string twitter)
        {
            _instagram = instagram;
            Display();
        }
    }
}
