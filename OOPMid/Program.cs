using OOPMid.eylemler;
using OOPMid.model;
using OOPMid.model.enums;

namespace OOPMid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MotorEylemleri motorEylemleri = new MotorEylemleri();

            motorEylemleri.motorOlustur(23, 23, YakıtTürü.DIZEL, "asd");
            motorEylemleri.motorOlustur(33,655, YakıtTürü.DIZEL, "xxxasd");

            motorEylemleri.ekranaBas();
          



        }


       


    }
}
