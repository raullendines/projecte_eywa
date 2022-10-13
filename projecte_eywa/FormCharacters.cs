using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace projecte_eywa
{
    public partial class FormCharacters : Form
    {
        const string PATH = @"..\..\json\characters.json";

        BindingList<QuizCharacter> characters = new BindingList<QuizCharacter>();
        QuizCharacter quizCharacter;
        bool add = false;
        bool modify = false;
        bool isFiltered = false;
        public FormCharacters()
        {
            InitializeComponent();

            getData();

        }

        private void saveJSON()
        {

            JArray QuizCharacters = (JArray)JToken.FromObject(quizCharacter);
            File.WriteAllText(PATH, QuizCharacters.ToString());
         
        }

        private void getData()
        {
            dataGridViewCharacters.AutoGenerateColumns = false;

            JArray LoadCharacters = JArray.Parse(File.ReadAllText(PATH, Encoding.Default));
            characters = LoadCharacters.ToObject<BindingList<QuizCharacter>>();
            
            dataGridViewCharacters.DataSource = null;
            dataGridViewCharacters.DataSource = characters;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            add = true;

            visibleButtons();

            controlBtnsDisabled();

            languageClicked();


            disableDataGrid();

            enabledTextBoxes();

            nullTextBoxes();
           
        }

        private void enabledDataGrid()
        {
            //Tabla activada
            dataGridViewCharacters.Enabled = true;
        }
        private void languageButtons()
        {
            //Languages buttons
            buttonCatalan.Enabled = true;
            buttonSpanish.Enabled = true;
            buttonEnglish.Enabled = true;
        }

        private void visibleButtons()
        {
            //Creation buttons
            buttonCancel.Visible = true;
            buttonSave.Visible = true;
        }
        private void invisibleButtons()
        {
            //Creation buttons
            buttonCancel.Visible = false;
            buttonSave.Visible = false;
        }
        private void disableDataGrid()
        {
            //Tabla desactivada
            dataGridViewCharacters.Enabled = false;
        }

        private void enabledTextBoxes()
        {
            //Modificacion habilitada
            comboBoxCategoryCharacter.Enabled = true;
            numericUpDownCorrectNum.Enabled = true;
            textBoxDescriptionCharacterEsp.Enabled = true;
            textBoxDescriptionCharacterCat.Enabled = true;
            textBoxDescriptionCharacterEng.Enabled = true;
            comboBoxDifficulty.Enabled = true;
            textBoxFilmCharacter.Enabled = true;
            textBoxImgUrlCharacter.Enabled = true;
            textBoxNameCharacter.Enabled = true;
        }

        private void disabledTextBoxes()
        {
            //Modificacion habilitada
            comboBoxCategoryCharacter.Enabled = false;
            numericUpDownCorrectNum.Enabled = false;
            textBoxDescriptionCharacterEsp.Enabled = false;
            textBoxDescriptionCharacterCat.Enabled = false;
            textBoxDescriptionCharacterEng.Enabled = false;
            comboBoxDifficulty.Enabled = false;
            textBoxFilmCharacter.Enabled = false;
            textBoxImgUrlCharacter.Enabled = false;
            textBoxNameCharacter.Enabled = false;
        }

        private void nullTextBoxes()
        {
            //Clear data textbox
            comboBoxCategoryCharacter.Text = null;
            numericUpDownCorrectNum.Text = null;
            textBoxDescriptionCharacterEsp.Text = null;
            textBoxDescriptionCharacterCat.Text = null;
            textBoxDescriptionCharacterEng.Text = null;
            comboBoxDifficulty.Text = null;
            textBoxFilmCharacter.Text = null;
            textBoxImgUrlCharacter.Text = null;
            textBoxNameCharacter.Text = null;
        }

        private void languageClicked()
        {
            //Languages buttons
            buttonCatalan.Enabled = false;
            buttonSpanish.Enabled = false;
            buttonEnglish.Enabled = false;
        }

        private void controlBtnsEnabled()
        {
            //Questions buttons
            buttonAdd.Enabled = true;
            buttonModify.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void controlBtnsDisabled()
        {
            //Questions buttons
            buttonAdd.Enabled = false;
            buttonModify.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            modify = false;
            add = false;

            invisibleButtons();

            controlBtnsEnabled();

            languageButtons();

            enabledDataGrid();

           // nullTextBoxes();

            disabledTextBoxes();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            modify = true;

            visibleButtons();

            controlBtnsDisabled();

            disableDataGrid();

            languageClicked();

            enabledTextBoxes();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxNameCharacter.Text == null)
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
            difficulty = comboBoxDifficulty.Text;
            correctNum = (int)numericUpDownCorrectNum.Value;
            description = textBoxDescriptionCharacterEsp.Text;
            imgUrl = textBoxImgUrlCharacter.Text;

            if (add == true)
            {
                if (correctNum >= 0 || correctNum <= 5)
                {
                    if (name != null && film != null && category != null && difficulty != null && description != null && imgUrl != null)
                    {
                        characters.Add(new QuizCharacter
                        {
                            name = name,
                            film = film,
                            category = category,
                            difficulty = difficulty,
                            num_correct = correctNum,
                            description_esp = description,
                            image = imgUrl
                        }
                   );
                        dataGridViewCharacters.DataSource = characters;

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
                quizCharacter.name = textBoxNameCharacter.Text;
                quizCharacter.description_esp = textBoxDescriptionCharacterEsp.Text;
                quizCharacter.difficulty = comboBoxDifficulty.Text;
                quizCharacter.film = textBoxFilmCharacter.Text;
                quizCharacter.category = comboBoxCategoryCharacter.Text;
                quizCharacter.image = textBoxImgUrlCharacter.Text;
                quizCharacter.num_correct = numericUpDownCorrectNum.Value;
            }

            //nullTextBoxes();

            invisibleButtons();

            controlBtnsEnabled();

            languageButtons();

            disabledTextBoxes();

            enabledDataGrid();

            //Valores restablecidos
            add = false;
            modify = false;
        }

        private void dataGridViewCharacters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                    quizCharacter = (QuizCharacter)dataGridViewCharacters.CurrentRow.DataBoundItem;

                    textBoxNameCharacter.Text = quizCharacter.name;
                    textBoxDescriptionCharacterEsp.Text = quizCharacter.description_esp;
                    textBoxDescriptionCharacterCat.Text = quizCharacter.description_cat;
                    textBoxDescriptionCharacterEng.Text = quizCharacter.description_eng;
                    comboBoxDifficulty.Text = quizCharacter.difficulty;
                    textBoxFilmCharacter.Text = quizCharacter.film;
                    comboBoxCategoryCharacter.Text = quizCharacter.category;
                    textBoxImgUrlCharacter.Text = quizCharacter.image;
                    numericUpDownCorrectNum.Value = quizCharacter.num_correct;
                
            }
        }

        private void buttonCatalan_Click(object sender, EventArgs e)
        {
            textBoxDescriptionCharacterEsp.Visible = false;
            textBoxDescriptionCharacterEng.Visible = false;
            textBoxDescriptionCharacterCat.Visible = true;
        }

        private void buttonSpanish_Click(object sender, EventArgs e)
        {
            textBoxDescriptionCharacterEsp.Visible = true;
            textBoxDescriptionCharacterEng.Visible = false;
            textBoxDescriptionCharacterCat.Visible = false;
        }

        private void buttonEnglish_Click(object sender, EventArgs e)
        {
            textBoxDescriptionCharacterEsp.Visible = false;
            textBoxDescriptionCharacterEng.Visible = true;
            textBoxDescriptionCharacterCat.Visible = false;
        }

        private void buttonApplyFilters_Click(object sender, EventArgs e)
        {
            isFiltered = true;
            string category = null;
            for (int i = 0; i < quizCharacter.Count; ++i)
            {

                dataGridViewCharacters.CurrentCell = null;
                dataGridViewCharacters.Rows[i].Visible = true;

            }

            if (comboBoxFilter != null && comboBoxFilter.SelectedItem != null)
            {
                int index = comboBoxFilter.Items.IndexOf(comboBoxFilter.SelectedItem);
                switch (index)
                {
                    case 0:
                        category = "science fiction";

                        break;
                    case 1:
                        category = "action";
                        break;
                    case 2:
                        category = "comedy";
                        break;
                    case 3:
                        category = "horror";
                        break;
                    case 4:
                        category = "animation";
                        break;
                    case 5:
                        category = "drama";
                        break;
                    default:
                        MessageBox.Show("ERROR");
                        break;
                }


                for (int i = 0; i < quizQuestions.Count; ++i)
                {
                    if (!quizQuestions[i].category.Equals(category))
                    {
                        dataGridViewCharacters.CurrentCell = null;
                        dataGridViewCharacters.Rows[i].Visible = false;
                    }
                }

            }
        }

        private void buttonClearFilters_Click(object sender, EventArgs e)
        {
            comboBoxFilter.SelectedIndex = -1;
            isFiltered = false;
            for (int i = 0; i < quizQuestions.Count; ++i)
            {

                dataGridViewCharacters.CurrentCell = null;
                dataGridViewCharacters.Rows[i].Visible = true;

            }
        }
    }
}