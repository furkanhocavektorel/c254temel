
using OOPMid.util;
using SocialMedia.business.@abstract;
using SocialMedia.context;
using SocialMedia.entity;

namespace SocialMedia.business.concrete
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

            bool kontrol = kullaniciAdinaGoreAdminBulma(username);

            if (kontrol)
            {
                Console.WriteLine("kullanici adi zaten kayitli");
            }
            else
            {
                Admin ax = new Admin();
                ax.Username = username;
                ax.Password = password;
                ax.Id = GenerateId.generateAdminId();
                _adminContext.save(ax);
            }
        }



        // 1.yol

        public bool kullaniciAdinaGoreAdminBulma(string kullaniciAdi)
        {
            // IQUAREABLE -> DB SEVİYESİ
            // IENUMERABLE -> CODE SEVİYESİ
            List<Admin> adminlistesi = _adminContext.getList();

            for (int i = 0; i < adminlistesi.Count; i++)
            {

                if (adminlistesi[i].Username.Equals(kullaniciAdi))
                {
                    return true;
                }
            }

            return false;
        }


        public Admin kullaniciAdinaGoreAdminBulma2(string kullaniciAdi)
        {
            return _adminContext.getAdmin(kullaniciAdi);
        }

    }
}
