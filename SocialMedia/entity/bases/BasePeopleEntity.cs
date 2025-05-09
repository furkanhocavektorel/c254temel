﻿namespace SocialMedia.entity.bases
{
    internal class BasePeopleEntity : BaseLongEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, Username: {Username}";
        }
    }
}
