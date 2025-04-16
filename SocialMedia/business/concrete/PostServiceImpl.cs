using OOPMid.util;
using SocialMedia.business.@abstract;
using SocialMedia.context;
using SocialMedia.entity;

namespace SocialMedia.business.concrete
{
    internal class PostServiceImpl : PostService
    {

        PostContext _postContext;
        CustomerService _customerService;

        public PostServiceImpl(
            PostContext postContext, 
            CustomerService customerService)
        {
            _postContext = postContext;
            _customerService = customerService;
        }

        // bu müsteri id'sine kayıtlı biri var mı?
        public List<Post> getPostByCustomerId(long customerId)
        {
            return _postContext.getPostByCustomerId(customerId);
           
        }


        public List<Post> getPostList()
        {
           return _postContext.GetPosts();
        }

        public void save(string title, string desc, long customerId)
        {

            Customer c =_customerService.GetCustomerById(customerId);
            if (c == null) {
                Console.WriteLine("kullanici bulunamadi !!!");
                return;
            }

            Post post = new Post();
            post.Title = title;
            post.Description = desc;
            post.customer = c;
            post.Id=GenerateId.generatePostId();

            _postContext.save(post);
        }


        public Post getById(long id)
        {
            Post post = _postContext.getPostById(id);
            if (post==null)
            {
                throw new Exception(id+"ye sahip post bulunamadi...");
            }
            return post;
        }
    }
}
