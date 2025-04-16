
using SocialMedia.entity.bases;

namespace SocialMedia.entity
{
    class Comment : BaseLongEntity
    {
        public string Content { get; set; }
        public DateTime CreateAt { get; set; }

        public Customer Customer { get; set; }

        public Post Post { get; set; }

        public Comment()
        {
            CreateAt = DateTime.Now;
        }

        public override string ToString()
        {
            return "post Id: "+Post.Id+", yorum:"+Content;
        }


    }
}
