using SocialMedia.business.@abstract;
using SocialMedia.context;
using SocialMedia.entity;

namespace SocialMedia.business.concrete
{
    internal class CommentServiceImpl : CommentService
    {
        CommentContext context;
        PostService postService;
        CustomerService customerService;

        public CommentServiceImpl(CommentContext context,
            PostService postService,
            CustomerService customerService)
        {
            this.context = context;
            this.postService = postService;
            this.customerService = customerService;
        }

        public void save(string content, long postId, long customerId)
        {
            if (content == null) {
                throw new Exception("content bos olamaz");
            }

            Post post = postService.getById(postId);
            Customer customer = customerService.GetCustomerById(customerId);


            Comment comment = new Comment();       
            comment.Content = content;
            comment.Post=post;
            comment.Customer=customer;

            context.save(comment);


        }


        public List<Comment> findByPostId(long postId)
        {
            return context.findByPostId(postId);
        }

    }
}
