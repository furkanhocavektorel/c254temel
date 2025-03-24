using OOPMid.model;

namespace OOPMid.eylemler
{
    internal class OtomobilEylemleri
    {
     
        public void otomobilOlustur(int id,string marka,string model,List<Motor> motorlar)
        {
            Otomobil otomobil = new Otomobil();
            otomobil.Marka = marka;
            otomobil.Model = model;
            otomobil.Motor = motorlar;
           
            // TODO OTOMOBİL EKLENECEK.

        }

   
      

    }
}
