using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecte_eywa
{
    public class UserDesktop
    {

        public string username { get; set; }
        public string password { get; set; }
        public string type { get; set; }

        public UserDesktop(string username, string password, string type)
        {
            this.username = username;
            this.password = password;
            this.type = type;  

        }

        public bool Equals (UserDesktop otherUser)
        {
            return this.username == otherUser.username && this.password == otherUser.password && this.type == otherUser.type;
        }

    }
}
