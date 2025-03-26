namespace OOPMid.model
{
    internal class Otomobil : Tasit
    {

        public int TekerSayisi { get; set; }

        public bool OtomatikMi { get; set; }

        public string KasaTipi { get; set; }



        public override string? ToString()
        {
            string bilgi = "marka: " + Marka + ", model: " + Model + ", renk: " + Renk + ", teker sayisi: " + TekerSayisi + ", otomatik mi? " + OtomatikMi + ", kasa tipi: " + KasaTipi + ", motor bilgileri -> " ;
            for (int i = 0; i<Motor.Count;i++ )
            {
                bilgi += Motor[i].ToString();
            }

            return bilgi;
        }



        public override void test()
        {
            Console.WriteLine("otomobil classında ki test metodu calisti");
        }


    }
}
