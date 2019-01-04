using Study.DP.Observer.News;
using Study.DP.Observer.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var newsAggregator = new NewsAggregator();

            var instagramWidget = new InstagramWidget();
            var twitterWidget = new TwitterWidget();

            newsAggregator.NewsChanged += new NewsChangedEventHandler(instagramWidget.Update);
            newsAggregator.NewsChanged += new NewsChangedEventHandler(twitterWidget.Update);

            newsAggregator.NewNewsAvailable();
            Console.WriteLine();

            newsAggregator.NewsChanged -= new NewsChangedEventHandler(instagramWidget.Update);
            newsAggregator.NewNewsAvailable();

            Console.ReadLine();
        }
    }
}
