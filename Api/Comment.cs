using RarePublishing.Data;
using RarePublishing.Models;

namespace RarePublishing.Api
{

    public static class CommentApi
    {
        public static void Map(WebApplication app)
        {
            app.MapPost("/api/comments", (Comment comment) =>
            {
                comment.Id = CommentData.comments.Max(c => c.Id) + 1;
                CommentData.comments.Add(comment);
                return comment;
            });

            app.MapGet("/api/comments/{id}", (int id) =>
            {
                List<Comment> commentsbypost = CommentData.comments.Where(x => x.PostId == id).ToList();
                if (commentsbypost == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(commentsbypost);
            });
        }
    }
};
