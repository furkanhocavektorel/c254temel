using System.Text;

namespace ikinciproje
{
    internal class Program
    {
        static List<string> kizlar = new List<string> { "ayse", "merve", "fatma", "aslı", "irem", "beren", "gizem", "buse" };
        static List<string> erkekler = new List<string> { "mehmet", "ahmet", "davut", "furkan", "veli", "batuhan", "hakan", "mert", "onur", "oğuzhan" };


        static void Main(string[] args)
        {
            while (kizlar.Count > 0 && erkekler.Count > 0)
            {
                string girisYapan = kullaniciGiris();
                if (kizlar.Contains(girisYapan))
                {
                    esSecimi(girisYapan, kizlar, erkekler);
                }
                else if (erkekler.Contains(girisYapan))
                {
                    esSecimi(girisYapan, erkekler, kizlar);
                }
                else
                {
                    Console.WriteLine("Dans yarışmasında isminiz bulunmamaktadır.");
                }
            }
            aciktakiOgrenciler(kizlar, erkekler);
        }


        static string kullaniciGiris()
        {
            Console.WriteLine("İsminizi giriniz:");
            string girisYapan = Console.ReadLine();
            return girisYapan.ToLower();
        }


        static void esSecimi(string girisYapan, List<string> liste1, List<string> liste2)
        {
            bool d = true;
            while (d)
            {
                try
                {

                    Console.WriteLine("Bir öğrenci seçiniz.");

                    bool a = true;
                    while (a)
                    {
                        listeYazdirma(liste2);
                        string alinanAday = Console.ReadLine().ToLower();
                        if (liste2.Contains(alinanAday))
                        {
                            // TODO BURADAN DEVAM
                            Console.WriteLine(girisYapan + " ve " + alinanAday + " eşleşti.");
                            listedenCikarma(liste1, girisYapan);
                            listedenCikarma(liste2, alinanAday);
                            a = false;
                            d = false;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen listeden bir öğrenci seçiniz.");
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static void listedenCikarma(List<string> liste, string cikarilanIsim)
        {
            liste.Remove(cikarilanIsim);
        }


        static void listeYazdirma(List<string> liste)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine(liste[i]);

            }
        }


        static void aciktakiOgrenciler(List<string> kizlar, List<string> erkekler)
        {
            if (kizlar.Count > 0)
            {
                Console.WriteLine("Açıkta kalan kız öğrenciler:");
                listeYazdirma(kizlar);
            }
            if (erkekler.Count > 0)
            {
                Console.WriteLine("Açıkta kalan erkek öğrenciler:");
                listeYazdirma(erkekler);
            }
            else
            {
                Console.WriteLine("Açıkta öğrenci kalmamıştır.");
            }
        }

    }// class
}// namespace
