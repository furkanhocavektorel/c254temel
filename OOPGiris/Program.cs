using System.Net;

namespace OOPGiris
{

    /*
     OOP 4 adet prensip vardır.
    1_ encapsulation
     
     
     */
    internal class Program
    {

        static void Main(string[] args)
        {
           Insan i= new Insan("buse","koc",65);

           Insan i2= new Insan("fatma","türkmen",23);

           Insan i3= new Insan("mehmet","canlı",21);


            DortIslem dortIslem = new DortIslem(i,54);


            Console.WriteLine(dortIslem.insan.ad);


            dortIslem = new DortIslem(i2, 3);

            dortIslem.insan.ad = "kemal";
            Console.WriteLine(dortIslem.insan.ad);
            i2.ad = "can";
            Console.WriteLine(i2.ad);
            dortIslem.toplama();

            yassDegistir(i2);


            Console.WriteLine(dortIslem.insan.ad);
            Console.WriteLine(dortIslem.insan.yas);


        }



        static void yassDegistir(Insan ınsan)
        {
            ınsan.yas = 667;
        }



    }
}
