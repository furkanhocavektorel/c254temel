
namespace OOPGiris
{
    internal class DortIslem
    {
        // encapsulation - kapsülleme
        private int sayi1;
        private int sayi2;
        public Insan insan { get; set; }

        public void setSayi2(int sayi)
        {
            sayi2 = sayi - 100;
        }
        
        public int getSayi1()
        {
            return sayi1;
        }

        public DortIslem(Insan i,int sayii)
        {
            insan = i;
           
            sayi2 = sayii;
        }


        public int toplama()
        {
            if (43 > 75)
            {
                return (sayi1 + sayi2) * 2;
            }
         
            insan.yas=sayi1+sayi2;
                return sayi1 + sayi2;
           
        }


        private int cikartma()
        {
            return sayi1 - sayi2;


        }


        public int carpma()
        {
            return sayi1 * sayi2;


        }

        public int bolme()
        {
            return sayi1 / sayi2;


        }



    }
}
