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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Runtime.InteropServices.ComTypes;


namespace projecte_eywa
{
    public partial class FormLogin : Form
    {

        List<UserDesktop> UsersList = new List<UserDesktop>();
        UserDesktop user;
        const string auth = "EYWA";
        const string PATH = @"..\..\json\";
        const string USERS_PATH = PATH + "users_desktop.json";
        string formType = "login";
        Point labelTextPosition;
        Point labelClickablePosition;
        

        public FormLogin()
        {
            InitializeComponent();
            labelTextPosition = labelChangeFormsText.Location;
            labelClickablePosition = labelChangeForms.Location;

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
            if (formType.Equals("login"))
            {

                if (checkCorrectUser())
                {
                    Menu myNextForm = new Menu(user);
                    Program.changingForms = true;
                    myNextForm.Show();
                    this.Close();
                    Program.changingForms = false;
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

        private void changeLoginRegister()
        {
            int loginX = 1130;
            int increment = 50;
            int loginY = 667;

            if (formType.Equals("login"))
            {
                buttonLogin.Text = "Register";
                labelChangeFormsText.Text = "You have an account?";
                labelChangeForms.Text = "Login";
                labelConfirmPassword.Visible = true;
                textBoxConfirmPassword.Visible = true;
                formType = "register";
                buttonLogin.Location = new Point(loginX, loginY + increment);
                labelChangeForms.Location = new Point(loginX - 120, loginY + increment + 7);
                labelChangeFormsText.Location = new Point(loginX - 298, loginY + increment + 7);

            }
            else
            {
                buttonLogin.Text = "Log in";
                labelChangeFormsText.Text = "New here?";
                labelChangeForms.Text = "Create an account";
                labelConfirmPassword.Visible = false;
                textBoxConfirmPassword.Visible = false;
                formType = "login";
                buttonLogin.Location = new Point(loginX, loginY);
                labelChangeForms.Location = labelClickablePosition;
                labelChangeFormsText.Location = labelTextPosition;
            }
        }

        private bool checkCorrectUser()
        {

            foreach (UserDesktop user in UsersList)
            {
                if (user.username.Equals(textBoxUser.Text) && BCrypt.Net.BCrypt.EnhancedVerify(textBoxPassword.Text, user.password))
                {
                    this.user = user;
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

        private void buttonVisiblity_Click(object sender, EventArgs e)
        {
            buttonVisibility.TabStop = false;
            if (textBoxPassword.PasswordChar.Equals('*'))
            {
                textBoxPassword.PasswordChar = textBoxUser.PasswordChar;
                buttonVisibility.Image = global::projecte_eywa.Properties.Resources.visibility_off;

            }
            else
            {
                textBoxPassword.PasswordChar = '*';
                buttonVisibility.Image = global::projecte_eywa.Properties.Resources.visibility_on;
            }

        }


        private void FormLogin_Load(object sender, EventArgs e)
        {
            getData();
            paintComponents();
        }

        private void paintComponents()
        {
            //61, 0, 102 maincolor
            //238, 199, 252 3th color
            this.BackColor = Color.FromArgb(255, 177, 212, 224);

            labelUser.BackColor = Color.Transparent;
            labelUser.ForeColor = Color.FromArgb(255, 61, 0, 102);

            labelPassword.BackColor = Color.Transparent;
            labelPassword.ForeColor = Color.FromArgb(255, 61, 0, 102);

            textBoxPassword.ForeColor = Color.FromArgb(255, 61, 0, 102);

            textBoxUser.ForeColor = Color.FromArgb(255, 61, 0, 102);

            buttonLogin.BackColor = Color.FromArgb(255, 255, 224, 71);
            buttonLogin.ForeColor = Color.FromArgb(255, 0, 0, 0);

            buttonVisibility.BackColor = Color.White;

            textBoxConfirmPassword.ForeColor = Color.FromArgb(255, 61, 0, 102);

            labelConfirmPassword.BackColor = Color.Transparent;
            labelConfirmPassword.ForeColor = Color.FromArgb(255, 61, 0, 102);

            buttonVisibility.FlatAppearance.MouseOverBackColor = buttonVisibility.BackColor;
            buttonVisibility.BackColorChanged += (s, e) =>
            {
                buttonVisibility.FlatAppearance.MouseOverBackColor = buttonVisibility.BackColor;
            };


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

        private void labelChangeForms_Click(object sender, EventArgs e)
        {
            changeLoginRegister();
        }


        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Program.changingForms)
            {
                Application.Exit();
            }
        }

        

    }
}