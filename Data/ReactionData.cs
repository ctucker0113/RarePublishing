using RarePublishing.Models;
namespace RarePublishing.Data;

public class ReactionsList
{
    public static List<Reaction> reactions = new()
    {
        new Reaction
        {
            ID = 0,
            Emoji = 0
        },

        new Reaction
        {
            ID = 1,
            Emoji = 1
        },

        new Reaction
        {
            ID = 2,
            Emoji = 2
        }
    };
}