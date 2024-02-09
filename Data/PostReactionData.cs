using RarePublishing.Models;
namespace RarePublishing.Data;

public class PostReactionsList
{
    public static List<PostReaction> postReactions = new()
    {
        new PostReaction
        {
            ID = 0,
            ReactionID = 0,
            UserID = 0,
            PostID = 0

        },

        new PostReaction
        {
            ID = 1,
            ReactionID = 1,
            UserID = 1,
            PostID = 1

        },

        new PostReaction
        {
            ID = 2,
            ReactionID = 2,
            UserID = 2,
            PostID = 2
        }
    };
}

