using OOPMid.controller;
using OOPMid.model;
using OOPMid.model.enums;

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
            motorController.motorOlustur(1,564, 2300, YakıtTürü.Benzin, "ferrari");
            motorController.motorOlustur(2,564, 2300, YakıtTürü.Benzin, "bmw");
            motorController.motorOlustur(3, 322, 2500, YakıtTürü.Benzin, "vw");
            motorController.motorOlustur(4, 654, 2999, YakıtTürü.Benzin, "skoda");
            motorController.motorOlustur(5, 123, 1456, YakıtTürü.Benzin, "vw");


            List<Motor> list = motorController.motorGetirUreticiyeGore("vw");

            for (int i = 0;i <list.Count ; i++) {

                Console.WriteLine(list[i]);
    
            }

            // TODO 500 beygir yukarısını getir
            // TODO idsi verilen motoru sil
            // TODO idsi verilen motorun üreticisini güncelle







        }



    }
}
