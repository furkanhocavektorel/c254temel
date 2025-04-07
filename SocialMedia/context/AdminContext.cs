
using SocialMedia.entity;

namespace SocialMedia.context
{
    internal class AdminContext : List
    {

        public void save(Admin admin)
        {
            admins.Add(admin);
        }

        // bütün adminleri listeleyen metot

        public Admin getAdmin(string username) {
            return admins.FirstOrDefault(x => x.Username.Equals(username));
        }

        public List<Admin> getList()
        {
            return admins;
        }
    }
}
