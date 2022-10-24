using System;
using TwitterUCU;

namespace CompAndDel
{
    public class FilterTwitter : IFilter
    {
        public IPicture Filter(IPicture picture)
        {
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter(".", @"../Program/3.png")); 
            return picture;
        }
    }
}