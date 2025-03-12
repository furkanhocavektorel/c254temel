
namespace OOPGiris
{
    internal class DortIslem
    {
        // protected,public,private,default,internal

        public int sayi1;
        public int sayi2;
        
        public void toplama()
        {
            Console.WriteLine(sayi1+sayi2);

        }


        private void cikartma()
        {
            Console.WriteLine(sayi1 - sayi2);

        }


        public void carpma()
        {
            Console.WriteLine(sayi1 * sayi2);

        }

        public void bolme()
        {
            Console.WriteLine(sayi1 / sayi2);

        }



    }
}
