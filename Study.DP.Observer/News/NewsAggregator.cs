using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study.DP.Observer.Widgets;

namespace Study.DP.Observer.News
{
    //public class NewsEventArgs
    //{
    //    public NewsEventArgs(string instagram, string twitter)
    //    {
    //        Instagram = instagram;
    //        Twitter = twitter;
    //    }

    //    public string Instagram { get; private set; }
    //    public string Twitter { get; private set; }

    //}

    //public delegate void NewsChangedEventHandler(object sender, NewsEventArgs e);
    
    public class NewsAggregator : ISubject
    {
        private static Random _random;

        private List<IObserver> _observers;

        public NewsAggregator()
        {
            _random = new Random();

            _observers = new List<IObserver>();
        }

        //public event NewsChangedEventHandler NewsChanged;

        public void NotifyObserver()
        {
            string instagram = GetInstagramNews();
            string twitter = GetTwitterNews();

            foreach (var observer in _observers)
            {
                observer.Update(instagram, twitter);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public string GetInstagramNews()
        {
            var news = new List<string>()
            {
                "News from insta 1",
                "News from insta 2",
                "News from insta 3",
            };

            return news[_random.Next(3)];
        }

        public string GetTwitterNews()
        {
            var news = new List<string>()
            {
                "News from xTwitter 1",
                "News from Twitter 2",
                "News from Twitter 3",
            };

            return news[_random.Next(3)];
        }

        public void NewNewsAvailable()
        {
            NotifyObserver();
        }
    }
}
