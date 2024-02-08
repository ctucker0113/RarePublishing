using RarePublishing.Models;
using RarePublishing.Data;

namespace RarePublishing.Api
{
    public static class Tags
    {
        public static void Map(WebApplication app)
        {

            app.MapGet("/tags", () =>
            {
                return TagData.tags;
            });
            app.MapGet("/tags/{id}", (int id) =>
            {
                Tag tag = TagData.tags.FirstOrDefault(x => x.Id == id);
                if (tag == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(tag);
            });
            app.MapDelete("/tags/delete/{id}", (int id) =>
            {
                Tag thisTag = TagData.tags.FirstOrDefault(t => t.Id == id);
                if (thisTag == null)
                {
                    return Results.NotFound();
                }
                TagData.tags.Remove(thisTag);
                return Results.Ok(thisTag);
            });

            app.MapPost("/tags", () =>
            {
                return TagData.tags;
            });
            app.MapPost("/tags/new", (Tag tag) =>
            {
                tag.Id = TagData.tags.Max(t => t.Id) + 1;
                TagData.tags.Add(tag);
                return tag;
            });




        }
    }
}




