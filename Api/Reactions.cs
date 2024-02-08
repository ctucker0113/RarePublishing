using RarePublishing.Models;
using RarePublishing.Data;

namespace RarePublishing.Data
{
    public static class Reactions
    {
        public static void Map(WebApplication app)
        {
            // GET all Reactions
            app.MapGet("/reactions", () =>
            {
                return reactions;
            });

            // GET all reactions connected to a single ID
            app.MapGet("/reactions/{id}", (int id) =>
            {
                Reaction reaction = reactions.FirstOrDefault(e => e.ID == id);
                if (reaction == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(reaction);
            });
        }
    }
}