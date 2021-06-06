using System.Collections.Generic;

namespace Patterns.Facade.Exercise
{
    public class TwitterService
    {
        public List<Tweet> GetRecentTweets(int maxCount = 10)
        {
            var oauth = new OAuth();
            var requestToken = oauth.RequestToken("appKey", "secret");
            var accessToken = oauth.GetAccessToken(requestToken);

            var twitterClient = new TwitterClient();

            return twitterClient.GetRecentTweets(accessToken);

        }
    }
}