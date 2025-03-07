using System.Text;

namespace ikinciproje
{
    internal class Program
    {

        static int a = 75;
        static string ad = "furkan";
        static List<string> kızogrencilerinadlari ;

        static void m1()
        {
            kızogrencilerinadlari = new List<string>();

            kızogrencilerinadlari.Add("aysecik");

            Console.WriteLine(kızogrencilerinadlari[0]);
            

        }







        static void m2(List<string> kızogrencilerinadlari)
        {
            Console.WriteLine(ad);
            ad = "ali";
            a = 65;
            
        }

        static void Main(string[] args)
        {
            m1();

            #region

            //int sayi1;
            //int sayi2 = 0;

            //bool d = true;

            //Console.WriteLine("sayi1 giriniz");
            //sayi1 = Convert.ToInt32(Console.ReadLine());

            //// sayi1=24
            //// sonuc=24
            //// sayi2=7
            //// islem=3
            //while (d)
            //{

            //    Console.WriteLine("1_toplama 2_cikartma 3_ carpma 4_bolme 0_cikis");
            //    int islem = Convert.ToInt32(Console.ReadLine());

            //    if (islem == 0)
            //    {
            //        break;
            //    }



            //    if (islem < 0 || islem > 4)
            //    {
            //        Console.WriteLine("yanlis giris");
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("sayi2 giriniz");
            //        sayi2 = Convert.ToInt32(Console.ReadLine());

            //    }


            //    if (islem == 1)
            //    {
            //        sayi1 = cas(yas, sayi2);

            //    }
            //    else if (islem == 2)
            //    {
            //        sayi1 = cikartma(sayi1, sayi2);
            //    }
            //    else if (islem == 3)
            //    {
            //        sayi1 = carpma(sayi1, sayi2);
            //    }
            //    else if (islem == 4)
            //    {
            //        sayi1 = bolme(sayi1, sayi2);
            //    }

            //    if (islem > 0 && islem <= 4)
            //    {
            //        Console.WriteLine(sayi1);

            //    }

            #endregion
            #region
            //int y1 = 30;
            //int y2 = 40;
            //int y3 = 23;


            //int[] yaslar = { 30, 40, 50 };

            //yaslar[1] = yaslar[0]*3;

            //Console.WriteLine(yaslar[1]);


            //int[] yaslar2 = new int[8];

            //yaslar2[3] = 675;
            //yaslar2[6] = 232;
            //yaslar2[7] = 155;

            //Console.WriteLine(yaslar2[3]);
            //Console.WriteLine(yaslar2[5]);
            //Console.WriteLine(yaslar2[6]);

            //string[] isimler= new string[6];

            //isimler[3] = "furkan";


            //StringBuilder metin = new StringBuilder();
            //metin.Append("asd");

            //metindegis(metin);


            //Console.WriteLine(metin);

            //// pass by value
            //int sayi = 30;

            //sayiDegis(sayi);

            //Console.WriteLine(sayi);

            //// pass by reference
            //int[] sayiDizisi = { 34, 543, 43, 4, 4567, 54, 325, 3, 5, 43, 65 };

            //int sayi3 = 459;
            //sayiDizisi[3] = 33 ;

            //diziSayisiDegis(sayiDizisi);

            //Console.WriteLine(sayiDizisi[1]);


            //List<int> sayiListesi = new List<int>();
            //sayiListesi.Add(3243);
            //sayiListesi.Add(231);
            //sayiListesi.Add(547);
            //sayiListesi.Add(213);
            //sayiListesi.Add(453);
            //sayiListesi.Add(453);
            //sayiListesi.Add(453);
            //sayiListesi.Add(453);
            //sayiListesi.Add(451);

            //Console.WriteLine(sayiListesi[2]);

            //sayiListesi.Remove(213);


            //for (int i = 0; i < sayiListesi.Count; i++)
            //{
            //    if (sayiListesi[i] < 18)
            //    {
            //        sayiListesi.Remove(sayiListesi[i]);
            //    }
            //}

            //Console.WriteLine("*****************");
            //Console.WriteLine(sayiListesi.Count);
            //Console.WriteLine(sayiListesi.Capacity);

            //int[] sayiDizi = { 33, 5, 434, 54, 36, 54, 45, 4 };

            //degisBakalim(sayiDizi[3]); // 54

            //Console.WriteLine(sayiDizi[3]);

            //degisBakalim2(sayiDizi); // 354

            //Console.WriteLine(sayiDizi[3]); 
            #endregion
            #region try-catch
            //string merhjewj;

            //Console.WriteLine("c254 sınıfı");
            //int a = 0;
            //int b = 15;
            //int c = 0;
            //try
            //{
            //    Console.WriteLine("köprü acildi. metin gönderimi basliyor");
            //    c = b / a;

            //    Console.WriteLine("yas giriniz");
            //    int yas= Convert.ToInt32(Console.ReadLine());

            //}
            //catch (DivideByZeroException de)
            //{
            //    Console.WriteLine("0 a bölme");
            //}
            //catch (Exception dfsafsd)
            //{

            //    Console.WriteLine(dfsafsd.StackTrace);
            //    Console.WriteLine(dfsafsd.Message);

            //}
            //finally
            //{
            //    Console.WriteLine("köprü kapatildi");
            //}

            ////catch (FormatException fe)
            ////{
            ////    Console.WriteLine(fe.Message);
            ////}

            //Console.WriteLine(c);

            #endregion

            List<string> kızOgrenciler = new List<string>();

            m2(kızOgrenciler);



            //m2();
            m1();

            int b = a * 3; // 225

        }// main metod sonu


       


        


     

















        static void degisBakalim(int sayi)
        {
            sayi = 654;
        }

        static void degisBakalim2(int[] sayiDizi)
        {
            sayiDizi[3] = 354;
        }

        static void metindegis(StringBuilder a)
        {

            a.Append("ali");
           
        }

        static void sayiDegis(int sayi)
        {

            sayi = 170;
            Console.WriteLine(sayi);
        }

        static void diziSayisiDegis(int[] sayiDizisi)
        {
            sayiDizisi[1] = 253;
        }















        static int cas(int sayi1, int sayi2)
        {
            int toplama = sayi1 + sayi2;
            return toplama;
        }

        static int cikartma(int sayi1, int sayi2)
        {
            int cikartma = sayi1 - sayi2;
            return cikartma;
        }

        static int carpma(int sayi1, int sayi2)
        {
            int carpma = sayi1 * sayi2;
            return carpma;
        }

        static int bolme(int sayi1, int sayi2)
        {
            int bolme = sayi1 / sayi2;
            return bolme;
        }



        // parametre almayan, dönüş tipi olmayan
        static void r()
        {
            Console.WriteLine("hg");
        }

        // parametre alan, dönüş tipi olmayan
        static void p(int x)
        {
            int result = x * x;
            Console.WriteLine(result);
        }

        // parametre almayan, dönüş tipi olan
        static int csdfrdfhgfd()
        {
            int a = 2 * 54 - 23 / 43 * 32;
            return a;
        }

        // parametre alan, dönüş tipi olan
        static int h(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }






    }// class
}// namespace
