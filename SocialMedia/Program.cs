using SocialMedia.api;
using SocialMedia.context;

namespace SocialMedia
{
    internal class Program
    {
        // kullanici eklenecek
        // kullanici post paylaşacak
        // başka biri bu posta yorum yapacak

        // FE - FRONT-END SIM
        static void Main(string[] args)
        {


            CustomerController customerController = new CustomerController();

            customerController.save("frkn", "asd", "frkn@gmail.com");
            customerController.save("ali", "xaxa", "alikoc@gmail.com");


            for (int i = 0; i < List.customers.Count; i++)
            {

                Console.WriteLine(List.customers[i].Email);


            }


        }
    }
}
