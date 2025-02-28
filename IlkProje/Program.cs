namespace IlkProje
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region

            //int a;

            //if (true) {

            //    if (true) {
            //        int b = 3;
            //    }

            //}

            #region degisken tanimlama

            //// DEGISKENLER

            //// METİNSEL TİP

            //string ilkmetin = "merhabalar";

            //Console.WriteLine(ilkmetin);

            //// TAM SAYI

            //byte ücüncüTamSayi = 244; //   0,255


            //short ikinciTamSayi = 25111;
            //int ilkTamSayi2 = 32445;

            //// -32768 ,32767}

            //int ilkTamSayi = 32445; // -2.147.483.648,2.147.483.647

            //long dorduncuTamSayi = 21474836475; // -... , 9.223.372.036.854.775.807

            //// Ondalıklı Sayi
            //double d = 33.213123;

            //// cast etmek
            //float f = 453.2345f;

            //// KOSUL
            //bool b = true;
            //bool c = false;

            //// karakter
            //char ch = 'k';

            //int toplama = (byte)(ücüncüTamSayi / (short)dorduncuTamSayi - ikinciTamSayi);
            //Console.WriteLine(toplama);

            #endregion

            #region islemler
            //// BOY:1.84 m
            //// kilo: 96 
            //// VKI NEDİR?

            //double boy = 1.84;
            //int kilo = 96;

            //// kilo/(boy*boy)

            //double vki = kilo / (boy * boy);
            //Console.WriteLine(vki);

            //int sayi1 = 67;
            //int sayi2 = 23;

            //double sonuc = sayi1 / (double)sayi2;

            //Console.WriteLine(sonuc + 35); //2,91...
            //double i = 32 * 4 * 3 * 6 - 32 - 5 + 23;
            //Console.WriteLine(77 + 78);
            //Console.WriteLine("xaxasad" + 3);
            //Console.WriteLine("xaxasad3");
            Console.WriteLine(5 * 8 + 3 + "32" + 5 + 2);// 83252

            //Console.WriteLine("merhabalar"
            //    + " selamlar burası c240 sınıfıdır."
            //    + "\n \t burada çok güzel" +
            //    " c# dersi vardır.sizide bekleriz" +
            //    "ne demis\b  mevlana \"yol yürüdükce aydınlanır\"");

            //string x = "vektorele hg";
            //string er5 = "yeni dolunay kilici";
            //int a = 5;


            //double boy2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(boy2);

            //string metin4 = x + "gdsfdsfs" + a + er5 + x + "sdasjkdash";

            //Console.WriteLine("ad gir");
            //string ad = Console.ReadLine();

            //string soyad = Console.ReadLine();


            //int kilo2 = 33;

            //Console.WriteLine(ad + soyad + boy2 + kilo2);

            // ad soyad,yas girilecek
            // ad.yas.soyad@gmail.com
            // ekrana basılacak


            //Console.WriteLine("adınızı giriniz lütfen");
            //string ad= Console.ReadLine().ToLower();

            //Console.WriteLine("soyadınız giriniz");
            //string soyad= Console.ReadLine();

            //Console.WriteLine("dogum yılınızı giriniz");
            //int dt= Convert.ToInt32(Console.ReadLine());

            //int yas = 2025 - dt;

            //string mail = ad +"."+ yas +"."+ soyad + "@gmail.com";
            //Console.WriteLine("olusturdugumuz mail adresi :\n"+ mail);

            #endregion

            #region 17.02tekrar
            //string metin = "furkan";
            //metin = metin + "türkmen"; // furkantürkmen

            //Console.WriteLine(metin.IndexOf("r"));
            //Console.WriteLine(metin.LastIndexOf("r"));

            //Console.WriteLine(metin.Length);
            //Console.WriteLine(metin.ToLower());
            //Console.WriteLine(metin.ToUpper());
            //Console.WriteLine(metin.Trim());
            //Console.WriteLine("***");
            //Console.WriteLine(metin.Substring(7,5));
            //Console.WriteLine("*------*");

            //metin.Concat("merhabalar");
            //// girilen metin benim metnimin içinde geçiyor mu?
            //Console.WriteLine(metin.Contains("fur"));
            //// girilen metin ile kendi metnimiz aynı mı diye bakar.
            //Console.WriteLine(metin.Equals("fur"));

            #endregion


            // kullanici ehliyet alabilir mi?


            /* KOŞUL
            
            if (kosul girilecek){
                koşul doğru ise burası çalışır
                yanlis ise süslü parantezler arasına girmez
            }else {
            
            }

             */


            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if(sayi == 78) {

            //    Console.WriteLine("oooo kral hg doğruymuş koşulun aferin...");

            //}
            //else
            //{
            //    Console.WriteLine("çok yanlis bir sayi secimi !!!");
            //}

            //Console.WriteLine("DEVAM ");


            #region ehliyet

            //Console.WriteLine("dogum yilini giriniz");

            //int dt = Convert.ToInt32(Console.ReadLine());

            //int yas = 2025 - dt;


            //if (yas >= 18)
            //{
            //    Console.WriteLine(yas +"- ehliyet alabilirsin bravo...");
            //}
            //else
            //{
            //    int kalanYil = 18 - yas;

            //    Console.WriteLine(kalanYil+" yil sonra alabilirsin...");
            //}

            #endregion




            //Console.WriteLine("yasinizi giriniz");
            //int yas=Convert.ToInt32(Console.ReadLine());

            //// 35

            //if (yas < 18) {

            //    Console.WriteLine("büyüde gel alamazsın");
            //}
            //else if(yas<=25)
            //{
            //    Console.WriteLine("alabilrsin");
            //}
            //else if(yas==65)
            //{
            //    Console.WriteLine("kampanya sende alabilirsin");
            //}


            // VKI HESAPLAMA
            // VKI = KG/(Boy*Boy) , boy metre cinsinden
            // 20 > VKI -> zayıf
            // 20<VKI<30 -> ideal
            // VKI > 30  -> Obez


            //Console.WriteLine("kg giriniz");
            //int kilo= Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("boy giriniz...");
            //double boy= Convert.ToDouble(Console.ReadLine());

            #region vki1

            //double VKI = kilo / (boy * boy);

            //// iki koşulda sağlanmalı
            //// -1
            //if (VKI>0 && VKI <20) {

            //    Console.WriteLine("zayıfsın");

            //}else if (VKI>=20 && VKI<30)
            //{
            //    Console.WriteLine("idealsin");

            //}else if (VKI>=30)
            //{
            //    Console.WriteLine("obezsin");
            //}
            //else
            //{
            //    Console.WriteLine("yanlis deger");
            //}

            #endregion

            #region
            /*   
               // boy = 4     , kilo=50
               if (kilo>0 && kilo<700 && boy>0 && boy < 3.0)
               {

                   double VKI = kilo / (boy * boy);

                   if (VKI < 20)
                   {

                       if (VKI < 10)
                       {
                           Console.WriteLine("hemen serum yemelisin");
                       }

                       Console.WriteLine("zayıfsın");

                   }
                   else if (VKI < 30)
                   {
                       Console.WriteLine("idealsin");

                   }
                   else
                   {
                       Console.WriteLine("obezsin");
                   }

               }// boy kilo if'i
               else
               {
                   Console.WriteLine("boy veya kiloyu yanlis girdiniz....");
               }// boy kilo elsesi

               */

            //int sayi = Convert.ToInt32(Console.ReadLine());
            //string metin= Console.ReadLine();

            //if (sayi > 50 && sayi<=120) {

            //    Console.WriteLine("büyük sayi");

            //}else
            //if (sayi > 100)
            //{
            //    Console.WriteLine("cok büyük sayi");
            //}
            //else
            //{
            //    Console.WriteLine("bilinmeyen");
            //}


            //if (sayi == 0)
            //{
            //    if(metin.Equals("ali"))
            //    {
            //        Console.WriteLine("memurluk kilidi acildi");
            //    }
            //    else
            //    {
            //        Console.WriteLine("atanamadiniz");
            //    }

            //}
            //else if (sayi == 1) { 

            //    if(metin == "ayse")
            //    {
            //        Console.WriteLine("kamu iscisi olarak atandı");
            //    }
            //    else
            //    {
            //        Console.WriteLine("gecmis olsun");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("by by");
            //}


            /*
             kaç gün kiralamak istiyorsun?
            
             
              kiralamak istediğiniz araba türü nedir
            1_suv
            2_ sedan

            suv altında:
            1_range -> 1500 TL
            2_x5    -> 1200 TL

            sedan altında:
            1_e200  -> 800 TL
            2_A6    -> 1350 TL
           
            toplam ücret = gün * araba_fiyati
            total fiyat ekrana yazsın
             
             */

            //Console.WriteLine("kaç gün istiyorsun ?");
            //int gün = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("araba kategorilerimiz: \n1_suv\n2_sedan");
            //int kategori= Convert.ToInt32(Console.ReadLine());

            //int günlükFiyat=0; // galerici


            //if (kategori == 1)
            //{
            //    Console.WriteLine("suv olarak range ve x5 modelimiz mevcut.\n" +
            //        "hangisini istersiniz?");
            //    string suv= Console.ReadLine();


            //    if(suv.Equals("range"))
            //    {
            //        günlükFiyat = 1500;
            //        string ad = "furklan";

            //    }else if(suv.Equals("x5"))
            //    {
            //        günlükFiyat = 1200;
            //    }
            //    else
            //    {
            //        Console.WriteLine("aradığınız araba model mevcut değil...");
            //    }


            //}
            //else if (kategori == 2) {

            //    Console.WriteLine("sedan olarak e200 ve a6 modelimiz mevcut.\n" +
            //        "hangisini istersiniz?");

            //    string sedan = Console.ReadLine();

            //    if (sedan.Equals("e200"))
            //    {
            //        günlükFiyat = 800;

            //    }
            //    else if (sedan.Equals("a6"))
            //    {
            //        günlükFiyat = 1350;
            //    }
            //    else
            //    {
            //        Console.WriteLine("aradığınız araba model mevcut değil...");
            //    }



            //}
            //else
            //{
            //    Console.WriteLine("yanlis kategori tekrar deneyiniz...");
            //}

            //int toplam = gün * günlükFiyat;
            //Console.WriteLine("toplam ücret: "+ toplam);

            //int sayi = 67;

            //bool deger=false;

            ////    true    &&   true        true      true
            //if (sayi > 55 && sayi%5==2 && sayi==67 && sayi<100)
            //{
            //    Console.WriteLine("sayi 55 mis");
            //}
            //else {
            //    Console.WriteLine("yanlis deger");
            //}

            ////   false        true         true
            //if (sayi <= 80 || sayi%5!=0  || sayi == 87)
            //{

            //}
            //else
            //{

            //}


            /*
             
             admin maili= f@gmail.com
             admin password= asd123asd 
             roller:  admin,customer,dev, manager


            kullanicidan mail ve password ve role alınacak
            mail doğru değil ise mail doğru degil
            sifre doğru degil ise sifre dogru degil
            diye ekrana bastırılacak.
            role admin degil ise admin rolünde degilsin bys 
            diye ekrana bastırılacak.
             */

            #endregion

            #region mail_kontrol
            //string adminmail = "f@gmail.com";
            //string adminpass = "asd123asd";
            //string adminrole = "admin";

            //Console.WriteLine("mail gir");
            //string mail=Console.ReadLine();

            //if (mail.Equals(adminmail))
            //{
            //    Console.WriteLine("pass gir");
            //    string pass=Console.ReadLine();

            //    Console.WriteLine("role giriniz");
            //    string role=Console.ReadLine();

            //    if (adminpass.Equals(adminpass) && adminrole.Equals(role)) {
            //        Console.WriteLine("dogru giris gel.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("role veya yetki hatasi");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("yanlis mail");
            //}
            #endregion

            #region

            //int sayi = 58;

            //if (sayi == 57)
            //{
            //    Console.WriteLine("ali");

            //} else if (sayi == 58)
            //{
            //    Console.WriteLine("mehmet");

            //}
            //else if (sayi == 59)
            //{
            //    Console.WriteLine("can");

            //}
            //else
            //{
            //    Console.WriteLine("buse");

            //}

            /* switch-case*/

            //sayi = 0;

            //string ad = "furkan";
            //switch (ad) {

            //    case "57": Console.WriteLine("kücük"); break;
            //    case "mehmet": Console.WriteLine("orta"); break;
            //    case "ali": Console.WriteLine("büyük"); break;
            //    default: Console.WriteLine("istenlien sayilar değil"); break;

            //}   




            /*
             bir ürünün fiyatını kullanıcı girecek:
            ürün:
            klavye ise: 0-1000 arası ucuz 1000 üstü pahalı
            mouse ise: 0-1000 arası ucuz 1000 üstü ise pahalı
             */

            //Console.WriteLine("fiyat gir");
            //int fiyat = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("ürün 1_klavye mi 2_mouse mu");
            //int ürün = Convert.ToInt32(Console.ReadLine());



            //if (fiyat >= 1000 && ürün == 1 || ürün == 2) {

            //    Console.WriteLine("pahalı");

            //}else if (fiyat < 1000 && (ürün == 1 || ürün == 2))
            //{
            //    Console.WriteLine("ucuz");
            //}
            //else
            //{
            //    Console.WriteLine("yanlis ürün girisi");
            //}


            //if (ürün == 1 || ürün == 2)
            //{
            //    if (fiyat>1000)
            //    {
            //        Console.WriteLine("pahalı");

            //    }
            //    else
            //    {
            //        Console.WriteLine("ucuz");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("yanlis ürün girisi");
            //}

            #endregion

            #region while
            /* 
            
            while(koşul){
            
            cw("kosul saglanır ise calisir");

            }

            */
            //int sayi = 1;
            //int i = 0;

            // degisen
            // sayi :1
            // i : 0
            // ekran : 0,

            //while (sayi == 0)
            //{

            //    Console.WriteLine("while ici sayi: " + i);
            //    i = i + 1;

            //    if (i == 10)
            //    {
            //        sayi = 3;

            //        while (sayi == 0) {

            //            Console.WriteLine("burası da neresi");

            //            sayi = 0;

            //        }

            //    }
            //    if (i > 30000)
            //    {
            //        sayi = 0;
            //    }


            //}

            //int a = i * 3;
            //Console.WriteLine("kod devam ediyor while bitti...");

            #endregion

            //int sayi = 3;

            //// sayi=4

            ////     true      false -> false
            //while (true || sayi>3) {


            //    Console.WriteLine("asdsa");

            //    sayi++; // sayi=sayi+1

            //    if (sayi == 30) {
            //        break;
            //    }

            //}




            // 1-10 arası sayıları toplayan program


            //int sonuc = 0;

            //Console.WriteLine("ilk sayiyi giriniz...");
            //int xxx= Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("ikinci sayiyi giriniz...");
            //int sadfgsad = Convert.ToInt32(Console.ReadLine());

            //// xxx  = 21 -> başlangıc sayisi
            //// sadf = 20 -> bitis sayisi
            ////sonuc = 74

            //while (xxx<=sadfgsad) {

            //    sonuc = xxx+sonuc;

            //    xxx++;

            //}

            //Console.WriteLine("toplama sonucu: " + sonuc);






            // 5! hesaplayan program


            //int d = 5;
            //int s = 1;


            //while (d!=1)
            //{
            //    s = s * d;
            //    d--;
            //}
            //Console.WriteLine(s);


            //int d2 =1;
            //int s2=1;

            //while (d2<=5)
            //{
            //    s2 = d2 * s2;
            //    d++;
            //}


            #region arac-kiralama

            /*
            
            arac kiralama
            gün sayısında göre arac fiyatı ile carpıp total fiyat 
            cikartilacak.
            ama kullanıcı suv kategorisine girdi ve 
            yanlis girdigini fark etti.
            bir üst menüye dön seceneginden tekrar
            arac kategorisi menusune dönebilir

            1_ suv 2_ sedan 0_cikis yap

            * 1 basti
            
            1_x5
            2_ range
            3_ g class
            0_bir üst menü (arac kategorisi)
            
            *2 basti
            1_m5
            2_cls350
            3_mazda
            0_ bir üst menü (arac kategorisi)

             */

            //Console.WriteLine("sadasdas");
            //int gün = Convert.ToInt32(Console.ReadLine());

            //int aracFiyat = 0;


            //int kategoriSecim = 1;

            //int araclarinToplamFiyati = 0;

            // kategoriSecim=0
            // aracSecim = 
            // aracfiyat=900

            /*
            while (kategoriSecim!=0 && (kategoriSecim==1 || kategoriSecim==2))
            {
                Console.WriteLine("1_suv 2_sedan 0_cikis yap");
                kategoriSecim = Convert.ToInt32(Console.ReadLine());

                switch (kategoriSecim) {
                    case 1:

                        Console.WriteLine("1_x5 2_range 0_üst menü");
                        int aracSecim = Convert.ToInt32(Console.ReadLine());

                        switch (aracSecim) {
                            case 1: aracFiyat= 1000; break;
                            case 2: aracFiyat = 1200; break;
                            case 0: break;
                        }

                        break;

                    case 2:

                        Console.WriteLine("1_m5 2_mazda 0_üst menü");
                        int aracSecim2 = Convert.ToInt32(Console.ReadLine());

                        switch (aracSecim2)
                        {
                            case 1: aracFiyat = 1300; break;
                            case 2: aracFiyat = 900; break;
                            case 0: break;

                        }

                        break;

                    case 0: break ;
                
                }


                if (kategoriSecim != 0)
                {
                    int sonuc = aracFiyat * gün;
                    Console.WriteLine("toplam fiyat: " + sonuc);
                }


            }

            */



            //    while (kategoriSecim != 0 )
            //    {
            //        Console.WriteLine("1_suv 2_sedan 0_cikis yap");
            //        kategoriSecim = Convert.ToInt32(Console.ReadLine());


            //        if (kategoriSecim == 1)
            //        {

            //            Console.WriteLine("1_x5 2_range 0_üst menü");
            //            int aracSecim = Convert.ToInt32(Console.ReadLine());

            //            switch (aracSecim)
            //            {
            //                case 1: aracFiyat = 1000; break;
            //                case 2: aracFiyat = 1200; break;
            //                case 0: break;
            //            }

            //        }

            //        else if (kategoriSecim == 2)
            //        {

            //            Console.WriteLine("1_m5 2_mazda 0_üst menü");
            //            int aracSecim2 = Convert.ToInt32(Console.ReadLine());

            //            switch (aracSecim2)
            //            {
            //                case 1: aracFiyat = 1300; break;
            //                case 2: aracFiyat = 900; break;
            //                case 0: break;

            //            }

            //        }


            //        else if (kategoriSecim == 0)
            //        {
            //            Console.WriteLine("sistem kapatiliyor güle güle");
            //            break;
            //        }

            //        else
            //        {
            //            Console.WriteLine("yanlis giris lütfen kategoriden bir sey secin...");
            //        }

            //        int sonuc = gün * aracFiyat;
            //        Console.WriteLine("toplam fiyat: "+ sonuc);

            //    }




            #endregion

            //int i = 1;
            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //Console.WriteLine("*******");


            //for(int i2=5 ; i2 < 10; i2++)
            //{
            //    Console.WriteLine(i2);

            #endregion


            //mailolustur();
            //Console.WriteLine("mail yukarıdadır");

            //Console.WriteLine("başka kaç mail oluşturmak istersin");

            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int i = 1;


            //while (sayi >= i)
            //{
            //    mailolustur();
            //    Console.WriteLine("mail oluşturuldu");

            //    if (i==2)
            //    {
            //        test();

            //    }

            //    i++;
            //}


            Console.WriteLine("sayi1 gir");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sayi2 gir");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            toplama(sayi1, sayi2, "sdgfdsg");
            cikartma(sayi1,sayi2);


        } // Main metodu bitis



        // parametre alan metod
        static void toplama(int a,int sayi2,string ad)
        {
            
            Console.WriteLine(a + sayi2);
        }


        static void cikartma(int ali,int fb)
        {
            Console.WriteLine(ali - fb);
        }

















        // SOLID PRENSIPI
        // Single responsibility
        // open-close
        // Liskov
        // Interface seg
        // Depency Injection

        static void test()
        {
            Console.WriteLine("test metoduna hg");
            int a = 65;
            int b = 675;
            int c = 543;
            double sonuc = a * 3d / b * (c - b) / 2 + (a + b + 10);

            Console.WriteLine(sonuc);

        }

        static void mailolustur()
        {
            Console.WriteLine("adinizi giriniz...");
            string ad= Console.ReadLine();

            Console.WriteLine("soyad giriniz...");
            string soyad= Console.ReadLine();

            //furkan.turkmen@gmail.com
            string mail= ad+"."+soyad+"@gmail.com";

            Console.WriteLine(mail);
            

        }


      








    }// Internal Class program bitis
}
