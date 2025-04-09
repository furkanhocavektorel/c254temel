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

        public void save(string title, string desc, long customerId)
        {


            Customer c =_customerService.GetCustomerById(customerId);
            if (c == null) {
                Console.WriteLine("hata customer null post atilamadi !!!");
                return;
            }

            Post post = new Post();
            post.Title = title;
            post.Description = desc;
            post.customer = c;

            _postContext.save(post);
        }

     





    }
}
