using System;
using Humanizer;
namespace Patterns.Facade.Exercise
{
    public class Tweet
    {
        private DateTime _publishedDate;
        private string _post;

        public Tweet(DateTime date, string post)
        {
            _publishedDate = date;
            _post = post;
        }

        public override string ToString()
        {
            return $"Post : {_post}, posted {_publishedDate.Humanize()} ";
        }
    }
}