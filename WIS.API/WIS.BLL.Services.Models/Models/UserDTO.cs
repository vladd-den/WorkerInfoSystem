﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIS.BLL.Services.Models.Models
{
    public class UserDTO
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
