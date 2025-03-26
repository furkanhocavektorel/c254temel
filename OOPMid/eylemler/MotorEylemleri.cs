
using OOPMid.model;
using OOPMid.model.enums;
using OOPMid.util;

namespace OOPMid.eylemler
{
    internal class MotorEylemleri : ITasitEylemleri
    {

        Listeler listeler;

        GenerateId generateId;

        // OVERLOAD
        public MotorEylemleri(Listeler listeler,GenerateId generateId) {

            this.listeler = listeler;

            this.generateId = generateId;

        }

        public MotorEylemleri(Listeler listeler)
        {
            this.listeler = listeler;
        }





        public Motor motorOlustur(int beygir,int motorHacmi,YakıtTürü yakit,string üretici)
        {
            Motor motor = new Motor();
            motor.Beygir = beygir;
            motor.Uretici = üretici;
            motor.Yakıt=yakit;
            motor.MotorHacmi = motorHacmi;

            List<Motor> motorList = listeler.motorListesiGetir();

            for(int i = 0; i < motorList.Count; i++)
            {
                if (motor.Beygir == motorList[i].Beygir 
                    && motor.MotorHacmi == motorList[i].MotorHacmi
                    && motor.Yakıt.Equals(motorList[i].Yakıt)
                    && motor.Uretici.Equals(motorList[i].Uretici))
                {
                    motor.Id = null;
                    return motor;
                }

            }
            motor.Id = generateId.generateMotorId();

            listeler.motorEkle(motor);

            return motor;
        }

        public Motor motorGetir(int fgfıusayhcewy)
        {

            List<Motor> motorlist = listeler.motorListesiGetir();

            for(int i=0;i<motorlist.Count;i++)
            {

                if (motorlist[i].Id== fgfıusayhcewy)
                {
                    return motorlist[i];
                }
            }
            return null;   
        }

        public List<Motor> motorGetirUreticiyeGore(string uretici)
        {
            List<Motor> motorListesi = listeler.motorListesiGetir();

            List<Motor> motors = new List<Motor>();

            for (int i = 0; i < motorListesi.Count; i++)
            {
                if (motorListesi[i].Uretici.Equals(uretici))
                {
                    motors.Add(motorListesi[i]);
                }

            }

            return motors;

        }

        public void kaydet(string marka, string model)
        {
        }



    }
}
