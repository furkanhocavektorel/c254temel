using SocialMedia.entity.bases;

namespace SocialMedia.entity
{
    internal class Customer : BasePeopleEntity
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            // Calling base class ToString for common properties
            return base.ToString() + $", Email: {Email}, Phone: {Phone}, Age: {Age}";
        }
    }
}
