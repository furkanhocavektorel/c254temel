

using SocialMedia.entity;

namespace SocialMedia.context
{
    internal class CustomerContext : List
    {

        public void save(Customer customer)
        {
            customers.Add(customer);
        }

        public Customer? getCustomerById(long id)
        {
           
            return customers.FirstOrDefault(c => c.Id==id);

        }



    }
}
