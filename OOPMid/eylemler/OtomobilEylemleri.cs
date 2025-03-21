using OOPMid.model;

namespace OOPMid.eylemler
{
    internal class OtomobilEylemleri
    {
     
        public void otomobilOlustur(string marka,string model,List<Motor> motorlar)
        {
            Otomobil otomobil = new Otomobil();
            otomobil.Marka = marka;
            otomobil.Model = model;
            otomobil.Motor = motorlar;

            Listeler.OtomobilList.Add(otomobil);
        }

        public Otomobil otomobilGetir(int index)
        {
           
            return Listeler.OtomobilList[index];
        }
      

    }
}
