

using OOPMid.eylemler;
using OOPMid.model;
using OOPMid.model.enums;
using OOPMid.util;

namespace OOPMid.controller
{
    internal class MotorController
    {
        ITasitEylemleri tasitEylemleri;

        public MotorController()
        {

            // interfaceler new lenemez
            tasitEylemleri =new OtomobilEylemleri();
                

        }


        public Motor olustur(int beygir,int hacmi,YakıtTürü yakit,string model)
        {
            tasitEylemleri.kaydet("vw", model);










            return motorEylemleri.motorOlustur(beygir, hacmi, yakit, üretici);

        }

        public Motor motorGetirIdyeGore(int id)
        {
            return motorEylemleri.motorGetir(id);
        }

        public List<Motor> motorGetirUreticiyeGore(string ureticiAdi) { 
        
            return motorEylemleri.motorGetirUreticiyeGore(ureticiAdi);
        
        }


    }
}
