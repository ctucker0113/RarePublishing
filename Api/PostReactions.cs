using RarePublishing.Models;

namespace RarePublishing.Data
{
    public static class PostReactions
    {
        public static void Map(WebApplication app)
        {
            // GET all PostReactions
            app.MapGet("/postReactions", () =>
            {
                return PostReactionsList.postReactions;
            });

            //        // GET all reactions connected to a single ID
            //        app.MapGet("/reactions/{id}", (int id) =>
            //        {
            //            Reaction reaction = ReactionsList.reactions.FirstOrDefault(e => e.ID == id);
            //            if (reaction == null)
            //            {
            //                return Results.NotFound();
            //            }
            //            return Results.Ok(reaction);
            //        });
            //    }
            //}
        }
    }
}