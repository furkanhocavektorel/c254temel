using OOPMid.model.enums;

namespace OOPMid.model
{
    internal class Motor
    {
        public int? Id { get; set; }
        public int Beygir { get; set; }
        public int MotorHacmi { get; set; }
        public YakıtTürü Yakıt { get; set; }

        public string Uretici { get; set; }



        public override string? ToString()
        {
            string bilgi = "id: "+Id+ "beygir: " + Beygir + ", motor hacmi: " + MotorHacmi + ", yakit: " + Yakıt + ", üretici:" + Uretici;
            return bilgi;
        
        }


    }
}
