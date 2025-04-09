using SocialMedia.api;
using SocialMedia.context;
using SocialMedia.entity;

namespace SocialMedia
{
    internal class Program
    {
        // kullanici eklenecek +
        // kullanici post paylaşacak +
        // TODO başka biri bu posta yorum yapacak 

        // FE - FRONT-END SIM
        static void Main(string[] args)
        {


            CustomerController customerController = new CustomerController();

            customerController.save("frkn", "asd", "frkn@gmail.com");
            customerController.save("ali", "xaxa", "alikoc@gmail.com");


            PostController postController = new PostController();

            postController.save("Hava Bugün çok güzel", "bugün yürüyüş için harika bir gün. sizde koşuya çıkın.", 2);

            for (int i = 0; i < List.posts.Count; i++) {

                Post po=List.posts[i];

                Console.WriteLine(po.ToString());

            
            }


        }
    }
}
