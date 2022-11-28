using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecte_eywa
{
    public partial class Menu : Form
    {
        UserDesktop user;

        public Menu(UserDesktop user)
        {
            InitializeComponent();
            this.user = user;
            this.labelWelcome.Text = "Welcome, " + user.username;

        }

        private void userType(UserDesktop user)
        {
            switch (user.type)
            {
                case "user":
                    buttonUsersIcon.Visible = false;
                    buttonQuestionsIcon.Location = new Point(1010, 339);
                    labelQuestions.Location = new Point(1095, 625);
                    buttonCharactersIcon.Location = new Point(686, 339);
                    labelCharacters.Location = new Point(760, 625);
                    labelUsers.Visible = false;
                    break;
                case "admin":
                    buttonUsersIcon.Visible = false;
                    labelUsers.Visible = false;
                    buttonQuestionsIcon.Location = new Point(1010, 339);
                    labelQuestions.Location = new Point(1095, 625);
                    buttonCharactersIcon.Location = new Point(686, 339);
                    labelCharacters.Location = new Point(760, 625);
                    break;
                default:

                    break;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            userType(user);
        }

        private void buttonCharactersIcon_Click(object sender, EventArgs e)
        {
            FormCharacters formCharacters = new FormCharacters(user);
            formCharacters.Show();
            Program.changingForms = true;
            this.Close();
            Program.changingForms = false;
        }  
        private void buttonQuestionsIcon_Click(object sender, EventArgs e)
        {
            FormQuestions formQuestions = new FormQuestions(user);
            formQuestions.Show();
            Program.changingForms = true;
            this.Close();
            Program.changingForms = false;

        }
        private void buttonUsersIcon_Click(object sender, EventArgs e)
        {
            FormUsers formUsers = new FormUsers(user);
            formUsers.Show();
            Program.changingForms = true;
            this.Close();
            Program.changingForms = false;
        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                FormLogin formLogin = new FormLogin();
                Program.changingForms = true;
                this.Close();
                Program.changingForms = false;
                formLogin.Show();
            }
        }
    }
}
