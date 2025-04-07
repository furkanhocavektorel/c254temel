
using SocialMedia.business.@abstract;
using SocialMedia.business.concrete;
using SocialMedia.context;

namespace SocialMedia.api
{
    internal class AdminController
    {

        AdminService _adminService;

        public AdminController()
        {
            _adminService= new AdminServiceImpl(new AdminContext());
        }

        public void SaveAdmin(string username,string password)
        {
            _adminService.Save(username, password);
        }


    }
}
