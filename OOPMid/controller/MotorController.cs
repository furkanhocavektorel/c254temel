

using OOPMid.eylemler;
using OOPMid.model;
using OOPMid.model.enums;

namespace OOPMid.controller
{
    internal class MotorController
    {
        MotorEylemleri motorEylemleri = new MotorEylemleri();


        public void motorOlustur(int id, int beygir,int hacmi,YakıtTürü yakit,string üretici)
        {
            motorEylemleri.motorOlustur(id,beygir, hacmi, yakit, üretici);

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
