using SocialMedia.business.@abstract;
using SocialMedia.context;
using SocialMedia.entity;

namespace SocialMedia.business.concrete
{
    internal class CustomerServiceImpl : CustomerService
    {
        CustomerContext _customerContext;
        public CustomerServiceImpl(CustomerContext customerContext)
        {
            _customerContext = customerContext;
        }



        // TODO - EMAIL/USERNAME kontrolleri
        public void save(string email, string username, string password)
        {
            Customer customer = new Customer();
            customer.Email = email;
            customer.Username = username;
            customer.Password = password;

            _customerContext.save(customer);


        }



    }
}
