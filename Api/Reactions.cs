using RarePublishing.Models;
using RarePublishing.Data;

namespace RarePublishing.Api
{
    public static class Reactions
    {
        public static void Map(WebApplication app)
        {
            // GET all Post Reactions
            app.MapGet("/reactions", () =>
            {
                return ReactionsList.reactions;
            });

            // GET all reactions connected to a single ID
            app.MapGet("/reactions/{id}", (int id) =>
            {
                Reaction reaction = ReactionsList.reactions.FirstOrDefault(e => e.ID == id);
                if (reaction == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(reaction);
            });
        }
    }
}