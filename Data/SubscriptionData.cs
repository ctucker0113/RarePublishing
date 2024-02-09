namespace RarePublishing.Models
{
    public class SubscriptionData
    {
        public static List<Subscription> subscriptions = new List<Subscription>()
        {
            new Subscription()
            {
                Id = 0,
                FollowerId = 0,
                AuthorId = 1,
            },
            new Subscription()
            {
                Id = 1,
                FollowerId = 1,
                AuthorId = 2,
            },
            new Subscription()
            {
                Id = 2,
                FollowerId = 2,
                AuthorId = 0,
            },
            new Subscription()
            {
                Id = 3,
                FollowerId = 0,
                AuthorId = 2,
            },
            new Subscription()
            {
                Id = 4,
                FollowerId = 1,
                AuthorId = 0,
            }
        };

    }
}


