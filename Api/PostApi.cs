using RarePublishing.Models;
using System;
using System.Linq;
namespace RarePublishing.Api
{
    public static class PostApi
    {
        public static void Map(WebApplication app)
        {

            //get all posts
            app.MapGet("/api/posts", () =>
            {
                return PostData.posts;
            });

            //get single post
            app.MapGet("/api/posts/{id}", (int id) =>
            {
                Post post = PostData.posts.FirstOrDefault(p => p.Id == id);
                if (post== null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(post);
            });

            //create post
            app.MapPost("/api/posts", (Post post) =>
            {
                post.Id = PostData.posts.Max(p => p.Id) + 1;
                PostData.posts.Add(post);
                return post;
            });

            //update post
            app.MapPut("/api/posts/{id}", (int id, Post post) =>
            {
                Post postToUpdate = PostData.posts.FirstOrDefault(p => p.Id == id);
                int postIndex = PostData.posts.IndexOf(postToUpdate);
                if (postToUpdate== null)
                {
                    return Results.NotFound();
                }
                if (id != post.Id)
                {
                    return Results.BadRequest();
                }
                PostData.posts[postIndex] = post;
                return Results.Ok(post);
            });

            //delete post
            app.MapDelete("/api/posts/{id}", (int id) =>
            {
                Post post = PostData.posts.FirstOrDefault(p => p.Id == id);
                if (post == null)
                {
                    return Results.NotFound();
                }
                PostData.posts.Remove(post);
                return Results.Ok();
            });

            //filter by category
            app.MapGet("/api/posts/{catId}", (int catId) =>
            {
                List<Post> filteredPosts = new();
                filteredPosts = PostData.posts.Where(p => p.CategoryId == catId).ToList();
                if (filteredPosts == null)
                {
                    return Results.NotFound();
                }
                return filteredPosts;
            });

            //filter by title
            app.MapGet("/api/posts/title", (string title) =>
            {
                List<Post> filteredPosts = PostData.posts.Where(p => p.Title.Contains(title)).ToList();
                if (filteredPosts == null)
                {
                    return Results.NotFound();
                }
                return filteredPosts;

            });

            //filter by user
            app.MapGet("/api/posts/{userId}", (int userId) =>
            {
                List<Post> filteredPosts = PostData.posts.Where(p => p.UserId == userId).ToList();
                if (filteredPosts == null)
                {
                    return Results.NotFound();
                }
                return filteredPosts;
            });

            //see subscribed
            app.MapGet("/api/subscriptions/{userId}", (int userId) =>
            {
                List<Post> authorPosts = new();
                List<Post> subscribedPosts = new();

                List<Subscription> userSubscriptions = SubscriptionData.subscriptions.Where(s => s.FollowerId == userId).ToList();
                List<int> followedAuthors = userSubscriptions.Select(s => s.AuthorId).ToList();
                foreach (int author in followedAuthors)
                {
                    authorPosts = PostData.posts.Where(p => p.UserId == author).ToList();
                    foreach (Post post in authorPosts)
                    {
                        subscribedPosts.Add(post);
                    }
                }
                return subscribedPosts;

            });



        }
    }
}
