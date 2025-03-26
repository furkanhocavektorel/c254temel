using OOPMid.controller;
using OOPMid.eylemler;
using OOPMid.model;
using OOPMid.model.enums;
using OOPMid.util;

namespace OOPMid
{
    // FRONT-END SIM
    internal class Program
    {
        /*
        OOP PRENSIP
        1_ encapsulation - kapsülleme - get set
        2_ Inheritence - kalıtım - extend
        3_ polimorphizm - çok biçimlilik - virtual-ovverride
        4_ abstract - soyutlama 

         */
        static void Main(string[] args)
        {
            MotorController motorController = new MotorController();
            


            motorController.motorOlustur(564, 2300, YakıtTürü.Benzin, "ferrari");
            motorController.motorOlustur(564, 2300, YakıtTürü.Benzin, "bmw");
            motorController.motorOlustur( 322, 2500, YakıtTürü.Benzin, "vw");
            motorController.motorOlustur( 654, 2999, YakıtTürü.Benzin, "skoda");
            motorController.motorOlustur( 123, 1456, YakıtTürü.Benzin, "vw");





            Motor motor=motorController.motorOlustur( 564, 2300, YakıtTürü.Benzin, "ferrari");





            if (motor.Id == null) {

                Console.WriteLine(motor.ToString()+" bu özellikteki motoru ekleme başarisiz");
            
            }





        }



    }
}
