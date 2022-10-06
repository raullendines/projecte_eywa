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
using Application = System.Windows.Forms.Application;

namespace projecte_eywa
{
    public partial class FormLogin : Form
    {

        List<UserDesktop> UsersList = new List<UserDesktop>();
        UserDesktop actualUser;
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
            UsersList = LoadUsers.ToObject<List<UserDesktop>>();
            //UsersList.Add(new UserDesktop("Marcel", BCrypt.Net.BCrypt.EnhancedHashPassword("marcel1234"), "admin"));
            //UsersList.Add(new UserDesktop("Pau", BCrypt.Net.BCrypt.EnhancedHashPassword("pau1234"), "admin"));
            //UsersList.Add(new UserDesktop("Raul", BCrypt.Net.BCrypt.EnhancedHashPassword("raul1234"), "admin"));
            //UsersList.Add(new UserDesktop("Test", BCrypt.Net.BCrypt.EnhancedHashPassword("test"), "user"));
            //saveData();
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
                    FormUsers formUser = new FormUsers(UsersList, actualUser);
                    formUser.Show();
                    this.Close();
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
                    string username = textBoxUser.Text;
                    string passwordEncrypted = BCrypt.Net.BCrypt.EnhancedHashPassword(textBoxPassword.Text);
                    UsersList.Add(new UserDesktop(username, passwordEncrypted, "user"));
                    MessageBox.Show("New user created!");
                    changeLoginRegister();
                    clearTextBox();
                    saveData();
                }
            }

            

        }

        private bool checkCorrectUser()
        { 
        
            foreach (UserDesktop user in UsersList)
            {
                if(user.username.Equals(textBoxUser.Text) && BCrypt.Net.BCrypt.EnhancedVerify(textBoxPassword.Text, user.password))
                {
                    actualUser = user;
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

            if (!textBoxPassword.Text.Equals(textBoxConfirmPassword.Text))
            {
                MessageBox.Show("Confirm the password correctly");
                return false;
            }
            
            foreach (UserDesktop user in UsersList)
            {
                if (user.username.Equals(textBoxUser))
                {
                    MessageBox.Show("This username already exist");
                    return false;
                }
            }

            return true;
           
        }

        private void clearTextBox()
        {
            textBoxConfirmPassword.Text = "";
            textBoxPassword.Text = "";
            textBoxUser.Text = "";
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
            paintComponents();
        }

        private void paintComponents()
        {
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            //61, 0, 102 maincolor
            //238, 199, 252 3th color
            this.BackColor = Color.FromArgb(255, 61, 0, 102);
            panelLogin.BackColor = Color.FromArgb(240, 255, 255, 255);

            labelUser.BackColor = Color.Transparent;
            labelUser.ForeColor = Color.FromArgb(255, 61, 0, 102);

            labelPassword.BackColor = Color.Transparent;
            labelPassword.ForeColor = Color.FromArgb(255, 61, 0, 102);

            textBoxPassword.ForeColor = Color.FromArgb(255, 61, 0, 102);

            textBoxUser.ForeColor = Color.FromArgb(255, 61, 0, 102);

            buttonLogin.BackColor = Color.FromArgb(220, 61, 0, 102);
            buttonLogin.ForeColor = Color.FromArgb(255, 255, 255, 255);

            buttonRegister.BackColor = Color.FromArgb(255, 255, 255, 255);
            buttonRegister.ForeColor = Color.FromArgb(255, 61, 0, 102);

            buttonVisibility.BackColor = Color.Transparent;

            textBoxConfirmPassword.ForeColor = Color.FromArgb(255, 61, 0, 102);

            labelConfirmPassword.BackColor = Color.Transparent;
            labelConfirmPassword.ForeColor = Color.FromArgb(255, 61, 0, 102);

    }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Do you want to save USER_DESKTOP.JSON", "Exit", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    //do something
            //    saveData();
            //}
            //else if (dialogResult == DialogResult.No)
            //{

            //}
        }

        private void textBoxUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                buttonLogin_Click(sender, e);

            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                buttonLogin_Click(sender, e);

            }
        }

        private void textBoxConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                buttonLogin_Click(sender, e);

            }
        }
    }

}
