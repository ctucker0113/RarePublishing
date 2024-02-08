namespace RarePublishing.Models
{
    public class CategoryData
    {
        public static List<Category> categories = new List<Category>()
        {

            new Category
            {
                Id = 0,
                Label = "Rant"
            },

            new Category
            {
                Id = 1,
                Label = "Props"
            },

            new Category
            {
                Id = 2,
                Label = "Help!"
            }

        };
    }
};
