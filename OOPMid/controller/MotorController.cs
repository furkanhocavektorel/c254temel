

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


            return null;
          //  return motorEylemleri.motorOlustur(beygir, hacmi, yakit, üretici);

        }

        public Motor motorGetirIdyeGore(int id)
        {
            return null;
            //return motorEylemleri.motorGetir(id);
        }

        public List<Motor> motorGetirUreticiyeGore(string ureticiAdi) {

            return null;
            //return motorEylemleri.motorGetirUreticiyeGore(ureticiAdi);
        
        }


    }
}
