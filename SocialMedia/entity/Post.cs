
namespace SocialMedia.entity
{
    internal class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string? photoUrl { get; set; }

        public DateTime uploadDate { get; set; }

        public Customer customer { get; set; }
        

    }
}
