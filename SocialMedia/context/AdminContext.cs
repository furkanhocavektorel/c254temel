
using SocialMedia.entity;

namespace SocialMedia.context
{
    internal class AdminContext : List
    {

        public void save(Admin admin)
        {
            admins.Add(admin);
        }




    }
}
