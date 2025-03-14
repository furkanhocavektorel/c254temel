namespace OOPMid
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Motor motor = new Motor();

            motor.MotorHacmi = 1990;
            motor.Yakıt = YakıtTürü.Benzin;
            motor.Beygir = 180;
            motor.Uretici = "bmw";


            Otomobil otomobil = new Otomobil();
            otomobil.Marka = "bmw";
            otomobil.Model = "3.20 ci";
            otomobil.Motor = motor;
            otomobil.Renk = "gri";
            otomobil.OtomatikMi = false;


            Otomobil otomobil1 = new Otomobil();
            otomobil1.Marka = "mercedes";
            otomobil1.Model = "g 500";
            otomobil1.Motor = motor;
            otomobil1.Renk = "siyah";
            otomobil1.OtomatikMi = true;


            OtomobilEylemleri otomobilEylemleri= new OtomobilEylemleri(otomobil);

            otomobilEylemleri.hareketEt();



        }

    }
}
