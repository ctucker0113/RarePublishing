using RarePublishing.Models;
namespace RarePublishing.Data;

public class PostTagData
{
    public static List<PostTag> postTags = new List<PostTag> {

            new PostTag()
            {
                PostId = 1,
                TagId = 1,
            },
            new PostTag()
            {
                PostId = 2,
                TagId = 2,
            },
            new PostTag()
            {
                PostId = 3,
                TagId = 3,
            },
        };
};
