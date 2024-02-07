namespace RarePublishing.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public int FollerId { get; set; }
        public int AuthorId { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
