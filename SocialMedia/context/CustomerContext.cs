

using SocialMedia.entity;

namespace SocialMedia.context
{
    internal class CustomerContext : List
    {

        public void save(Customer customer)
        {
            customers.Add(customer);
        }



    }
}
