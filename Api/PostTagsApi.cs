using RarePublishing.Models;
using RarePublishing.Data;

namespace RarePublishing.Api
{
    public static class PostTagsApi
    {
        public static void Map(WebApplication app)
        {

            app.MapGet("/postTags", () =>
            {
                return PostTagData.postTags;
            });
            app.MapGet("/postTags/{id}", (int id) =>
            {
                PostTag thisPostTag = PostTagData.postTags.FirstOrDefault(x => x.Id == id);
                if (thisPostTag == null)
                {
                    return Results.NotFound();
                }
                thisPostTag.TagObject = TagData.tags.FirstOrDefault(t => t.Id == thisPostTag.TagId);
                return Results.Ok(thisPostTag);
            });
            app.MapDelete("/postTags/delete/{id}", (int id) =>
            {
                PostTag thisPostTag = PostTagData.postTags.FirstOrDefault(t => t.Id == id);
                if (thisPostTag == null)
                {
                    return Results.NotFound();
                }
                PostTagData.postTags.Remove(thisPostTag);
                return Results.Ok(thisPostTag);
            });

          
            app.MapPost("/postTags/new", (PostTag postTag) =>
            {
                postTag.Id = PostTagData.postTags.Max(t => t.Id) + 1;
                PostTagData.postTags.Add(postTag);
                return postTag;
            });
            app.MapGet("/posts/{id}/postTags", (int id) =>
            {
                List<PostTag> postTagList = PostTagData.postTags.Where(pt => pt.PostId == id).ToList();
                if (postTagList == null)
                {
                    return Results.NotFound(id);
                }
                foreach (PostTag postTag in postTagList)
                {
                    postTag.TagObject = TagData.tags.FirstOrDefault(t => t.Id == postTag.TagId);
                }
                return Results.Ok(postTagList);
            });
            app.MapGet("/posts/{id}/tags", (int id) =>
            {
                List<Tag> filteredTags = new List<Tag>();
                List<PostTag> postTagList = PostTagData.postTags.Where(pt => pt.PostId == id).ToList();
                if (postTagList == null)
                {
                    return Results.NotFound(id);
                }
               
                foreach (PostTag postTag in postTagList)
                {
                    Tag singleTagObj = TagData.tags.FirstOrDefault(t => t.Id == postTag.TagId);
                    filteredTags.Add(singleTagObj);
                    

                }
                
                return Results.Ok(filteredTags);
            });




        }
    }
}




