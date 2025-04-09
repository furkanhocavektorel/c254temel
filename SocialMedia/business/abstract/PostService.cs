

using SocialMedia.entity;

namespace SocialMedia.business.@abstract
{
    internal interface PostService
    {
        public void save(string title,string desc,long customerId);
    }
