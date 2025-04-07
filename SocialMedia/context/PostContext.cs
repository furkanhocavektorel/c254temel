
using SocialMedia.entity;

namespace SocialMedia.context
{
    internal class PostContext:List
    {


        public void save(Post post)
        {
            posts.Add(post);

        }

    }
}
