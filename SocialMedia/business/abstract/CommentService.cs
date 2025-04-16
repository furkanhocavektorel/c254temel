
using SocialMedia.entity;

namespace SocialMedia.business.@abstract
{
    internal interface CommentService
    {
        List<Comment> findByPostId(long postId);
        public void save(string content, long postId, long customerId);
    }
}
