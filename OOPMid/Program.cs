using OOPMid.controller;
using OOPMid.model.enums;

namespace OOPMid
{
    // FRONT-END SIM
    internal class Program
    {
        static void Main(string[] args)
        {
            MotorController motorController = new MotorController();
            motorController.motorOlustur(1,564, 2300, YakıtTürü.Benzin, "ferrari");
            motorController.motorOlustur(2,564, 2300, YakıtTürü.Benzin, "ferrari");

            for (int i=0; 0 < Listeler.motorList.Count ;i++)
            {
                Console.WriteLine(Listeler.motorList[i].ToString());
            }


        }



    }
}
