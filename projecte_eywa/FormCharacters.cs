using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
        List<QuizCharacter> tempCharacters = new List<QuizCharacter>();

        QuizCharacter quizCharacter;
        int index;
        bool add = false;
        bool modify = false;
        bool isFiltered = false;
        bool changes = false;
        UserDesktop user;
        String lang = "en";
        public FormCharacters(UserDesktop user)
        {
            InitializeComponent();
            this.user = user;
            getData();
            textBoxDescriptionCharacterEsp.Visible = false;
            textBoxDescriptionCharacterEng.Visible = true;

        }

        private void saveJSON()
        {
            changes = false;
            JArray QuizCharacters = (JArray)JToken.FromObject(characters);
            File.WriteAllText(PATH, QuizCharacters.ToString());

        }

        private void getData()
        {
            dataGridViewCharacters.AutoGenerateColumns = false;

            JArray LoadCharacters = JArray.Parse(File.ReadAllText(PATH, Encoding.Default));
            characters = LoadCharacters.ToObject<BindingList<QuizCharacter>>();

            quizCharactersBindingSource.DataSource = DataUtilities.ToDataTable(characters);
            dataGridViewCharacters.DataSource = quizCharactersBindingSource;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            add = true;
            buttonImage.Visible = true;
            pictureBoxCharacters.Image = null;

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

            if (add)
            {
                pictureBoxCharacters.Image = null;
                textBoxImgUrlCharacter.Text = "";
                nullTextBoxes();
            }

            modify = false;
            add = false;

            buttonImage.Visible = false;

            invisibleButtons();

            controlBtnsEnabled();

            languageButtons();

            enabledDataGrid();

            // nullTextBoxes();

            disabledTextBoxes();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (dataGridViewCharacters.CurrentCell.RowIndex != -1)
            {
                buttonImage.Visible = true;
                modify = true;

                visibleButtons();

                controlBtnsDisabled();

                disableDataGrid();

                languageClicked();

                enabledTextBoxes();
            }
            else
            {
                MessageBox.Show("Please, select a character first");
            }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

                int rowIndex = dataGridViewCharacters.CurrentCell.RowIndex;
                dataGridViewCharacters.Rows.RemoveAt(rowIndex);
                characters.RemoveAt(rowIndex);
                quizCharactersBindingSource.DataSource = DataUtilities.ToDataTable(characters);
                dataGridViewCharacters.DataSource = quizCharactersBindingSource;
                disabledTextBoxes();
                nullTextBoxes();   
                changes = true;
            

        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Find lang


            //Text to add
            String name, film, category = "", description, imgUrl;
            int correctNum, difficulty = 1;

            name = textBoxNameCharacter.Text;
            film = textBoxFilmCharacter.Text;
            category = comboBoxCategoryCharacter.Text;
            correctNum = (int)numericUpDownCorrectNum.Value;
            switch (lang)
            {
                case "ca": 
                    description = textBoxDescriptionCharacterCat.Text;
                    break;
                case "es":
                    description = textBoxDescriptionCharacterEsp.Text;
                    break;
                case "en":
                    description = textBoxDescriptionCharacterEng.Text;
                    break;
                default:
                    description = textBoxDescriptionCharacterEsp.Text;
                    break;
            }
            
            imgUrl = textBoxImgUrlCharacter.Text;

            String difficultyCharacter = comboBoxDifficulty.Text;
            switch (difficultyCharacter)
            {
                case "Easy":
                    difficulty = 1;
                    break;
                case "Medium":
                    difficulty = 2;
                    break;
                case "Hard":
                    difficulty = 3;
                    break;
                case "Legend":
                    difficulty = 4;
                    break;
                default:
                    MessageBox.Show("ERROR");
                    break;
            }

            if (add == true)
            {
                if (correctNum >= 0 || correctNum <= 5)
                {
                    if (name != null && film != null && category != null && description != null && imgUrl != null)
                    {

                        switch (lang)
                        {
                            case "ca":
                                characters.Add(new QuizCharacter
                                {
                                    name = name,
                                    film = film,
                                    category = category,
                                    difficulty = difficulty,
                                    num_correct = correctNum,
                                    description_cat = description,
                                    image = imgUrl
                                }
                        );
                                break;
                            case "es":
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
                                break;
                            case "en":
                                characters.Add(new QuizCharacter
                                {
                                    name = name,
                                    film = film,
                                    category = category,
                                    difficulty = difficulty,
                                    num_correct = correctNum,
                                    description_eng = description,
                                    image = imgUrl
                                }
                        );
                                break;
                            default:
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
                                break;
                        }


                        if (isFiltered)
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
                            quizCharactersBindingSource.DataSource = DataUtilities.ToDataTable(characters);
                            dataGridViewCharacters.DataSource = quizCharactersBindingSource;

                            category = null;
                        
                            if (comboBoxFilter.Text != "" && comboBoxFilter.Text == quizCharacter.category)
                            {
                                tempCharacters.Add(characters.Last());
                            }

                        }
                        else
                        {
                            quizCharactersBindingSource.DataSource = DataUtilities.ToDataTable(characters);
                            dataGridViewCharacters.DataSource = quizCharactersBindingSource;
                        }
                   
                        
                        changes = true;
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

                String dificultad = comboBoxDifficulty.Text;
                switch (dificultad)
                {
                    case "Easy":
                        difficulty = 1;
                        break;
                    case "Medium":
                        difficulty = 2;
                        break;
                    case "Hard":
                        difficulty = 3;
                        break;
                    case "Legend":
                        difficulty = 4;
                        break;
                    default:
                        MessageBox.Show("ERROR");
                        break;
                }

                index = dataGridViewCharacters.CurrentCell.RowIndex;
                characters[index].name = textBoxNameCharacter.Text;
                characters[index].difficulty = difficulty;
                characters[index].description_cat = textBoxDescriptionCharacterCat.Text;
                characters[index].description_esp = textBoxDescriptionCharacterEsp.Text;
                characters[index].description_eng = textBoxDescriptionCharacterEng.Text;
                characters[index].film = textBoxFilmCharacter.Text;
                characters[index].category = comboBoxCategoryCharacter.Text;
                characters[index].image = textBoxImgUrlCharacter.Text;
                characters[index].num_correct = numericUpDownCorrectNum.Value;

                quizCharactersBindingSource.DataSource = DataUtilities.ToDataTable(characters);
                dataGridViewCharacters.DataSource = quizCharactersBindingSource;

                changes = true;
            }

            //nullTextBoxes();

            invisibleButtons();

            controlBtnsEnabled();

            languageButtons();

            disabledTextBoxes();

            enabledDataGrid();

            buttonImage.Visible = false;

            //Valores restablecidos
            add = false;
            modify = false;

        }

        private void dataGridViewCharacters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int temporal = index;

            index = dataGridViewCharacters.CurrentCell.RowIndex;
            if (temporal != index && index < dataGridViewCharacters.RowCount - 1)
            {
                int difficulty = characters[index].difficulty;
                switch (difficulty)
                {
                    case 1:
                        comboBoxDifficulty.Text = "Easy";
                        break;
                    case 2:
                        comboBoxDifficulty.Text = "Medium";
                        break;
                    case 3:
                        comboBoxDifficulty.Text = "Hard";
                        break;
                    case 4:
                        comboBoxDifficulty.Text = "Legend";
                        break;
                    default:
                        MessageBox.Show("ERROR");
                        break;
                }


                textBoxNameCharacter.Text = characters[index].name;
                textBoxDescriptionCharacterEsp.Text = characters[index].description_esp;
                textBoxDescriptionCharacterCat.Text = characters[index].description_cat;
                textBoxDescriptionCharacterEng.Text = characters[index].description_eng;
                textBoxFilmCharacter.Text = characters[index].film;
                comboBoxCategoryCharacter.Text = characters[index].category;
                textBoxImgUrlCharacter.Text = characters[index].image;
                numericUpDownCorrectNum.Value = characters[index].num_correct;

                try
                {
                    pictureBoxCharacters.Image = Image.FromFile(@"..\..\Resources\characters\" + textBoxImgUrlCharacter.Text + ".jpeg");
                    
                } catch (OutOfMemoryException ex)
                {
                    MessageBox.Show("This image can't be opened.");
                    pictureBoxCharacters.Image = Image.FromFile(@"..\..\Resources\characters\" + "error" + ".jpeg");
                }

                pictureBoxCharacters.SizeMode = PictureBoxSizeMode.CenterImage;

            }
        }

        private void buttonCatalan_Click(object sender, EventArgs e)
        {
            if (!lang.Equals("ca"))
            {
                textBoxDescriptionCharacterEsp.Visible = false;
                textBoxDescriptionCharacterEng.Visible = false;
                textBoxDescriptionCharacterCat.Visible = true;
                changeLangCA();
                lang = "ca";
            }
            
        }

        private void buttonSpanish_Click(object sender, EventArgs e)
        {
            if (!lang.Equals("es"))
            {
                textBoxDescriptionCharacterEsp.Visible = true;
                textBoxDescriptionCharacterEng.Visible = false;
                textBoxDescriptionCharacterCat.Visible = false;
                changeLangES();
                lang = "es";
            }
            
        }

        private void buttonEnglish_Click(object sender, EventArgs e)
        {
            if (!lang.Equals("en"))
            {
                textBoxDescriptionCharacterEsp.Visible = false;
                textBoxDescriptionCharacterEng.Visible = true;
                textBoxDescriptionCharacterCat.Visible = false;
                changeLangEN();
                lang = "en";
            }
            
        }

        private void changeLangCA()
        {
            //LABELS
            labelNameCharacter.Text = "Nom";
            labelFilmCharacter.Text = "Pel·lícula";
            labelCategoryCharacter.Text = "Categoria";
            labelDifficultyCharacter.Text = "Dificultat";
            labelNumCorrecto.Text = "Respostes correctes";
            labelImgUrl.Text = "Imatge URL";
            labelDescriptionCharacter.Text = "Descripció";
            // Change ADD, MODIFY, DELETE buttons
            buttonAdd.Text = "Afegir";
            buttonModify.Text = "Modificar";
            buttonDelete.Text = "Eliminar";
            // Change OK, CANCEL buttons
            buttonSave.Text = "Guardar";
            buttonCancel.Text = "Cancelar";
            // Category Filter
            comboBoxFilter.Items.Clear();
            comboBoxFilter.Items.Add("Ciència Ficció");
            comboBoxFilter.Items.Add("Acció");
            comboBoxFilter.Items.Add("Comedia");
            comboBoxFilter.Items.Add("Terror");
            comboBoxFilter.Items.Add("Animació");
            comboBoxFilter.Items.Add("Drama");
            // Change FilterComboBox language
            labelFilter.Text = "Filtre";
            buttonApplyFilters.Text = "Aplicar filtre";
            buttonClearFilters.Text = "Netejar filtre";


        }

        private void changeLangES()
        {
            //LABELS
            labelNameCharacter.Text = "Nombre";
            labelFilmCharacter.Text = "Película";
            labelCategoryCharacter.Text = "Categoría";
            labelDifficultyCharacter.Text = "Dificultad";
            labelNumCorrecto.Text = "Respuestas correctas";
            labelImgUrl.Text = "Imagen URL";
            labelDescriptionCharacter.Text = "Descripción";
            // Change ADD, MODIFY, DELETE buttons
            buttonAdd.Text = "Añadir";
            buttonModify.Text = "Modificar";
            buttonDelete.Text = "Eliminar";
            // Change OK, CANCEL buttons
            buttonSave.Text = "Guardar";
            buttonCancel.Text = "Cancelar";
            // Category Filter
            comboBoxFilter.Items.Clear();
            comboBoxFilter.Items.Add("Ciencia Ficción");
            comboBoxFilter.Items.Add("Acción");
            comboBoxFilter.Items.Add("Comedia");
            comboBoxFilter.Items.Add("Terror");
            comboBoxFilter.Items.Add("Animación");
            comboBoxFilter.Items.Add("Drama");
            // Change FilterComboBox language
            labelFilter.Text = "Filtro";
            buttonApplyFilters.Text = "Aplicar filtro";
            buttonClearFilters.Text = "Limpiar filtro";
        }

        private void changeLangEN()
        {
            //LABELS
            labelNameCharacter.Text = "Name";
            labelFilmCharacter.Text = "Film";
            labelCategoryCharacter.Text = "Category";
            labelDifficultyCharacter.Text = "Difficulty";
            labelNumCorrecto.Text = "Correct Number";
            labelImgUrl.Text = "Image URL";
            labelDescriptionCharacter.Text = "Description";
            // Change ADD, MODIFY, DELETE buttons
            buttonAdd.Text = "Add";
            buttonModify.Text = "Modify";
            buttonDelete.Text = "Delete";
            // Change OK, CANCEL buttons
            buttonSave.Text = "Save";
            buttonCancel.Text = "Cancel";
            // Category Filter
            comboBoxFilter.Items.Clear();
            comboBoxFilter.Items.Add("Science Fiction");
            comboBoxFilter.Items.Add("Action");
            comboBoxFilter.Items.Add("Comedy");
            comboBoxFilter.Items.Add("Horror");
            comboBoxFilter.Items.Add("Animation");
            comboBoxFilter.Items.Add("Drama");
            // Change FilterComboBox language
            labelFilter.Text = "Filter";
            buttonApplyFilters.Text = "Apply filter";
            buttonClearFilters.Text = "Clear filter";
        }

        private void buttonApplyFilters_Click(object sender, EventArgs e)
        {

            isFiltered = true;

            tempCharacters.Clear();
            dataGridViewCharacters.CurrentCell = null;
            String category = "";
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



            if (comboBoxFilter.Text != "")
            {
                tempCharacters = characters.Where(i => i.category.Equals(category)).ToList();
                var listBinding = new BindingList<QuizCharacter>(tempCharacters);
                quizCharactersBindingSource.DataSource = DataUtilities.ToDataTable(tempCharacters);
                dataGridViewCharacters.DataSource = quizCharactersBindingSource;
            }
        }

        private void buttonClearFilters_Click(object sender, EventArgs e)
        {
            comboBoxFilter.SelectedIndex = -1;
            isFiltered = false;
            quizCharactersBindingSource.DataSource = DataUtilities.ToDataTable(characters);
            dataGridViewCharacters.DataSource = quizCharactersBindingSource;
            for (int i = 0; i < characters.Count; ++i)
            {

                dataGridViewCharacters.CurrentCell = null;
                dataGridViewCharacters.DataSource = characters;

            }
        }

        private void questionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuestions formQuestions = new FormQuestions(user);
            formQuestions.Show();
            Program.changingForms = true;
            this.Close();
            Program.changingForms = false;
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsers formUsers = new FormUsers(user);
            formUsers.Show();
            Program.changingForms = true;
            this.Close();
            Program.changingForms = false;
        }

        private void FormCharacters_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Program.changingForms)
            {
                Application.Exit();
            }
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
        private void userType(UserDesktop user)
        {
            switch (user.type)
            {
                case "user":
                    controlBtnsDisabled();
                    buttonQuestionsIcon.Visible = true;
                    buttonUsersIcon.Visible = false;
                    buttonAdd.Visible = false;
                    buttonModify.Visible = false;
                    buttonDelete.Visible = false;
                    buttonSaveJSON.Visible = false;
                    buttonQuestionsIcon.Location = new Point(982, 65);
                    label5.Location = new Point(975, 138);
                    label4.Visible = false;
                    label3.Visible = false;

                    break;
                case "admin":
                    buttonQuestionsIcon.Visible=true;
                    buttonUsersIcon.Visible = false;
                    buttonSaveJSON.Location = new Point(985, 60);
                    label3.Location = new Point(994, 134);

                    break;
                default:
                    buttonQuestionsIcon.Visible = true;
                    buttonUsersIcon.Visible = true;
                    buttonSaveJSON.Location = new Point(1083, 60);

                    break;
            }
        }

        private void FormCharacters_Load(object sender, EventArgs e)
        {
            labelActualUserData.Text = user.username.ToString() + " " + user.type.ToString();
            
            userType(user);
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

        private void button1_Click(object sender, EventArgs e)
        {
            saveJSON();
        }

        private void FormCharacters_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save changes?", "Exit", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    saveJSON();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG(*JPEG)|*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image FileImage = Image.FromFile(ofd.FileName);
                    pictureBoxCharacters.Image = FileImage;
                    String path = ofd.FileName;
                    textBoxImgUrlCharacter.Text = Path.GetFileNameWithoutExtension(path);
                }
                catch (OutOfMemoryException ex)
                {
                    Image nameImage = Image.FromFile(@"..\..\Resources\characters\error.jpeg");
                    String path = ofd.FileName;
                    textBoxImgUrlCharacter.Text = Path.GetFileNameWithoutExtension(path);
                    pictureBoxCharacters.Image = nameImage;
                }

            }
        }
    }
}