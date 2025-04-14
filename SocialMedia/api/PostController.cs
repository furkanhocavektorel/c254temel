using SocialMedia.business.@abstract;
using SocialMedia.business.concrete;
using SocialMedia.context;
using SocialMedia.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.api
{
    internal class PostController 
    {

        PostService _postService;

        public PostController()
        {
            _postService = new PostServiceImpl(
                new PostContext(),
                new CustomerServiceImpl(new CustomerContext()));
        }

        public void save(string title,string desc,long customerId)
        {
            _postService.save(title, desc, customerId);

        }

        public List<Post> getPosts() { 
            return _postService.getPostList();
        }

        public List<Post> getPostByCustomerId(long customerId) { 
        
            return _postService.getPostByCustomerId(customerId);
        }


    }
}
