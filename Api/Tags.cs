using RarePublishing.Models;
using RarePublishing.Data;

namespace RarePublishing.Api
{
    public static class Tags
    {
        public static void Map(WebApplication app)
        {

            app.MapGet("/api/tags", () =>
            {
                return TagData.tags;
            });
            app.MapGet("/api/tags/{id}", (int id) =>
            {
                Tag tag = TagData.tags.FirstOrDefault(x => x.Id == id);
                if (tag == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(tag);
            });
            app.MapDelete("/api/tags/delete/{id}", (int id) =>
            {
                Tag thisTag = TagData.tags.FirstOrDefault(t => t.Id == id);
                if (thisTag == null)
                {
                    return Results.NotFound();
                }
                TagData.tags.Remove(thisTag);
                return Results.Ok(thisTag);
            });

            
            app.MapPost("/api/tags/new", (Tag tag) =>
            {
                tag.Id = TagData.tags.Max(t => t.Id) + 1;
                TagData.tags.Add(tag);
                return tag;
            });
            app.MapPut("/api/tags/update{id}", (int id, Tag tag) =>
            {
                Tag tagToUpdate = TagData.tags.FirstOrDefault(t => t.Id == id);
                int tagIndex = TagData.tags.IndexOf(tagToUpdate);
                if (tagToUpdate == null)
                {
                    return Results.NotFound();
                }
                if (id != tag.Id)
                {
                    return Results.BadRequest();
                }
                TagData.tags[tagIndex] = tag;
                return Results.Ok(tag);
            });




        }
    }
}




