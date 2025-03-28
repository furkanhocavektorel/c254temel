using SocialMedia.api;
using SocialMedia.context;

namespace SocialMedia
{
    internal class Program
    {
        // FE - FRONT-END SIM
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, 254 MEDIA!");

            AdminController adminController = new AdminController();

            Console.WriteLine("kullanici adi gir");
            string kullaniciAdi= Console.ReadLine();

            Console.WriteLine("sifre gir");
            string sifre= Console.ReadLine();

            adminController.SaveAdmin(kullaniciAdi,sifre);




            for(int i = 0; i < List.admins.Count; i++)
            {
                Console.WriteLine(List.admins[i].Id);
                Console.WriteLine(List.admins[i].Username);
            }


        }
    }
}
