
using SocialMedia.entity;

namespace SocialMedia.context
{
    class CommentContext : List
    {

        public void save(Comment comment)
        {
            comments.Add(comment);
        }

        internal List<Comment> findByPostId(long postId)
        {
           return comments.Where(comment => comment.Post.Id==postId).ToList();
        }
    }
}
