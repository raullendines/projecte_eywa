using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using File = System.IO.File;

namespace projecte_eywa
{
    public partial class FormUsers : Form
    {
        Image FileImage;
        List<UserDesktop> DesktopList;
        List<UserAndroid> AndroidList = new List<UserAndroid>();
        UserDesktop user;

        string path;
        const string PATH = @"..\..\json\";
        const string USERS_DESKTOP_PATH = PATH + "users_desktop.json";
        const string USERS_ANDROID_PATH = PATH + "users_android.json";

        bool AddUser = false;
        int index = -1;

        bool DesktopForm = true;
        bool AndroidForm = false;

        bool changes = false;
        


        
        public FormUsers(UserDesktop user)
        {
            this.user = user;
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            loadData();
            labelActualUserData.Text = user.username.ToString() + " " + user.type.ToString();
        }

        private void loadData()
        {
            
            JArray LoadDesktopUsers = JArray.Parse(File.ReadAllText(USERS_DESKTOP_PATH, Encoding.Default));
            DesktopList = LoadDesktopUsers.ToObject<List<UserDesktop>>();
            JArray LoadAndroidUsers = JArray.Parse(File.ReadAllText(USERS_ANDROID_PATH, Encoding.Default));
            AndroidList = LoadAndroidUsers.ToObject<List<UserAndroid>>();

            userDesktopBindingSource.DataSource = DataUtilities.ToDataTable(DesktopList);

            dataGridViewUsers.DataSource = userDesktopBindingSource;


        }

        private void radioButtonDesktop_CheckedChanged(object sender, EventArgs e)
        {
            if (DesktopForm)
            {
                userDesktopBindingSource.DataSource = DataUtilities.ToDataTable(DesktopList);
                dataGridViewUsers.DataSource = null;
                dataGridViewUsers.DataSource = userDesktopBindingSource;
                type.Visible = true;
                image.Visible = false;

                
                labelType.Visible = true;
                comboBoxType.Visible = true;


                labelImage.Visible = false;
                textBoxImage.Visible = false;
                labelDate.Visible = false;
                textBoxDate.Visible = false;
                labelDateRegister.Visible = false;

            }
        }

        private void radioButtonAndroid_CheckedChanged(object sender, EventArgs e)
        {
            if (AndroidForm)
            {
                userAndroidBindingSource.DataSource = DataUtilities.ToDataTable(AndroidList);
                dataGridViewUsers.DataSource = null;
                dataGridViewUsers.DataSource = userAndroidBindingSource;
                type.Visible = false;
                image.Visible = true;


                labelType.Visible = false;
                comboBoxType.Visible = false;

                labelImage.Visible = true;
                textBoxImage.Visible = true;
                labelDate.Visible = true;
                textBoxDate.Visible = true;
                labelDateRegister.Visible = true;
            }
        }

        private void loadDataToTextBox()
        {
            
            index = dataGridViewUsers.CurrentCell.RowIndex;
            if (DesktopForm)
            {
                if (index < DesktopList.Count())
                {
                    textBoxUsername.Text = DesktopList[index].username.ToString();
                    textBoxPassword.Text = DesktopList[index].password.ToString();
                    comboBoxType.Text = DesktopList[index].type.ToString();
                }
            }
            else
            {
                if (index < AndroidList.Count())
                {
                    textBoxUsername.Text = AndroidList[index].username.ToString();
                    textBoxPassword.Text = AndroidList[index].password.ToString();
                    textBoxImage.Text = AndroidList[index].image.ToString();
                 
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
           
            AddUser = true;
            enableTextBox();
            textBoxPassword.Visible = true;
            labelPassword.Visible = true;
            locationImages();
            if (pictureBoxCharacters.Image != null)
            {
                pictureBoxCharacters.Image.Dispose();
            }
            textBoxPassword.ReadOnly = false;
            clearTextBox();
            disableButtons();
            var dateTime = DateTime.Now;
            var dateValue = dateTime.ToString("dd/MM/yyyy");
            textBoxDate.Text = dateValue;

        }
        private void locationImages()
        {
            if (!DesktopForm)
            {
                labelPassword.Location = new Point(32, 179);
                textBoxPassword.Location = new Point(237, 179);
                if (AddUser == true)
                {
                    labelImageCharacter.Location = new Point(32, 232);
                    pictureBoxCharacters.Location = new Point(237, 232);
                }
                else
                {
                    labelImageCharacter.Location = new Point(32, 179);
                    pictureBoxCharacters.Location = new Point(237, 179);
                }
            }
            else
            {
                labelPassword.Location = new Point(32, 131);
                textBoxPassword.Location = new Point(237, 128);
            }
           
            
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if(index != -1)
            {
                locationImages();
                loadDataToTextBox();
                enableTextBox();
                disableButtons();
            }
            else
            {
                MessageBox.Show("Please, select an user first");
            }
            
        }

        private void clearTextBox()
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            
            if (DesktopForm)
            {
                comboBoxType.SelectedIndex = 0;
            }
            else
            {
                textBoxImage.Text = "";
                textBoxDate.Text = "";

                if (pictureBoxCharacters.Image != null)
                {
                    pictureBoxCharacters.Image.Dispose();
                    pictureBoxCharacters.Image = null;
                }
            }
        }

        private void enableTextBox()
        {
            buttonBuscar.Enabled = true;
            textBoxUsername.ReadOnly = false;
            buttonSave.Visible = true;
            buttonCancel.Visible = true;
            if (DesktopForm)
            {
                comboBoxType.Enabled = true;
            }
            else
            {
                buttonBuscar.Visible = true;
            }
        }

        private void disableTextBox()
        {
            buttonBuscar.Enabled = false;
            textBoxUsername.ReadOnly = true;
            textBoxPassword.ReadOnly = true;
            buttonSave.Visible = false;
            buttonCancel.Visible = false;
            if (DesktopForm)
            {
                comboBoxType.Enabled = false;

            }
            else
            {
                buttonBuscar.Visible = false;
                textBoxDate.ReadOnly = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            AddUser = false;
            clearTextBox();
            disableTextBox();
            enableButtons();
            dataGridViewUsers.Enabled = true;
            textBoxPassword.Visible = false;
            labelPassword.Visible = false;
        }

        private void disableButtons()
        {
            dataGridViewUsers.Enabled = false;
            buttonAdd.Enabled = false;
            buttonModify.Enabled = false;
            buttonAndroid.Enabled = false;
            buttonDesktop.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void enableButtons()
        {
            dataGridViewUsers.Enabled = true;
            buttonAdd.Enabled = true;
            buttonModify.Enabled = true;
            buttonAndroid.Enabled = true;
            buttonDesktop.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (DesktopForm)
            {
                if (checkValues())
                {
                    addNewDesktopUser();
                    AddUser = false;
                    buttonSave.Visible = false;
                    buttonCancel.Visible = false;
                    clearTextBox();
                    disableTextBox();
                    enableButtons();
                    changes = true;
                }
            }
            else
            {
                if (checkValues())
                {
                    string name = Path.GetFileNameWithoutExtension(path);
                    if (!File.Exists(path))
                    {
                        File.Copy(path, @"..\..\Resources\characters\" + name + ".jpeg");
                    }
                    addNewAndroidUser();
                    AddUser = false;
                    buttonSave.Visible = false;
                    buttonCancel.Visible = false;
                    clearTextBox();
                    disableTextBox();
                    enableButtons();
                    changes = true;
                }
            }
            textBoxPassword.Visible = false;
            labelPassword.Visible = false;
        }

        private void addNewDesktopUser()
        {
            if (AddUser)
            {
                string username = textBoxUsername.Text;
                string password = BCrypt.Net.BCrypt.EnhancedHashPassword(textBoxPassword.Text);
                string type = comboBoxType.Text.ToLower();
                DesktopList.Add(new UserDesktop(username, password, type));

                userDesktopBindingSource.DataSource = DataUtilities.ToDataTable(DesktopList);
                dataGridViewUsers.DataSource = userDesktopBindingSource;

            }
            else
            {
                //TODO MODIFY
                DesktopList[index].username = textBoxUsername.Text;
                DesktopList[index].type = comboBoxType.Text.ToLower();

                userDesktopBindingSource.DataSource = DataUtilities.ToDataTable(DesktopList);

                dataGridViewUsers.DataSource = userDesktopBindingSource;

            }
        }

        private void addNewAndroidUser()
        {
            if (AddUser)
            {
                string username = textBoxUsername.Text;
                string password = BCrypt.Net.BCrypt.EnhancedHashPassword(textBoxPassword.Text);
                string image = textBoxImage.Text;
                string dateOfRegister = DateTime.Today.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                
                List<int> quizAchievementList = new List<int>();
              
                AndroidList.Add(new UserAndroid(username, password, image, dateOfRegister, quizAchievementList));

                userAndroidBindingSource.DataSource = DataUtilities.ToDataTable(AndroidList);

                dataGridViewUsers.DataSource = userAndroidBindingSource;
            }
            else
            {
               
                    AndroidList[index].username = textBoxUsername.Text;
                    AndroidList[index].image = textBoxImage.Text;

                    userAndroidBindingSource.DataSource = DataUtilities.ToDataTable(AndroidList);

                    dataGridViewUsers.DataSource = userAndroidBindingSource;
                
                
            }
            
        }

        private bool checkValues()
        {
            if (DesktopForm)
            {
                if (string.IsNullOrEmpty(textBoxUsername.Text))
                {
                    textBoxUsername.BackColor = Color.Red;
                    return false;
                }
                if(string.IsNullOrEmpty(textBoxPassword.Text) || textBoxPassword.Text.Contains(" "))
                {
                    return false;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(textBoxUsername.Text))
                {
                    return false;
                }
                if (string.IsNullOrEmpty(textBoxPassword.Text) || textBoxPassword.Text.Contains(" "))
                {
                    return false;
                }
                if (string.IsNullOrEmpty(textBoxImage.Text))
                {
                    return false;
                }
                if (string.IsNullOrEmpty(textBoxDate.Text))
                {
                    return false;
                }
             
            }
            return true;
        }

        private void saveData()
        {
            changes = false;
            JArray DesktopUsersArray = (JArray)JToken.FromObject(DesktopList);
            File.WriteAllText(USERS_DESKTOP_PATH, DesktopUsersArray.ToString());

            JArray AndroidUsersArray = (JArray)JToken.FromObject(AndroidList);
            File.WriteAllText(USERS_ANDROID_PATH, AndroidUsersArray.ToString());
        }

        private void FormUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save changes?", "Exit", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    saveData();
                }
            }
            
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int temporal = index;
            index = dataGridViewUsers.CurrentCell.RowIndex;
            if (DesktopForm)
            {
                if (temporal != index && index < DesktopList.Count())
                {
                    textBoxUsername.Text = DesktopList[index].username.ToString();
                    textBoxPassword.Text = DesktopList[index].password.ToString();
                    comboBoxType.Text = DesktopList[index].type.ToString();
                }
            }
            else
            {
                if (temporal != index && index < AndroidList.Count())
                {
                    textBoxUsername.Text = AndroidList[index].username.ToString();
                    textBoxPassword.Text = AndroidList[index].password.ToString();
                    textBoxImage.Text = AndroidList[index].image.ToString();
                    textBoxDate.Text = AndroidList[index].dateOfRegister.ToString();

                    Image nameImage= Image.FromFile(@"..\..\Resources\characters\" + textBoxImage.Text + ".jpeg");

                    if (nameImage.Width < pictureBoxCharacters.ClientSize.Width || nameImage.Height < pictureBoxCharacters.ClientSize.Height)
                    {
                        pictureBoxCharacters.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        pictureBoxCharacters.SizeMode = PictureBoxSizeMode.CenterImage;
                    }
                    pictureBoxCharacters.Image = nameImage;



                }
            }


            //    if (temporal != index && index <= DesktopList.Count()) 
            //{

            //    if (radioButtonDesktop.Checked)
            //    {
            //        textBoxUsername.Text = DesktopList[index].username.ToString();
            //        textBoxPassword.Text = DesktopList[index].password.ToString();
            //        comboBoxType.Text = DesktopList[index].type.ToString();
            //    }
            //    else
            //    {
            //        textBoxUsername.Text = AndroidList[index].username.ToString();
            //        textBoxPassword.Text = AndroidList[index].password.ToString();
            //        textBoxImage.Text = AndroidList[index].image.ToString();
            //        textBoxGender.Text = AndroidList[index].gender.ToString();
            //        textBoxAge.Text = AndroidList[index].age.ToString();
            //    }

            //}
        }

        private void FormUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Program.changingForms)
            {
                Application.Exit();
            }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (DesktopForm)
            { 
                if (user.Equals(DesktopList[dataGridViewUsers.CurrentCell.RowIndex]))
                {
                    MessageBox.Show("You can't delete your own account like this");
                    
                } else
                {
                    DesktopList.RemoveAt(dataGridViewUsers.CurrentCell.RowIndex);
                    userDesktopBindingSource.DataSource = DataUtilities.ToDataTable(DesktopList);

                    dataGridViewUsers.DataSource = userDesktopBindingSource;
                    clearTextBox();
                    changes = true;
                }
                
            }
            else
            {
                AndroidList.RemoveAt(dataGridViewUsers.CurrentCell.RowIndex);
                userAndroidBindingSource.DataSource = DataUtilities.ToDataTable(AndroidList);

                dataGridViewUsers.DataSource = userAndroidBindingSource;
                clearTextBox();
                changes = true;
            }
        }

        private void buttonDesktop_Click(object sender, EventArgs e)
        {
            if (!DesktopForm)
            {
                userDesktopBindingSource.DataSource = DataUtilities.ToDataTable(DesktopList);
                dataGridViewUsers.DataSource = null;
                dataGridViewUsers.DataSource = userDesktopBindingSource;
                dateregister.Visible = true;
                image.Visible = false;
                dateregister.Visible = false;
                pictureBoxCharacters.Visible = false;

                labelType.Visible = true;
                comboBoxType.Visible = true;


                labelImage.Visible = false;
                textBoxImage.Visible = false;
                labelDate.Visible = false;
                textBoxDate.Visible = false;
                labelDateRegister.Visible = false;
                labelImageCharacter.Visible = false;

                DesktopForm = true;
                AndroidForm = false;
            }
        }

        private void buttonAndroid_Click(object sender, EventArgs e)
        {
            if (!AndroidForm)
            {
                userAndroidBindingSource.DataSource = DataUtilities.ToDataTable(AndroidList);
                dataGridViewUsers.DataSource = null;
                dataGridViewUsers.DataSource = userAndroidBindingSource;
                type.Visible = false;
                image.Visible = true;
                dateregister.Visible = true;
                pictureBoxCharacters.Visible = true;

                labelType.Visible = false;
                comboBoxType.Visible = false;

                labelImage.Visible = true;
                textBoxImage.Visible = true;
                labelDate.Visible = true;
                textBoxDate.Visible = true;
                labelDateRegister.Visible = true;
                labelImageCharacter.Visible = true;

                AndroidForm = true;
                DesktopForm = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void questionManadgementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuestions formQuestions = new FormQuestions(user);
            Program.changingForms = true;
            this.Close();
            formQuestions.Show();  
            Program.changingForms = false;
        }

        private void characterManadgmenetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCharacters formCharacters = new FormCharacters(user);
            Program.changingForms = true;
            this.Close();
            formCharacters.Show();
            Program.changingForms = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonQuestionsIcon_Click(object sender, EventArgs e)
        {
            FormQuestions formQuestions = new FormQuestions(user);
            Program.changingForms = true;
            this.Close();
            formQuestions.Show();
            Program.changingForms = false;
        }

        private void buttonCharactersIcon_Click(object sender, EventArgs e)
        {
            FormCharacters formCharacters = new FormCharacters(user);
            Program.changingForms = true;
            this.Close();
            formCharacters.Show();
            Program.changingForms = false;
        }

        private void buttonSaveJSON_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG(*JPEG)|*.jpeg";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileImage = Image.FromFile(ofd.FileName);
                    pictureBoxCharacters.Image = FileImage;
                    path = ofd.FileName;
                    textBoxImage.Text = Path.GetFileNameWithoutExtension(path);
                }
                catch (OutOfMemoryException ex)
                {
                    Image nameImage = Image.FromFile(@"..\..\Resources\characters\error.jpeg");
                    path = ofd.FileName;
                    textBoxImage.Text = Path.GetFileNameWithoutExtension(path);
                    pictureBoxCharacters.Image = nameImage;
                }
               
            }
        }
    }
}
