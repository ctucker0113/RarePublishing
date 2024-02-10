using RarePublishing.Data;
using RarePublishing.Models;
using System;

namespace RarePublishing.Api
{
    public static class SubscriptionApi
    {
        public static void Map(WebApplication app)
        {
            //get user's subscriptions
            app.MapGet("/api/subscriptions/{userId}", (int userId) =>
            {
                List<Subscription> userSubs = SubscriptionData.subscriptions.Where(s => s.FollowerId == userId).ToList();
                if (userSubs == null)
                {
                    Results.NotFound();
                }
                return userSubs;
            });

            //create subscription
            app.MapPost("/api/subscriptions", (Subscription subscription) =>
            {
                subscription.Id = SubscriptionData.subscriptions.Max(s => s.Id) + 1;
                SubscriptionData.subscriptions.Add(subscription);
                return subscription;
            });

            //delete subscription
            app.MapDelete("/api/subscriptions/{id}", (int id) =>
            {
                Subscription subscription = SubscriptionData.subscriptions.FirstOrDefault(s => s.Id == id);
                if (subscription == null)
                {
                    return Results.NotFound();
                }
                SubscriptionData.subscriptions.Remove(subscription);
                return Results.Ok();
            });

            //get all user's followers
            app.MapGet("/api/subscriptions/followers/{userId}", (int userId) =>
            {
                List<Users> followers = new ();
                List<Subscription> userFollows = SubscriptionData.subscriptions.Where(s => s.AuthorId == userId).ToList();
                if (userFollows == null)
                {
                    Results.NotFound();
                }
                List<int> followerIds = userFollows.Select(f => f.FollowerId).ToList();
                foreach(int id in followerIds)
                {
                    var follower = UserData.users.FirstOrDefault(u => u.Id == id);
                    followers.Add(follower);
                }
                return followers;

            });
        }
    }
}
