using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibraryCore
{
    public enum UserRole
    {
        Member,
        Administrator
    }

    public class User : BaseObject
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }
}
