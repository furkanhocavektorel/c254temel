
namespace OOPMid
{
    internal class OtomobilEylemleri
    {
        Otomobil otomobil;

        public OtomobilEylemleri(Otomobil otomobil)
        {
            this.otomobil = otomobil;
        }

        public  void hareketEt()
        {
            Console.WriteLine(otomobil.Marka+" araba baya hızlı gidiyor...");
        }

        public void durdur() { 
        
        }


        public void motoruCalistir()
        {

        }

    }
}
