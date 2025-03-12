using System.Net;

namespace OOPGiris
{
    internal class Program
    {
        DortIslem di = new DortIslem();

        static void Main(string[] args)
        {
            Program program = new Program();
            program.test();
         

            DortIslem asdg = new DortIslem();

            asdg.sayi1 = 45;
            asdg.sayi2 = 13;

          

            asdg.toplama();
            asdg.carpma();




            di.toplama();

            test();


        }


        void test()
        {
            di.carpma();
        }


    



    }
}
