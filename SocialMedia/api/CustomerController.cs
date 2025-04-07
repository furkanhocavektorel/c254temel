
using SocialMedia.business.@abstract;
using SocialMedia.business.concrete;
using SocialMedia.context;


namespace SocialMedia.api
{
    internal class CustomerController
    {
        CustomerService _customerService;

        public CustomerController()
        {
            _customerService = new CustomerServiceImpl(new CustomerContext());
        }


        public void save(string username, string password, string mail)
        {

            _customerService.save(mail, username, password);

        }



    }
}
