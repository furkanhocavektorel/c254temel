using OOPMid.model;

namespace OOPMid.eylemler
{
    internal class OtomobilEylemleri : ITasitEylemleri
    {
        // override 
        public void kaydet(string marka, string model)
        {
            Console.WriteLine("otomobil kayit edildi.");
            
        }




    }
}
