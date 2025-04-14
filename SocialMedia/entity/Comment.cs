
using SocialMedia.entity.bases;

namespace SocialMedia.entity
{
    class Comment : BaseLongEntity
    {
        public string Content { get; set; }
        public DateTime CreateAt { get; set; }

        public Customer Customer { get; set; }

        public Post PostId { get; set; }

    }
}
