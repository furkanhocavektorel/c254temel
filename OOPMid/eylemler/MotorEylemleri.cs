
using OOPMid.model;
using OOPMid.model.enums;

namespace OOPMid.eylemler
{
    internal class MotorEylemleri
    {
       
        public Motor motorOlustur(int beygir,int motorHacmi,YakıtTürü yakit,string üretici)
        {
            Motor motor = new Motor();
            motor.Beygir = beygir;
            motor.Uretici = üretici;
            motor.Yakıt=yakit;
            motor.MotorHacmi = motorHacmi;

            Listeler.motorList.Add(motor);


            return motor;
        }


        public void ekranaBas()
        {
            for (int i = 0; i < Listeler.motorList.Count; i++)
            {

                Console.WriteLine(Listeler.motorList[i].Uretici);
                Console.WriteLine(Listeler.motorList[i].MotorHacmi);
                Console.WriteLine(Listeler.motorList[i].Beygir);
                Console.WriteLine(Listeler.motorList[i].Yakıt);
                Console.WriteLine("**********");

            }


        }




    }
}
