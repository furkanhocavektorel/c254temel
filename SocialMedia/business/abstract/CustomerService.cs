using SocialMedia.entity;

namespace SocialMedia.business.@abstract
{
    internal interface CustomerService
    {
        public void save(string email, string username, string password);

        public Customer GetCustomerById(long id);
    }
}
