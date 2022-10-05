using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecte_eywa
{
    public class User
    {

        public string username { get; set; }
        public string password { get; set; }
        public string type { get; set; }
        public string device { get; set; }
        public string image { get; set; }
        public string gender { get; set; }
        public int age { get; set; }

        public User(string username, string password, string type, string device, string image, string gender, int age)
        {
            this.username = username;
            this.password = password;
            this.type = type;  
            this.device = device;
            this.image = image;
            this.gender = gender;
            this.age = age;

        }

        public User()
        {
             
        }
    }
}
