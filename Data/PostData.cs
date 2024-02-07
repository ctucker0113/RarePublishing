using RarePublishing.Models;

List<Post> posts = new List<Post>
   {
    new Post
    {
        Id = 0,
        UserId = 0,
        CategoryId = 1,
        Title = "Love the new issue!",
        PublicationDate = new DateTime (2024, 1, 1),
        ImageUrl = "https://tse3.mm.bing.net/th?id=OIP.h2fOwX0d3v48ky143sa1xwHaFP&pid=Api&P=0&h=220",
        Content = "Great job on this month's issue. I loved the poems.",
        Approved = true
    },
    new Post
    {
        Id = 1,
        UserId = 1,
        CategoryId = 2,
        Title = "Back issue!!",
        PublicationDate = new DateTime (2024, 2, 5),
        ImageUrl = "https://tse3.mm.bing.net/th?id=OIP.DNjVw_MV-DuOwEu_jD-V4AHaGn&pid=Api&P=0&h=220",
        Content = "Can't find number 17 anywhere! Anyone have a lead?",
        Approved = true
    },
    new Post
    {
        Id = 2,
        UserId = 2,
        CategoryId = 0,
        Title = "Boo",
        PublicationDate = new DateTime (2024, 2, 8),
        ImageUrl = "https://tse4.mm.bing.net/th?id=OIP.ZtES-8XjKpE0fnESXzpMJgAAAA&pid=Api&P=0&h=220",
        Content = "So many posers!",
        Approved = true
    },
    new Post
    {
        Id = 3,
        UserId = 0,
        CategoryId = 1,
        Title = "Amazing!",
        PublicationDate = new DateTime (2024, 1, 28),
        ImageUrl = "https://tse4.mm.bing.net/th?id=OIP.UNYirUQttnIfhwh5DpgmkAHaH8&pid=Api&P=0&h=220",
        Content = "Thank you!",
        Approved = true
    }
   };

