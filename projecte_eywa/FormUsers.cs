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


namespace projecte_eywa
{
    public partial class FormUsers : Form
    {

        List<UserDesktop> DesktopList = new List<UserDesktop>();
        List<UserAndroid> AndroidList = new List<UserAndroid>();
        
        const string auth = "EYWA";
        const string PATH = @"..\..\json\";
        const string USERS_DESKTOP_PATH = PATH + "users_desktop.json";
        const string USERS_ANDROID_PATH = PATH + "users_android.json";


        public FormUsers()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            loadData();
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
            if (radioButtonDesktop.Checked)
            {
                userDesktopBindingSource.DataSource = DataUtilities.ToDataTable(DesktopList);
                dataGridViewUsers.DataSource = null;
                dataGridViewUsers.DataSource = userDesktopBindingSource;
                type.Visible = true;
                image.Visible = false;
                gender.Visible = false;
                age.Visible = false;
            }
        }

        private void radioButtonAndroid_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAndroid.Checked)
            {
                userAndroidBindingSource.DataSource = DataUtilities.ToDataTable(AndroidList);
                dataGridViewUsers.DataSource = null;
                dataGridViewUsers.DataSource = userAndroidBindingSource;
                type.Visible = false;
                image.Visible = true;
                gender.Visible = true;
                age.Visible = true;
            }
        }
    }
}
