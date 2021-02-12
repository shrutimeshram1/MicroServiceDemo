﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Database
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
