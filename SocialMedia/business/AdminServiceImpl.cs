
using OOPMid.util;
using SocialMedia.context;
using SocialMedia.entity;

namespace SocialMedia.business
{
    internal class AdminServiceImpl : AdminService
    {
        AdminContext _adminContext;
        public AdminServiceImpl(AdminContext adminContext)
        {
            _adminContext = adminContext;
        }

        public void Save(string username, string password)
        {

            Admin ax = new Admin();

            ax.Username = username;
            ax.Password = password;
            ax.Id=GenerateId.generateAdminId();

            _adminContext.save(ax);
        }




    }
}
