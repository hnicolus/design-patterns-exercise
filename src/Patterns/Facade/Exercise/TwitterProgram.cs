namespace Patterns.Facade.Exercise
{

    public static class TwitterProgram
    {
        public static void Run()
        {
            var twitterService = new TwitterService();

            var tweets = twitterService.GetRecentTweets();

            tweets.ForEach(tweet => System.Console.WriteLine("Tweet : " + tweet));
        }

    }
}