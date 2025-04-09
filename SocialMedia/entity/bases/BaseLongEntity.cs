namespace SocialMedia.entity.bases
{
    internal class BaseLongEntity
    {
        public long Id { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}";
        }
    }
}
