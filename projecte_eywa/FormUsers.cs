using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace projecte_eywa
{
    public partial class FormUsers : Form
    {

        List<UserDesktop> DesktopList;
        List<UserAndroid> AndroidList = new List<UserAndroid>();
        UserDesktop actualUser;
        
        
        const string PATH = @"..\..\json\";
        const string USERS_DESKTOP_PATH = PATH + "users_desktop.json";
        const string USERS_ANDROID_PATH = PATH + "users_android.json";

        bool AddUser = false;
        int index = -1;

        bool DesktopForm = true;
        bool AndroidForm = false;



        public FormUsers(List<UserDesktop> DesktopList, UserDesktop actualUser)
        {
            this.DesktopList = DesktopList;
            this.actualUser = actualUser;
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            loadData();
            labelActualUserData.Text = actualUser.username.ToString() + " " + actualUser.type.ToString();
        }

        private void loadData()
        {
            //JArray LoadDesktopUsers = JArray.Parse(File.ReadAllText(USERS_DESKTOP_PATH, Encoding.Default));
            //DesktopList = LoadDesktopUsers.ToObject<List<UserDesktop>>();
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
                gender.Visible = false;
                age.Visible = false;
                
                labelType.Visible = true;
                comboBoxType.Visible = true;


                labelImage.Visible = false;
                textBoxImage.Visible = false;
                labelGender.Visible = false;
                textBoxGender.Visible = false;
                labelAge.Visible = false;
                textBoxAge.Visible = false;

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
                gender.Visible = true;
                age.Visible = true;

                labelType.Visible = false;
                comboBoxType.Visible = false;

                labelImage.Visible = true;
                textBoxImage.Visible = true;
                labelGender.Visible = true;
                textBoxGender.Visible = true;
                labelAge.Visible = true;
                textBoxAge.Visible = true;
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
                    textBoxGender.Text = AndroidList[index].gender.ToString();
                    textBoxAge.Text = AndroidList[index].age.ToString();

                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            enableTextBox();
            textBoxPassword.ReadOnly = false;
            clearTextBox();
            AddUser = true;
            disableButtons();


        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if(index != -1)
            {
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
                textBoxGender.Text = "";
                textBoxAge.Text = "";
            }
            
        }

        private void enableTextBox()
        {
            textBoxUsername.ReadOnly = false;
            buttonSave.Visible = true;
            buttonCancel.Visible = true;
            if (DesktopForm)
            {
                comboBoxType.Enabled = true;

            }
            else
            {
                textBoxImage.ReadOnly = false;
                textBoxGender.ReadOnly = false;
                textBoxAge.ReadOnly = false;
            }
        }

        private void disableTextBox()
        {
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
                textBoxImage.ReadOnly = true;
                textBoxGender.ReadOnly = true;
                textBoxAge.ReadOnly = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            AddUser = false;
            clearTextBox();
            disableTextBox();
            enableButtons();

        }

        private void disableButtons()
        {
            buttonAdd.Enabled = false;
            buttonModify.Enabled = false;
            buttonAndroid.Enabled = false;
            buttonDesktop.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void enableButtons()
        {
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
                }

            }
            else
            {
                if (checkValues())
                {
                    addNewAndroidUser();
                    AddUser = false;
                    buttonSave.Visible = false;
                    buttonCancel.Visible = false;
                    clearTextBox();
                    disableTextBox();
                    enableButtons();
                }
            }
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
                string gender = textBoxGender.Text;
                int age;
                if (!int.TryParse(textBoxAge.Text, out age))
                {
                    MessageBox.Show("Cositas");
                }
                AndroidList.Add(new UserAndroid(username, password, image, gender, age));

                userAndroidBindingSource.DataSource = DataUtilities.ToDataTable(AndroidList);

                dataGridViewUsers.DataSource = userAndroidBindingSource;
            }
            else
            {
                //TODO MODIFY
                int age;
                if(!int.TryParse(textBoxAge.Text, out age))
                {
                    MessageBox.Show("No se puede parsear la edad");
                }
                else
                {
                    AndroidList[index].username = textBoxUsername.Text;
                    AndroidList[index].image = textBoxImage.Text;
                    AndroidList[index].gender = textBoxGender.Text;
                    AndroidList[index].age = age;

                    userAndroidBindingSource.DataSource = DataUtilities.ToDataTable(AndroidList);

                    dataGridViewUsers.DataSource = userAndroidBindingSource;
                }
                
            }
            
        }

        private bool checkValues()
        {
            int age;
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
                if (string.IsNullOrEmpty(textBoxGender.Text))
                {
                    return false;
                }
                if (int.TryParse(textBoxAge.Text, out age))
                {
                    if(age < 6 || age > 120)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private void saveData()
        {
            JArray DesktopUsersArray = (JArray)JToken.FromObject(DesktopList);
            File.WriteAllText(USERS_DESKTOP_PATH, DesktopUsersArray.ToString());

            JArray AndroidUsersArray = (JArray)JToken.FromObject(AndroidList);
            File.WriteAllText(USERS_ANDROID_PATH, AndroidUsersArray.ToString());
        }

        private void FormUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveData();
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
                    textBoxGender.Text = AndroidList[index].gender.ToString();
                    textBoxAge.Text = AndroidList[index].age.ToString();

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
            Application.Exit();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (DesktopForm)
            { 
                DesktopList.RemoveAt(dataGridViewUsers.CurrentCell.RowIndex);
                userDesktopBindingSource.DataSource = DataUtilities.ToDataTable(DesktopList);

                dataGridViewUsers.DataSource = userDesktopBindingSource;
                clearTextBox();
            }
            else
            {
                AndroidList.RemoveAt(dataGridViewUsers.CurrentCell.RowIndex);
                userAndroidBindingSource.DataSource = DataUtilities.ToDataTable(AndroidList);

                dataGridViewUsers.DataSource = userAndroidBindingSource;
                clearTextBox();
            }
        }

        private void buttonDesktop_Click(object sender, EventArgs e)
        {
            if (!DesktopForm)
            {
                userDesktopBindingSource.DataSource = DataUtilities.ToDataTable(DesktopList);
                dataGridViewUsers.DataSource = null;
                dataGridViewUsers.DataSource = userDesktopBindingSource;
                type.Visible = true;
                image.Visible = false;
                gender.Visible = false;
                age.Visible = false;

                labelType.Visible = true;
                comboBoxType.Visible = true;


                labelImage.Visible = false;
                textBoxImage.Visible = false;
                labelGender.Visible = false;
                textBoxGender.Visible = false;
                labelAge.Visible = false;
                textBoxAge.Visible = false;

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
                gender.Visible = true;
                age.Visible = true;

                labelType.Visible = false;
                comboBoxType.Visible = false;

                labelImage.Visible = true;
                textBoxImage.Visible = true;
                labelGender.Visible = true;
                textBoxGender.Visible = true;
                labelAge.Visible = true;
                textBoxAge.Visible = true;

                AndroidForm = true;
                DesktopForm = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO");
        }
    }
}
