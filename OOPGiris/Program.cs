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
            Insan i = new Insan("buse", "koc", 65);

            Insan i2 = new Insan("fatma", "türkmen", 23);

            Insan i3 = new Insan("mehmet", "canlı", 21);

            DortIslem dortIslem = new DortIslem(i, 54);

            DortIslem dortIslem2 = new DortIslem(i2, 78);

            dortIslem.insan = dortIslem2.insan;

            Console.WriteLine(dortIslem.insan.ad);




        }






    }
}
