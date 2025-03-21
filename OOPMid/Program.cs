using OOPMid.controller;
using OOPMid.eylemler;
using OOPMid.model;
using OOPMid.model.enums;

namespace OOPMid
{
    // FRONT-END SIM
    internal class Program
    {
        static void Main(string[] args)
        {
            MotorController motorController = new MotorController();
            motorController.motorOlustur(564, 2300, YakıtTürü.Benzin, "ferrari");
           
        

        }



    }
}
