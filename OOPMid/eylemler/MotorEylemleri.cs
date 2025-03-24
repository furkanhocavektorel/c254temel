
using OOPMid.model;
using OOPMid.model.enums;

namespace OOPMid.eylemler
{
    internal class MotorEylemleri
    {
       
        public Motor motorOlustur(int id,int beygir,int motorHacmi,YakıtTürü yakit,string üretici)
        {
            Motor motor = new Motor();
            motor.Beygir = beygir;
            motor.Uretici = üretici;
            motor.Yakıt=yakit;
            motor.MotorHacmi = motorHacmi;
            motor.Id = id;
            Listeler.motorList.Add(motor);


            return motor;
        }

        // TODO Index'e göre arama yapılamaz
        // ID ye göre arama yapılmalı.
        public Motor motorGetir(int index)
        {
            Motor m = Listeler.motorList[index];
            return m;
        }


    }
}
