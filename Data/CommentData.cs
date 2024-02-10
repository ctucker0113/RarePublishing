using RarePublishing.Models;
namespace RarePublishing.Data;


public static class CommentData 
{
    public static List<Comment> comments = new List<Comment>
{
        new Comment
        {
            Id = 0,
            AuthorId = 0,
            PostId = 0,
            Content = "Oh wow! I love these poems!"
        },
        new Comment
        {
            Id = 1,
            AuthorId = 1,
            PostId = 1,
            Content = "Theres NO way!!!"
        },
        new Comment
        {
            Id = 2,
            AuthorId = 2,
            PostId = 2,
            Content = "Can't believe this!"
        },
        new Comment
        {
            Id = 3,
            AuthorId = 3,
            PostId = 3,
            Content = "Let's go!"
        },
        new Comment
        {
            Id = 4,
            AuthorId = 4,
            PostId = 0,
            Content = "So good!"
        }
    };
};


