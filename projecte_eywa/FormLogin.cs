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
using Application = System.Windows.Forms.Application;
using System.Runtime.InteropServices.ComTypes;

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
            string testPassword = "p";
            string passwordEncrypted = EncryptTest.Encrypt(testPassword, auth);
            UsersList.Add(new User("p", passwordEncrypted, "Admin", "Desktop", "", "Male", 20));


        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {


            if (checkCorrectUser())
            {
                var myNextForm = new FormQuestions();
                myNextForm.Show();
                this.Hide();
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

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
