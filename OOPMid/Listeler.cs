using OOPMid.model;

namespace OOPMid
{
    
    internal class Listeler
    {
        private static List<Motor> motorList = new List<Motor>();

        private static List<Otomobil> OtomobilList= new List<Otomobil>();

        public void motorEkle(Motor motor)
        {
            motorList.Add(motor);

        }

        public List<Motor> motorListesiGetir()
        {
            return motorList;
        }


    }
}
