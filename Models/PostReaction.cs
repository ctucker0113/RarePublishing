namespace RarePublishing.Models
{
    public class PostReaction
    {
        public int ID { get; set; }
        public int ReactionID { get; set; }
        public int UserID { get; set; }
        public int PostID { get; set; }
    }
}
