﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DataTransferObj.Users
{
    public class UserDto
    {
        public  string? UserName { get; set; }
        public  string? Email { get; set; }
        public  string? PhoneNumber { get; set; }
        public  string? PasswordHash { get; set; }
        public  bool LockoutEnabled { get; set; }
    }
}
