namespace OOPMid.model
{
 
    internal class DenizAraclari : Tasit
    {

        public int Boy { get; set; }

        public int En { get; set; }

        public string GovdeMalzemesi { get; set; }

        public override void test()
        {
            Console.WriteLine("deniz araclarinda ki test metodu calisti");
        }


    }
}
