using RarePublishing.Models;
namespace RarePublishing.Data;

public class TagData
{
    public static List<Tag> tags = new List<Tag> {

            new Tag()
            {
                Id = 1,
                Label = "label1",
            },
            new Tag()
            {
                Id = 2,
                Label = "label2",
            },
            new Tag()
            {
                Id = 3,
                Label = "label3",
            },
        };
};
