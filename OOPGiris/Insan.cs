
namespace OOPGiris
{
    class Insan
    {
        public string ad {  get; set; }
        private string soyad {  get; set; }
        public int yas{ get; set; }

        public string kullaniciAdi { get; set; }

        public int MyProperty { get; set; }


        public Insan(string ad, string soyad,int yas)
        {
            this.ad = ad;
            this.soyad = soyad;
        }

        // ad.yas.soyad@gmail.com
        internal string mailOlustur()
        {
            string mail = ad + "." + yas + "." + soyad + "@gmail.com";
            return mail;
        }


    }
}
