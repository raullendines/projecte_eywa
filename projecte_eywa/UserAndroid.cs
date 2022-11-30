using System;
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
        public string dateOfRegister { get; set; }
        public List<int> quizAchievementList { get; set; }
        public string image { get; set; }

        public UserAndroid(string username, string password, string image, string dateOfRegister, List<int> quizAchievementList)
        {
            this.username = username;
            this.password = password;
            this.image = image;
            this.dateOfRegister = dateOfRegister;
            this.quizAchievementList = quizAchievementList;
        }

        public UserAndroid()
        {

        }
    }
}
