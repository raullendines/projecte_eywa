﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecte_eywa
{
    public class UserAndroid
    {
        public string username { get; set; }
        public string password { get; set; }
        public string image { get; set; }
        public string gender { get; set; }
        public int age { get; set; }

        public UserAndroid(string username, string password, string image, string gender, int age)
        {
            this.username = username;
            this.password = password;
            this.image = image;
            this.gender = gender;
            this.age = age;

        }
    }
}
