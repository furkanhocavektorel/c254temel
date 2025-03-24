

using OOPMid.eylemler;
using OOPMid.model.enums;

namespace OOPMid.controller
{
    internal class MotorController
    {


        public void motorOlustur(int id, int beygir,int hacmi,YakıtTürü yakit,string üretici)
        {
            MotorEylemleri motorEylemleri = new MotorEylemleri();
            motorEylemleri.motorOlustur(id,beygir, hacmi, yakit, üretici);

        }


    }
}
