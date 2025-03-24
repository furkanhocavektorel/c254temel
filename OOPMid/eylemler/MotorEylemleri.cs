
using OOPMid.model;
using OOPMid.model.enums;

namespace OOPMid.eylemler
{
    internal class MotorEylemleri
    {

        Listeler listeler = new Listeler();

        public Motor motorOlustur(int id,int beygir,int motorHacmi,YakıtTürü yakit,string üretici)
        {
            Motor motor = new Motor();
            motor.Beygir = beygir;
            motor.Uretici = üretici;
            motor.Yakıt=yakit;
            motor.MotorHacmi = motorHacmi;
            motor.Id = id;

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










    }
}
