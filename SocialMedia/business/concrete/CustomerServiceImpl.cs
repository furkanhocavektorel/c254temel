using OOPMid.util;
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

        public Customer? GetCustomerById(long id)
        {
            return _customerContext.getCustomerById(id);
        }


        // TODO - EMAIL/USERNAME kontrolleri
        public void save(string email, string username, string password)
        {
            Customer customer = new Customer();
            customer.Email = email;
            customer.Username = username;
            customer.Password = password;
            customer.Id=GenerateId.generateCustomerId();

            _customerContext.save(customer);


        }



    }
}
