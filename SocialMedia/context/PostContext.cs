
using SocialMedia.entity;

namespace SocialMedia.context
{
    internal class PostContext : List
    {

        public void save(Post post)
        {
            posts.Add(post);

        }

        public List<Post> GetPosts()
        {
            return posts;
        }
        public List<Post> getPostByCustomerId(long customerId)
        {
            return posts.Where(post => post.customer.Id == customerId).ToList();

        }



    }
}
