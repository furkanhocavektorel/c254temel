namespace OOPMid.model
{
    internal class Tasit
    {
        public int Id { get; set; }

        public string Marka { get; set; }
        public string Model { get; set; }

        public string Renk { get; set; }

        public List<Motor> Motor { get; set; }



    }
}
