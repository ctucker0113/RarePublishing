using RarePublishing.Models;

namespace RarePublishing.Data
{
    public class CategoryData
    {
        List<Category> categories = new List<Category>();
        {
            new Category()
            {
                Id = 0,
                Label = "Rant"
            },

            new Category()
            {
                Id = 1,
                Label = "Props"
            },

            new Category()
            {
                Id = 2,
                Label = "Help!"
            },
    
        };
    }
}

