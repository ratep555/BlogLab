﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab.Models.Account
{
    // this one is for identity
    // this is the one that matches our table
    public class ApplicationUserIdentity
    {
        public int ApplicationUserId { get; set; }

        public string Username { get; set; }

        public string NormalizedUsername { get; set; }

        public string Email { get; set; }

        public string NormalizedEmail { get; set; }

        public string Fullname { get; set; }

        public string PasswordHash { get; set; }
    }
}
