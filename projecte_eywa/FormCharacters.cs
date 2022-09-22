using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecte_eywa
{
    public partial class FormCharacters : Form
    {
        public FormCharacters()
        {
            InitializeComponent();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
                //Creation buttons
                buttonCancel.Visible = true;
                buttonSave.Visible = true;
                
                //Questions buttons
                buttonAdd.Enabled = false;
                buttonModify.Enabled = false;  
                buttonDelete.Enabled = false;
                
                //Languages buttons
                buttonCatalan.Enabled = false;
                buttonSpanish.Enabled = false;
                buttonEnglish.Enabled = false;
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //Creation buttons
            buttonCancel.Visible = false;
            buttonSave.Visible = false;

            //Questions buttons
            buttonAdd.Enabled = true;
            buttonModify.Enabled = true;
            buttonDelete.Enabled = true;

            //Languages buttons
            buttonCatalan.Enabled = true;
            buttonSpanish.Enabled = true;
            buttonEnglish.Enabled = true;

        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            //Creation buttons
            buttonCancel.Visible = true;
            buttonSave.Visible = true;

            //Questions buttons
            buttonAdd.Enabled = false;
            buttonModify.Enabled = false;
            buttonDelete.Enabled = false;

            //Languages buttons
            buttonCatalan.Enabled = false;
            buttonSpanish.Enabled = false;
            buttonEnglish.Enabled = false;
        }
    }
}
