using RarePublishing.Models;
namespace RarePublishing.Data;

public class PostTagData
{
    public static List<PostTag> postTags = new List<PostTag> {

            new PostTag()
            {
                Id = 1,
                PostId = 1,
                TagId = 1,
            },
            new PostTag()
            {
                Id = 2,
                PostId = 2,
                TagId = 2,
            },
            new PostTag()
            {
                Id= 3,
                PostId = 3,
                TagId = 3,
            },
        };
};
