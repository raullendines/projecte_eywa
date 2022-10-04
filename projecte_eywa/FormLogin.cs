using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace projecte_eywa
{
    public partial class FormLogin : Form
    {

        List<User> UsersList = new List<User>();
        const string auth = "EYWA";


        public FormLogin()
        {
            InitializeComponent();
            getData();

        }

        private void getData()
        {
            string testPassword = "password12345";
            string passwordEncrypted = EncryptTest.Encrypt(testPassword, auth);
            UsersList.Add(new User("Marcel", passwordEncrypted, "Admin", "Desktop", "", "Male", 20));


        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {


            if (checkCorrectUser())
            {
                
                MessageBox.Show("LOGGED");
            }
            else
            {
                MessageBox.Show("ERROR");
            }

        }

        private bool checkCorrectUser()
        { 
        
            foreach (User user in UsersList)
            {
                string decrypted = EncryptTest.Decrypt(user.password, auth);
                if(user.username.Equals(textBoxUser.Text) && decrypted.Equals(textBoxPassword.Text))
                {
                    return true;
                }
            }
            return false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar.Equals('*'))
            {
                textBoxPassword.PasswordChar = textBoxUser.PasswordChar;

            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
            
        }
    }
}
