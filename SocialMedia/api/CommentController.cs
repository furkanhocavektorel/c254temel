
using SocialMedia.business.@abstract;
using SocialMedia.business.concrete;
using SocialMedia.entity;

namespace SocialMedia.api
{
    internal class CommentController
    {
        CommentService commentService;

        public CommentController()
        {
            this.commentService = new CommentServiceImpl(
                new context.CommentContext(),
                new PostServiceImpl(new context.PostContext(),new CustomerServiceImpl(new context.CustomerContext())), 
                new CustomerServiceImpl(new context.CustomerContext()));
        }


        public void save(string content, long postId,long customerId)
        {
            commentService.save(content, postId, customerId);
        }

        public List<Comment> findByPostId(long postId) {

            return commentService.findByPostId(postId);


        }



    }
}
