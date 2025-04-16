

using SocialMedia.entity;

namespace SocialMedia.business.@abstract
{
    internal interface PostService
    {
        public void save(string title, string desc, long customerId);

        public List<Post> getPostList();

        public List<Post> getPostByCustomerId(long customerId);

        public Post getById(long id);

    }
}
