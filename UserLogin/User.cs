﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class User
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public String FacNum { get; set; }
        public UserRoles Role { get; set; }

        public DateTime Created;
        public User()
        {

        }


    }
}
