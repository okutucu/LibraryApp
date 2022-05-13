﻿using LibraryApp.Enums;

namespace LibraryApp.Models
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }
    }
}
