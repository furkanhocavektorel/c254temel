using SocialMedia.business.@abstract;
using SocialMedia.business.concrete;
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

        public void save(int customerId)
        {
            // TODO post bilgileri alınacak post kayıt edilecek.

            PostService postService = new PostServiceImpl();


            postService.save()


        }
    }
}
