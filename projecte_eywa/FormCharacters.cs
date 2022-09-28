using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace projecte_eywa
{
    public partial class FormCharacters : Form
    {
        BindingList<QuizCharacter> characters = new BindingList<QuizCharacter>();
        QuizCharacter quizCharacter;
        bool add = false;
        bool modify = false;
        public FormCharacters()
        {
            InitializeComponent();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {

            add = true;

            Console.WriteLine("Despues de cambiar " + add);
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

            //Modificacion habilitada
            comboBoxCategoryCharacter.Enabled = true;
            numericUpDownCorrectNum.Enabled = true;
            textBoxDecriptionCharacter.Enabled = true;
            textBoxDifficultyCharacter.Enabled = true;
            textBoxFilmCharacter.Enabled = true;
            textBoxImgUrlCharacter.Enabled = true;
            textBoxNameCharacter.Enabled = true;

            //Clear data textbox
            comboBoxCategoryCharacter.Text = null;
            numericUpDownCorrectNum.Text = null;
            textBoxDecriptionCharacter.Text = null;
            textBoxDifficultyCharacter.Text = null;
            textBoxFilmCharacter.Text = null;
            textBoxImgUrlCharacter.Text = null;
            textBoxNameCharacter.Text = null;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            modify = false;
            add = false;

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

            //Datos nulos
            textBoxNameCharacter.Text = null;
            textBoxFilmCharacter.Text = null;
            comboBoxCategoryCharacter.Text = null;
            textBoxDifficultyCharacter.Text = null;
            numericUpDownCorrectNum.Value = 0;
            textBoxDecriptionCharacter.Text = null;
            textBoxImgUrlCharacter.Text = null;

            //Modificacion habilitada
            comboBoxCategoryCharacter.Enabled = false;
            numericUpDownCorrectNum.Enabled = false;
            textBoxDecriptionCharacter.Enabled = false;
            textBoxDifficultyCharacter.Enabled = false;
            textBoxFilmCharacter.Enabled = false;
            textBoxImgUrlCharacter.Enabled = false;
            textBoxNameCharacter.Enabled = false;
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

            //Modificacion habilitada
            comboBoxCategoryCharacter.Enabled = true;
            numericUpDownCorrectNum.Enabled = true;
            textBoxDecriptionCharacter.Enabled = true;
            textBoxDifficultyCharacter.Enabled = true;
            textBoxFilmCharacter.Enabled = true;
            textBoxImgUrlCharacter.Enabled = true;
            textBoxNameCharacter.Enabled = true;
        }

        private void FormCharacters_Load(object sender, EventArgs e)
        {
            dataGridViewCharacters.AutoGenerateColumns = false;

            characters.Add(new QuizCharacter { nameCharacter = "Antonio Banderas", filmCharacter = "Prueba 1", categoryCharacter = "Comedy", difficultyCharacter="Extreme", correctNumCharacter = 5, descCharacter = "SUi", urlImageCharacter = "imagen 1" });
            characters.Add(new QuizCharacter { nameCharacter = "Will Smith", filmCharacter = "Prueba 2", categoryCharacter = "Action", difficultyCharacter="Medium", correctNumCharacter = 4, descCharacter = "Sui", urlImageCharacter = "Imagen 2" });
            characters.Add(new QuizCharacter { nameCharacter = "Paco Alcacer", filmCharacter = "Prueba 3", categoryCharacter = "Comedia", difficultyCharacter="Difficult", correctNumCharacter = 7, descCharacter = "Sui", urlImageCharacter = "Imagen 2" });
            characters.Add(new QuizCharacter { nameCharacter = "Raul Lendines", filmCharacter = "Prueba 4" , categoryCharacter = "Comedia", difficultyCharacter="Easy", correctNumCharacter = 9, descCharacter = "sui", urlImageCharacter = "Imagen 2" });

            dataGridViewCharacters.DataSource = characters;
        }

        private void dataGridViewCharacters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                quizCharacter = (QuizCharacter)dataGridViewCharacters.CurrentRow.DataBoundItem;

                textBoxNameCharacter.Text = quizCharacter.nameCharacter;
                textBoxDecriptionCharacter.Text = quizCharacter.descCharacter;
                textBoxDifficultyCharacter.Text = quizCharacter.difficultyCharacter;
                textBoxFilmCharacter.Text = quizCharacter.filmCharacter;
                comboBoxCategoryCharacter.Text = quizCharacter.categoryCharacter;
                textBoxImgUrlCharacter.Text = quizCharacter.urlImageCharacter;
                numericUpDownCorrectNum.Value = quizCharacter.correctNumCharacter;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(textBoxNameCharacter.Text == null)
            {
                int rowIndex = dataGridViewCharacters.CurrentCell.RowIndex;
                dataGridViewCharacters.Rows.RemoveAt(rowIndex);
            }
           
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Text to add
            String name, film, category, difficulty, description, imgUrl;
            int correctNum;

            name = textBoxNameCharacter.Text;
            film = textBoxFilmCharacter.Text;
            category = comboBoxCategoryCharacter.Text;
            difficulty = textBoxDifficultyCharacter.Text;
            correctNum = (int)numericUpDownCorrectNum.Value;
            description = textBoxDecriptionCharacter.Text;
            imgUrl = textBoxImgUrlCharacter.Text;
            if (add == true){
                if (correctNum >= 0 || correctNum <= 5)
                {
                    if (name != null && film != null && category != null && difficulty != null && description != null && imgUrl != null)
                    {
                        characters.Add(new QuizCharacter
                        {
                            nameCharacter = name,
                            filmCharacter = film,
                            categoryCharacter = category,
                            difficultyCharacter = difficulty,
                            correctNumCharacter = correctNum,
                            descCharacter = description,
                            urlImageCharacter = imgUrl
                        }
                   );
                        dataGridViewCharacters.DataSource = characters;

                        //Datos nulos
                        textBoxNameCharacter.Text = null;
                        textBoxFilmCharacter.Text = null;
                        comboBoxCategoryCharacter.Text = null;
                        textBoxDifficultyCharacter.Text = null;
                        numericUpDownCorrectNum.Value = 0;
                        textBoxDecriptionCharacter.Text = null;
                        textBoxImgUrlCharacter.Text = null;

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

                        //Modificacion habilitada
                        comboBoxCategoryCharacter.Enabled = false;
                        numericUpDownCorrectNum.Enabled = false;
                        textBoxDecriptionCharacter.Enabled = false;
                        textBoxDifficultyCharacter.Enabled = false;
                        textBoxFilmCharacter.Enabled = false;
                        textBoxImgUrlCharacter.Enabled = false;
                        textBoxNameCharacter.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show
                        (
                            "Por favor inserte todos los datos",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                }
            }
            else if (modify == true)
            {
                quizCharacter.nameCharacter = textBoxNameCharacter.Text;
                quizCharacter.descCharacter = textBoxDecriptionCharacter.Text;
                quizCharacter.difficultyCharacter = textBoxDifficultyCharacter.Text;
                quizCharacter.filmCharacter = textBoxFilmCharacter.Text;
                quizCharacter.categoryCharacter = comboBoxCategoryCharacter.Text;
                quizCharacter.urlImageCharacter = textBoxImgUrlCharacter.Text;
                quizCharacter.correctNumCharacter = numericUpDownCorrectNum.Value;
            }
            
            
        }
    }
}