using System;
using System.Collections.Generic;

namespace Patterns.Facade.Exercise
{
    public class TwitterClient
    {
        public List<Tweet> GetRecentTweets(string accessToken, int maxCount = 10)
        {
            Console.WriteLine($"Getting recent {maxCount} tweets");
            List<Tweet> tweets = new();
            var rollDice = new Random();
            for (var t = 0; t < maxCount; t++)
            {
                tweets.Add(new Tweet(DateTime.Now.AddDays(rollDice.Next(-20, 0)), "I love Tweeting x" + t));
            }
            return tweets;
        }
    }
}