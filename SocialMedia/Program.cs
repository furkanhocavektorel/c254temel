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
            customerKaydet();
            postKaydet();

            PostController postController = new PostController();

            for (int i = 0; i < postController.getPosts().Count; i++)
            {

                Post po = postController.getPosts()[i];

                Console.WriteLine(po.ToString());

                Console.WriteLine("*************\n");
            }


            CommentController commentController = new CommentController();

            commentController.save("evet bencede süper abi", 3, 1);

            commentController.save("ben katılmıyorum. bence kötü.", 3, 3);

            List<Comment> comments=commentController.findByPostId(3);

            for (int i = 0; i < comments.Count; i++)
            {

                Console.WriteLine(comments[i]);

            }


            commentController.save(null, 3, 2);


        }

        public static void customerKaydet()
        {
            CustomerController customerController = new CustomerController();

            customerController.save("frkn", "asd", "frkn@gmail.com");
            customerController.save("ali", "xaxa", "alikoc@gmail.com");
            customerController.save("buse", "asd", "buse@gmail.com");
            customerController.save("fatma", "aaaaa", "fatma@gmail.com");

        }
        public static void postKaydet()
        {
            PostController postController = new PostController();

            postController.save("Bugün hava çok güzel", "Yürüyüş yapmak için harika bir gün! Koşuya çıkmayı düşünenler için de ideal.", 2);
            postController.save("Bugün güneşli bir gün", "Bugün dışarıda vakit geçirmek için harika bir gün. Koşu yapmak isteyenlere önerimdir.", 1);
            postController.save("Güzel bir bahar günü", "Hava çok güzel, yürüyüş yapmak için mükemmel bir fırsat. Koşuya çıkmaya ne dersiniz?", 1);
            postController.save("Hava harika", "Bugün yürüyüş ve koşu için en iyi zamanlardan biri. Kendinizi dışarıda hissedin.", 2);
            postController.save("Yeni bir gün başlıyor", "Dışarıda harika bir hava var. Yürüyüş yaparak güne başlayabilirsiniz.", 3);
            postController.save("Havanın tadını çıkar", "Bugün yürüyüş yapmak için mükemmel bir gün. Koşuya çıkmayı da unutmayın.", 4);
            postController.save("Sıcak bir yaz günü", "Bugün sıcak bir gün. Dışarıda spor yapmak isteyenlere tavsiyem, sabah erken saatlerde çıkmaları.", 3);
            postController.save("Soğuk ama güzel bir sabah", "Bugün soğuk ama güzel bir hava var. Koşuya çıkmak isteyenlere önerim sabah saatleri.", 4);
            postController.save("Gün batımında koşu", "Bugün gün batımında koşmak için ideal bir hava var. Denemelisiniz.", 3);
            postController.save("Rüzgarlı ama keyifli", "Bugün biraz rüzgarlı ama dışarıda vakit geçirmek için harika bir gün. Koşuya çıkmayı unutmayın.", 4);
        }


    }
}
