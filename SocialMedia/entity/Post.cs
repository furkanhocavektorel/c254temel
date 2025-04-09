
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

        public Post()
        {
            uploadDate= DateTime.Now;
        }




        public override string ToString()
        {
         
            return $"Post Id: {Id}\n" +
                   $"Title: {Title}\n" +
                   $"Description: {Description}\n" +
                   $"Photo URL: {photoUrl}\n" +
                   $"Upload Date: {uploadDate}\n" +
                   $"Customer: {customer.ToString()}";
        }
    }
}
