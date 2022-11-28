
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

namespace projecte_eywa
{
    public partial class FormQuestions : Form
    {
        // PATHING
        const string PATH = @"..\..\json\" ;
        const string EN_PATH = PATH + "questions_en.json";
        
        const string ES_PATH = PATH + "questions_es.json";
        const string CA_PATH = PATH + "questions_ca.json";
        
        // LISTS 
        BindingList<QuizQuestion> quizQuestions = new BindingList<QuizQuestion>();
        BindingList<QuizQuestion> quizQuestionsEN = new BindingList<QuizQuestion>();
        BindingList<QuizQuestion> quizQuestionsES = new BindingList<QuizQuestion>();
        BindingList<QuizQuestion> quizQuestionsCA = new BindingList<QuizQuestion>();
        List<QuizQuestion> tempQuizQuestions = new List<QuizQuestion>();

        UserDesktop user;

        // CURRENT LANGUAGE
        string currentSheet = "EN";

        int index = -1;
        //List<string> incorrectAnswers = new List<string>();
        bool addQuestion = false;
        bool modifyQuestion = false;
        bool isFiltered = false;
        bool changes = false;
        
        public FormQuestions(UserDesktop user)
        {
            InitializeComponent();
            this.user = user;
            getData();
            saveJSON();
        }

        private void saveJSON()
        {
            changes = false;
            //needs to delete the previous document
            JArray QuizQuestionsArrayEN = (JArray)JToken.FromObject(quizQuestionsEN);
            File.WriteAllText(EN_PATH, QuizQuestionsArrayEN.ToString());
            JArray QuizQuestionsArrayES = (JArray)JToken.FromObject(quizQuestionsES);
            File.WriteAllText(ES_PATH, QuizQuestionsArrayES.ToString());
            JArray QuizQuestionsArrayCA = (JArray)JToken.FromObject(quizQuestionsCA);
            File.WriteAllText(CA_PATH, QuizQuestionsArrayCA.ToString());
        }

        private void getData()
        {

            JArray LoadQuestionsEN = JArray.Parse(File.ReadAllText(EN_PATH, Encoding.UTF8));
            quizQuestionsEN = LoadQuestionsEN.ToObject<BindingList<QuizQuestion>>();
            JArray LoadQuestionsES = JArray.Parse(File.ReadAllText(ES_PATH, Encoding.UTF8));
            quizQuestionsES = LoadQuestionsES.ToObject<BindingList<QuizQuestion>>();
            JArray LoadQuestionsCA = JArray.Parse(File.ReadAllText(CA_PATH, Encoding.UTF8));
            quizQuestionsCA = LoadQuestionsCA.ToObject<BindingList<QuizQuestion>>();
            
            changeSheets();
        }

        private void changeSheets()
        {
            switch (currentSheet)
            {
                case "EN":
                    quizQuestions = quizQuestionsEN;
                    changeLanguageEN();

                    break;
                case "ES":
                    quizQuestions = quizQuestionsES;
                    changeLanguageES();

                    break;
                case "CA":
                    quizQuestions = quizQuestionsCA;
                    changeLanguageCA();

                    break;
            }
            initializeEmptyBoxes();
            quizQuestionsBindingSource.DataSource = DataUtilities.ToDataTable(quizQuestions);
            //dataGridViewQuestions.DataSource = quizQuestionsBindingSource;
        }
        private void saveSheet()
        {
            switch (currentSheet)
            {
                case "EN":
                    quizQuestionsEN = quizQuestions;
                    
                    break;
                case "ES":
                    quizQuestionsES = quizQuestions;
                    
                    break;
                case "CA":
                    quizQuestionsCA = quizQuestions;
                    
                    break;
            }
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // ADD button clicked
            addQuestion = true;
            int last = quizQuestions.Last().id + 1;
            String newId = last.ToString();
            // Disable dataGrid 
            dataGridViewQuestions.Enabled = false;
            // Initialize empty boxes
            textBoxIdDescription.Text = newId;
            textBoxQuestionDescription.Text = "";
            textBoxCorrectAnswer.Text = "";
            textBoxIncorrectAnswer1.Text = "";
            textBoxIncorrectAnswer2.Text = "";
            textBoxIncorrectAnswer3.Text = "";
            comboBoxCategoryDescription.SelectedIndex = -1;
            comboBoxDifficultDescription.SelectedIndex = -1;
            enableBoxes();
            enableOkCancelButtons();
            disableAddModifyDeleteButtons();
            disableLanguageButtons();
            
        }




        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (addQuestion)
            {
                int last = quizQuestions.Last().id + 1;
                String newId = last.ToString();
                textBoxIdDescription.Text = newId;
                List<string> ListIncorrects = new List<string>();
                QuizQuestion question = new QuizQuestion();


                ListIncorrects.Add(textBoxIncorrectAnswer1.Text);
                ListIncorrects.Add(textBoxIncorrectAnswer2.Text);
                ListIncorrects.Add(textBoxIncorrectAnswer3.Text);


                question.id = last;
                question.question = textBoxQuestionDescription.Text;

                String difficultyCharacter = comboBoxDifficultDescription.Text;
                switch (difficultyCharacter)
                {
                    case "Easy":
                        question.difficulty = 1;
                        break;
                    case "Medium":
                        question.difficulty = 2;
                        break;
                    case "Hard":
                        question.difficulty = 3;
                        break;
                    case "Legend":
                        question.difficulty = 4;
                        break;
                    default:
                        MessageBox.Show("ERROR");
                        break;
                }

                if (comboBoxCategoryDescription != null && comboBoxCategoryDescription.SelectedItem != null)
                    {
                        int index = comboBoxCategoryDescription.Items.IndexOf(comboBoxCategoryDescription.SelectedItem);
                        switch (index)
                        {
                            case 0:
                                question.category = "science fiction";
                                break;
                            case 1:
                                question.category = "action";
                                break;
                            case 2:
                                question.category = "comedy";
                                break;
                            case 3:
                                question.category = "horror";
                                break;
                            case 4:
                                question.category = "animation";
                                break;
                            case 5:
                                question.category = "drama";
                                break;
                            default:
                                MessageBox.Show("ERROR");
                                break;
                        }

                    }
                
                question.correct_answer = textBoxCorrectAnswer.Text;
                question.incorrect_answers = ListIncorrects;


                if (question.question == "" || (question.difficulty < 1 && question.difficulty > 4) || question.category == "" || question.correct_answer == "" || (question.incorrect_answers[0] == "" || question.incorrect_answers[1] == "" || question.incorrect_answers[2] == ""))
                {
                     MessageBox.Show("Error - Empty box. " +
                            "Please be sure to fill all camps.");
                        textBoxIdDescription.Text = newId;
                        textBoxQuestionDescription.Text = question.question;
                        textBoxCorrectAnswer.Text = question.correct_answer;
                        textBoxIncorrectAnswer1.Text = question.incorrect_answers[0];
                        textBoxIncorrectAnswer2.Text = question.incorrect_answers[1];
                        textBoxIncorrectAnswer3.Text = question.incorrect_answers[2];
                        if (comboBoxCategoryDescription.SelectedItem != null)
                        {
                            comboBoxCategoryDescription.SelectedIndex = comboBoxCategoryDescription.Items.IndexOf(question.category);
                        }
                        
                        comboBoxDifficultDescription.SelectedIndex = question.difficulty - 1;

                }
                else
                    {
                        quizQuestions.Add(question);
                        // Disable Add button
                        addQuestion = false;
                        // Enable dataGrid 
                        dataGridViewQuestions.Enabled = true;
                        initializeEmptyBoxes();
                        disableBoxes();
                        disableOkCancelButtons();
                        enableAddModifyDeleteButtons();
                        enableLanguageButtons();
                        changes = true;
                        quizQuestionsBindingSource.DataSource = DataUtilities.ToDataTable(quizQuestions);
                        dataGridViewQuestions.DataSource = quizQuestionsBindingSource;

                    string category = null;
                        
                    if (comboBoxFilter.Text != "" && comboBoxFilter.Text == question.category)
                    {
                        tempQuizQuestions.Add(quizQuestions.Last());
                    }
                }
               

               

                
            }
            else if (modifyQuestion)
            {
                int difficulty = 1;
                String dificultad = comboBoxDifficultDescription.Text;
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
                index = dataGridViewQuestions.CurrentCell.RowIndex;
                quizQuestions[index].question = textBoxQuestionDescription.Text;
                quizQuestions[index].correct_answer = textBoxCorrectAnswer.Text;
                quizQuestions[index].incorrect_answers[0] = textBoxIncorrectAnswer1.Text;
                quizQuestions[index].incorrect_answers[1] = textBoxIncorrectAnswer2.Text;
                quizQuestions[index].incorrect_answers[2] = textBoxIncorrectAnswer3.Text;
                quizQuestions[index].difficulty = difficulty;
                int indice = comboBoxCategoryDescription.Items.IndexOf(comboBoxCategoryDescription.SelectedItem);
                switch (indice)
                {
                    case 0:
                        quizQuestions[index].category = "science fiction";
                        break;
                    case 1:
                        quizQuestions[index].category = "action";
                        break;
                    case 2:
                        quizQuestions[index].category = "comedy";
                        break;
                    case 3:
                        quizQuestions[index].category = "horror";
                        break;
                    case 4:
                        quizQuestions[index].category = "animation";
                        break;
                    case 5:
                        quizQuestions[index].category = "drama";
                        break;
                    default:
                        MessageBox.Show("ERROR");
                        break;
                }

                // Enable dataGrid 
                dataGridViewQuestions.Enabled = true;
                initializeEmptyBoxes();
                disableBoxes();

                disableOkCancelButtons();
                enableAddModifyDeleteButtons();
                enableLanguageButtons();
                // Disable button
                modifyQuestion = false;
                changes = true;
                quizQuestionsBindingSource.DataSource = DataUtilities.ToDataTable(quizQuestions);
                dataGridViewQuestions.DataSource = quizQuestionsBindingSource;
            }
        }



        private void buttonModify_Click(object sender, EventArgs e)
        {
            index = dataGridViewQuestions.CurrentCell.RowIndex;
            if (index != -1)
            {
                // Disable dataGrid 
                dataGridViewQuestions.Enabled = false;
                // Modify button clicked
                modifyQuestion = true;
                enableBoxes();
                enableOkCancelButtons();
                disableAddModifyDeleteButtons();
                disableLanguageButtons();
            }
            else
            {
                MessageBox.Show("Please, select a question first");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            index = dataGridViewQuestions.CurrentCell.RowIndex;
            dataGridViewQuestions.Rows.RemoveAt(index);
            quizQuestions.RemoveAt(index);
            quizQuestionsBindingSource.DataSource = DataUtilities.ToDataTable(quizQuestions);
            dataGridViewQuestions.DataSource = quizQuestionsBindingSource;
            disableBoxes();
            initializeEmptyBoxes();
            changes = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (addQuestion)
            {
                addQuestion = false;
            }
            else
            {
                modifyQuestion = false;
            }
            // Enable dataGrid 
            dataGridViewQuestions.Enabled = true;
            initializeEmptyBoxes();
            disableBoxes();
            disableOkCancelButtons();
            enableAddModifyDeleteButtons();
            enableLanguageButtons();
        }
        public void enableOkCancelButtons()
        {
            buttonOk.Visible = true;
            buttonCancel.Visible = true;
        }
        public void disableOkCancelButtons()
        {
            // Disable buttons
            buttonOk.Visible = false;
            buttonCancel.Visible = false;
        }
        public void enableBoxes()
        {
            // Enable boxes
            textBoxQuestionDescription.ReadOnly = false;
            textBoxCorrectAnswer.ReadOnly = false;
            textBoxIncorrectAnswer1.ReadOnly = false;
            textBoxIncorrectAnswer2.ReadOnly = false;
            textBoxIncorrectAnswer3.ReadOnly = false;
            comboBoxCategoryDescription.Enabled = true;
            comboBoxDifficultDescription.Enabled = true;
        }
        public void disableBoxes()
        {
            // Disable boxes
            textBoxQuestionDescription.ReadOnly = true;
            textBoxCorrectAnswer.ReadOnly = true;
            textBoxIncorrectAnswer1.ReadOnly = true;
            textBoxIncorrectAnswer2.ReadOnly = true;
            textBoxIncorrectAnswer3.ReadOnly = true;

        }

        public void initializeEmptyBoxes()
        {
            // Initialize empty boxes
            textBoxIdDescription.Text = "";
            textBoxQuestionDescription.Text = "";
            textBoxCorrectAnswer.Text = "";
            textBoxIncorrectAnswer1.Text = "";
            textBoxIncorrectAnswer2.Text = "";
            textBoxIncorrectAnswer3.Text = "";
            comboBoxCategoryDescription.SelectedIndex = -1;
            comboBoxDifficultDescription.SelectedIndex = -1;
            comboBoxCategoryDescription.Enabled = false;
            comboBoxDifficultDescription.Enabled = false;
        }

        private void buttonCatala_Click(object sender, EventArgs e)
        {
            saveSheet();
            currentSheet = "CA";
            changeSheets();
        }

        private void buttonEspañol_Click(object sender, EventArgs e)
        {
            saveSheet();
            currentSheet = "ES";
            changeSheets();
        }

        private void buttonEnglish_Click(object sender, EventArgs e)
        {
            saveSheet();
            currentSheet = "EN";
            changeSheets();
        }

        private void FormQuestions_Load(object sender, EventArgs e)
        {
            labelActualUserData.Text = user.username.ToString() + " " + user.type.ToString();
            userType(user);
            quizQuestionsBindingSource.DataSource = DataUtilities.ToDataTable(quizQuestions);
            dataGridViewQuestions.DataSource = quizQuestionsBindingSource;
        }

        private void FormQuestions_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Program.changingForms)
            {
                Application.Exit();
            }
        }

        private void changeLanguageES()
        {
            // Change Description
            labelQuestionDescription.Text = "Pregunta";
            labelCorrectAnswerDescription.Text = "Respuesta correcta";
            labelIncorrectAnswer1Description.Text = "Respuesta incorrecta";
            labelIncorrectAnswer2Description.Text = "Respuesta incorrecta";
            labelIncorrectAnswer3Description.Text = "Respuesta incorrecta";
            labelCategoryDescription.Text = "Categoría";
            labelDifficultyDescription.Text = "Dificultad";
            // Change ADD, MODIFY, DELETE buttons
            buttonAdd.Text = "Añadir";
            buttonModify.Text = "Modificar";
            buttonDelete.Text = "Eliminar";
            // Change OK, CANCEL buttons
            buttonOk.Text = "Guardar";
            buttonCancel.Text = "Cancelar";
            // Change CategoryComboBox Items
            comboBoxCategoryDescription.Items.Clear();
            comboBoxCategoryDescription.Items.Add("Ciencia Ficción");
            comboBoxCategoryDescription.Items.Add("Acción");
            comboBoxCategoryDescription.Items.Add("Comedia");
            comboBoxCategoryDescription.Items.Add("Terror");
            comboBoxCategoryDescription.Items.Add("Animación");
            comboBoxCategoryDescription.Items.Add("Drama");
            // Change DiffultyComboBox Items
            comboBoxDifficultDescription.Items.Clear();
            comboBoxDifficultDescription.Items.Add("Fácil");
            comboBoxDifficultDescription.Items.Add("Media");
            comboBoxDifficultDescription.Items.Add("Difícil");
            comboBoxDifficultDescription.Items.Add("Leyenda");

            // Filter Items
            comboBoxFilter.Items.Clear();
            for (int i = 0; i < comboBoxCategoryDescription.Items.Count; i++)
            {
                comboBoxFilter.Items.Add(comboBoxCategoryDescription.Items[i].ToString());
            }

            // Change FilterComboBox language
            labelFilter.Text = "Filtro";
            buttonApplyFilter.Text = "Aplicar filtro";
            buttonClearFilter.Text = "Limpiar filtro";
        }
        private void changeLanguageEN()
        {
            // Change Description
            labelQuestionDescription.Text = "Question";
            labelCorrectAnswerDescription.Text = "Correct answer";
            labelIncorrectAnswer1Description.Text = "Incorrect answer";
            labelIncorrectAnswer2Description.Text = "Incorrect answer";
            labelIncorrectAnswer3Description.Text = "Incorrect answer";
            labelCategoryDescription.Text = "Category";
            labelDifficultyDescription.Text = "Dificulty";
            // Change ADD, MODIFY, DELETE buttons
            buttonAdd.Text = "Add";
            buttonModify.Text = "Modify";
            buttonDelete.Text = "Delete";
            // Change OK, CANCEL buttons
            buttonOk.Text = "Save";
            buttonCancel.Text = "Cancel";
            // Change CategoryComboBox Items
            comboBoxCategoryDescription.Items.Clear();
            comboBoxCategoryDescription.Items.Add("Science Fiction");
            comboBoxCategoryDescription.Items.Add("Action");
            comboBoxCategoryDescription.Items.Add("Comedy");
            comboBoxCategoryDescription.Items.Add("Horror");
            comboBoxCategoryDescription.Items.Add("Animation");
            comboBoxCategoryDescription.Items.Add("Drama");
            // Change DiffultyComboBox Items
            comboBoxDifficultDescription.Items.Clear();
            comboBoxDifficultDescription.Items.Add("Easy");
            comboBoxDifficultDescription.Items.Add("Medium");
            comboBoxDifficultDescription.Items.Add("Hard");
            comboBoxDifficultDescription.Items.Add("Legend");
            // Filter Items
            comboBoxFilter.Items.Clear();
            for (int i = 0; i < comboBoxCategoryDescription.Items.Count; i++)
            {
                comboBoxFilter.Items.Add(comboBoxCategoryDescription.Items[i].ToString());
            }
            // Change FilterComboBox language
            labelFilter.Text = "Filter";
            buttonApplyFilter.Text = "Apply filter";
            buttonClearFilter.Text = "Clear filter";
        }
        private void changeLanguageCA()
        {
            // Change Description
            labelQuestionDescription.Text = "Pregunta";
            labelCorrectAnswerDescription.Text = "Resposta correcta";
            labelIncorrectAnswer1Description.Text = "Resposta incorrecta";
            labelIncorrectAnswer2Description.Text = "Resposta incorrecta";
            labelIncorrectAnswer3Description.Text = "Resposta incorrecta";
            labelCategoryDescription.Text = "Categoria";
            labelDifficultyDescription.Text = "Dificultat";
            // Change ADD, MODIFY, DELETE buttons
            buttonAdd.Text = "Afegir";
            buttonModify.Text = "Modificar";
            buttonDelete.Text = "Eliminar";
            // Change OK, CANCEL buttons
            buttonOk.Text = "Guardar";
            buttonCancel.Text = "Cancelar";
            // Change CategoryComboBox Items
            comboBoxCategoryDescription.Items.Clear();
            comboBoxCategoryDescription.Items.Add("Ciència Ficció");
            comboBoxCategoryDescription.Items.Add("Acció");
            comboBoxCategoryDescription.Items.Add("Comedia");
            comboBoxCategoryDescription.Items.Add("Terror");
            comboBoxCategoryDescription.Items.Add("Animació");
            comboBoxCategoryDescription.Items.Add("Drama");
            // Change DiffultyComboBox Items
            comboBoxDifficultDescription.Items.Clear();
            comboBoxDifficultDescription.Items.Add("Fàcil");
            comboBoxDifficultDescription.Items.Add("Mitja");
            comboBoxDifficultDescription.Items.Add("Difícil");
            comboBoxDifficultDescription.Items.Add("Llegenda");
            
            // Filter Items
            comboBoxFilter.Items.Clear();
            for (int i = 0; i < comboBoxCategoryDescription.Items.Count; i++)
            {
                comboBoxFilter.Items.Add(comboBoxCategoryDescription.Items[i].ToString());
            }
            // Change FilterComboBox language
            labelFilter.Text = "Filtre";
            buttonApplyFilter.Text = "Aplicar filtre";
            buttonClearFilter.Text = "Netejar filtre";
        }
        private void enableAddModifyDeleteButtons()
        {
            buttonAdd.Enabled = true;
            buttonModify.Enabled = true;
            buttonDelete.Enabled = true;
        }
        private void disableAddModifyDeleteButtons()
        {
            buttonAdd.Enabled = false;
            buttonModify.Enabled = false;
            buttonDelete.Enabled = false;
        }
        private void enableLanguageButtons()
        {
            buttonCatala.Enabled = true;
            buttonEspañol.Enabled = true;
            buttonEnglish.Enabled = true;
        }
        private void disableLanguageButtons()
        {
            buttonCatala.Enabled = false;
            buttonEspañol.Enabled = false;
            buttonEnglish.Enabled = false;
        }

        private void buttonApplyFilter_Click(object sender, EventArgs e)
        {
            isFiltered = true;

            tempQuizQuestions.Clear();
            dataGridViewQuestions.CurrentCell = null;

            string categoria = comboBoxFilter.Text.ToLower();
            int id = 0, difficulty = 0;

           
            if (comboBoxFilter.Text != "")
            {
                tempQuizQuestions = quizQuestions.Where(i => i.category == categoria).ToList();
                var listBinding = new BindingList<QuizQuestion>(tempQuizQuestions);
                quizQuestionsBindingSource.DataSource = DataUtilities.ToDataTable(tempQuizQuestions);
                dataGridViewQuestions.DataSource = quizQuestionsBindingSource;
            }
        }

        private void gestionarPersonatgesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCharacters formCharacters = new FormCharacters(user);
            formCharacters.Show();
            Program.changingForms = true;
            this.Close();
            Program.changingForms = false;

        }

        private void buttonClearFilter_Click(object sender, EventArgs e)
        {
            comboBoxFilter.SelectedIndex = -1;
            isFiltered = false;
            for (int i = 0; i < quizQuestions.Count; ++i)
            {

                dataGridViewQuestions.CurrentCell = null;
                dataGridViewQuestions.DataSource = quizQuestions;

            }
            
        }


        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void userType(UserDesktop user)
        {
            switch (user.type)
            {
                case "user":
                    disableAddModifyDeleteButtons();
                    buttonUsersIcon.Visible = false;
                    buttonAdd.Visible = false;
                    buttonModify.Visible = false;
                    buttonDelete.Visible = false;
                    buttonSave.Visible = false;
                    buttonCharactersIcon.Location = new Point(982, 65);
                    label1.Location = new Point(975, 138);
                    label2.Visible = false;
                    label3.Visible = false;

                    break;
                case "admin":
                    buttonUsersIcon.Visible = false;
                    buttonSave.Location = new Point(982, 65);
                    label3.Location = new Point(991, 138);
                    label2.Visible = false;
                    break;
                default:
                    
                    break;
            }
        }

        private void buttonCharactersIcon_Click(object sender, EventArgs e)
        {
            FormCharacters formCharacters = new FormCharacters(user);
            formCharacters.Show();
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveJSON();
        }

        private void FormQuestions_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dataGridViewQuestions_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string value = dataGridViewQuestions.CurrentRow.Cells[1].Value.ToString();
            int id = 0, difficulty = 0;
            String category = "", question = "", correctAnswer = "", incorrectAnswer1 = "", incorrectAnswer2 = "", incorrectAnswer3 = "";

            foreach (QuizQuestion idQuestion in quizQuestions.Where(i => i.question == value))
            {
                id = idQuestion.id;
                category = idQuestion.category;
                question = idQuestion.question;
                correctAnswer = idQuestion.correct_answer;
                incorrectAnswer1 = idQuestion.incorrect_answers[0];
                incorrectAnswer2 = idQuestion.incorrect_answers[1];
                incorrectAnswer3 = idQuestion.incorrect_answers[2];
                difficulty = idQuestion.difficulty;
                comboBoxDifficultDescription.SelectedIndex =difficulty - 1;
               
            }

            textBoxIdDescription.Text = id.ToString();
            textBoxQuestionDescription.Text = question;
            textBoxCorrectAnswer.Text = correctAnswer;
            textBoxIncorrectAnswer1.Text = incorrectAnswer1;
            textBoxIncorrectAnswer2.Text = incorrectAnswer2;
            textBoxIncorrectAnswer3.Text = incorrectAnswer3;

           


                switch (category)
            {
                case "science fiction":
                    comboBoxCategoryDescription.SelectedIndex = 0;
                    break;
                case "action":
                    comboBoxCategoryDescription.SelectedIndex = 1;
                    break;
                case "comedy":
                    comboBoxCategoryDescription.SelectedIndex = 2;
                    break;
                case "horror":
                    comboBoxCategoryDescription.SelectedIndex = 3;
                    break;
                case "animation":
                    comboBoxCategoryDescription.SelectedIndex = 4;
                    break;
                case "drama":
                    comboBoxCategoryDescription.SelectedIndex = 5;
                    break;
                default:
                    comboBoxCategoryDescription.SelectedIndex = -1;
                    break;
            }
        }
    }
}

