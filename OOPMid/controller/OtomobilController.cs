
using OOPMid.eylemler;

namespace OOPMid.controller
{
    internal class OtomobilController
    {
        ITekeriOlanTasitlarEylemi tekeriOlanTasitlar;
        public OtomobilController()
        {
            tekeriOlanTasitlar=new OtomobilEylemleri();
        }

        public void tekerDegistir()
        {
            tekeriOlanTasitlar.tekerDegistir();
        }



    }
}
