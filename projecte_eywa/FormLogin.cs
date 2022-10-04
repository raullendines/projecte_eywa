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
using Newtonsoft.Json.Linq;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace projecte_eywa
{
    public partial class FormLogin : Form
    {

        BindingList<UserDesktop> UsersList = new BindingList<UserDesktop>();
        const string auth = "EYWA";
        const string PATH = @"..\..\json\";
        const string USERS_PATH = PATH + "users_desktop.json";
        string formType = "login";


        public FormLogin()
        {
            InitializeComponent();

        }

        private void getData()
        {
            JArray LoadUsers = JArray.Parse(File.ReadAllText(USERS_PATH, Encoding.Default));
            UsersList = LoadUsers.ToObject<BindingList<UserDesktop>>();
        }

        private void saveData()
        {
            JArray UsersArray = (JArray)JToken.FromObject(UsersList);
            File.WriteAllText(USERS_PATH, UsersArray.ToString());
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(formType.Equals("login"))
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
            else
            {
                //NEW ACCOUNT
                if (checkCorrectNewUser())
                {

                }
            }

            

        }

        private bool checkCorrectUser()
        { 
        
            foreach (UserDesktop user in UsersList)
            {
                string decrypted = EncryptTest.Decrypt(user.password, auth);
                if(user.username.Equals(textBoxUser.Text) && decrypted.Equals(textBoxPassword.Text))
                {
                    return true;
                }
            }
            return false;

        }

        private bool checkCorrectNewUser()
        {
            if (string.IsNullOrEmpty(textBoxUser.Text))
            {
                MessageBox.Show("You must enter a valid username");
                return false;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("You must enter a password");
                return false;
            }

            if (textBoxPassword.Text.Equals(textBoxConfirmPassword.Text))
            {
                foreach(UserDesktop user in UsersList)
                {
                    if (user.username.Equals(textBoxUser))
                    {
                        MessageBox.Show("This username already exist");
                        return false;
                    }
                }
                string username = textBoxUser.Text;
                string passwordEncrypted = EncryptTest.Encrypt(textBoxPassword.Text, auth);
                UsersList.Add(new UserDesktop(username, passwordEncrypted, "user"));
                MessageBox.Show("New user created!");
                changeLoginRegister();
                return true;
            }
            else
            {
                MessageBox.Show("Confirm the password correctly");
                return false;
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar.Equals('*'))
            {
                textBoxPassword.PasswordChar = textBoxUser.PasswordChar;
                buttonVisibility.Image = global::projecte_eywa.Properties.Resources.visibility_off_FILL0_wght400_GRAD0_opsz48;

            }
            else
            {
                textBoxPassword.PasswordChar = '*';
                buttonVisibility.Image = global::projecte_eywa.Properties.Resources.visibility_FILL0_wght400_GRAD0_opsz48;
            }
            
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            changeLoginRegister();
        }

        private void changeLoginRegister()
        {
            if (formType.Equals("login"))
            {
                buttonLogin.Text = "Register";
                buttonRegister.Text = "Log in with my account";
                labelConfirmPassword.Visible = true;
                textBoxConfirmPassword.Visible = true;
                formType = "register";
            }
            else
            {
                buttonLogin.Text = "Log in";
                buttonRegister.Text = "New account";
                labelConfirmPassword.Visible = false;
                textBoxConfirmPassword.Visible = false;
                formType = "login";
            }
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to save USER_DESKTOP.JSON", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                saveData();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
