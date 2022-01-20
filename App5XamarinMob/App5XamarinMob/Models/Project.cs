﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App5XamarinMob.Models
{
    public class Project
    {
        public Project(string name, string description, string telephoneNumber1, string telephoneNumber2, string email, string address)
        {
            Name = name;
            Description = description;
            TelephoneNumber1 = telephoneNumber1;
            TelephoneNumber2 = telephoneNumber2;
            Email = email;
            Address = address;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string TelephoneNumber1 { get; set; }
        public string TelephoneNumber2 { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
