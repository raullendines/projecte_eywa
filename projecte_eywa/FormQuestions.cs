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
        const string PATH = @"..\..\json\" ;
        const string EN_PATH = PATH + "questions_en.json";
        const string ES_PATH = PATH + "questions_es.json";
        const string CA_PATH = PATH + "questions_ca.json";
        BindingList<QuizQuestion> quizQuestions = new BindingList<QuizQuestion>();
        BindingList<QuizQuestion> quizQuestionsEN = new BindingList<QuizQuestion>();
        BindingList<QuizQuestion> quizQuestionsES = new BindingList<QuizQuestion>();
        BindingList<QuizQuestion> quizQuestionsCA = new BindingList<QuizQuestion>();
        string currentSheet = "ES";

        int index = -1;
        List<string> incorrectAnswers = new List<string>();
        bool addQuestion = false;
        bool modifyQuestion = false;
        public FormQuestions()
        {
            InitializeComponent();
            
            getData();
            //saveJSON();
        }

        private void saveJSON()
        {

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

            JArray LoadQuestionsEN = JArray.Parse(File.ReadAllText(EN_PATH, Encoding.Default));
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
            dataGridViewQuestions.DataSource = null;
            dataGridViewQuestions.DataSource = quizQuestions;
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

        private void dataGridViewQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int temporal = index;
            index = dataGridViewQuestions.CurrentCell.RowIndex;
            if (temporal != index)
            {
                textBoxIdDescription.Text = quizQuestions[index].id.ToString();
                textBoxQuestionDescription.Text = quizQuestions[index].question;
                textBoxCorrectAnswer.Text = quizQuestions[index].correct_answer;
                textBoxIncorrectAnswer1.Text = quizQuestions[index].incorrect_answers[0];
                textBoxIncorrectAnswer2.Text = quizQuestions[index].incorrect_answers[1];
                textBoxIncorrectAnswer3.Text = quizQuestions[index].incorrect_answers[2];
                comboBoxCategoryDescription.Text = quizQuestions[index].category;
                comboBoxDifficultDescription.SelectedIndex = quizQuestions[index].difficulty - 1;
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
            disableEditButtons();
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
                question.difficulty = comboBoxDifficultDescription.SelectedIndex + 1;
                question.category = comboBoxCategoryDescription.Text;
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
                        comboBoxCategoryDescription.SelectedIndex = comboBoxCategoryDescription.Items.IndexOf(question.category);
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
                        enableEditButtons();
                        enableLanguageButtons();
                }
               

               

                
            }
            else if (modifyQuestion)
            {
                index = dataGridViewQuestions.CurrentCell.RowIndex;
                quizQuestions[index].question = textBoxQuestionDescription.Text;
                quizQuestions[index].correct_answer = textBoxCorrectAnswer.Text;
                quizQuestions[index].incorrect_answers[0] = textBoxIncorrectAnswer1.Text;
                quizQuestions[index].incorrect_answers[1] = textBoxIncorrectAnswer2.Text;
                quizQuestions[index].incorrect_answers[2] = textBoxIncorrectAnswer3.Text;
                quizQuestions[index].category = comboBoxCategoryDescription.Text;
                quizQuestions[index].difficulty = comboBoxDifficultDescription.SelectedIndex + 1;
                dataGridViewQuestions.DataSource = null;
                dataGridViewQuestions.DataSource = quizQuestions;

                // Enable dataGrid 
                dataGridViewQuestions.Enabled = true;
                initializeEmptyBoxes();
                disableBoxes();
                disableOkCancelButtons();
                enableEditButtons();
                enableLanguageButtons();
                // Disable button
                modifyQuestion = false;
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            // Disable dataGrid 
            dataGridViewQuestions.Enabled = false;
            // Modify button clicked
            modifyQuestion = true;
            enableBoxes();
            enableOkCancelButtons();
            disableEditButtons();
            disableLanguageButtons();


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            index = dataGridViewQuestions.CurrentCell.RowIndex;
            dataGridViewQuestions.Rows.RemoveAt(index);
            disableBoxes();
            initializeEmptyBoxes();
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
            enableEditButtons();
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
        public void enableLanguageButtons()
        {
            buttonCatala.Enabled = true;
            buttonEnglish.Enabled = true;
            buttonEspañol.Enabled = true;
        }
        public void disableLanguageButtons()
        {
            buttonCatala.Enabled = false;
            buttonEnglish.Enabled = false;
            buttonEspañol.Enabled = false;
        }
        public void enableEditButtons()
        {
            buttonAdd.Enabled = true;
            buttonModify.Enabled = true;
            buttonDelete.Enabled = true;
        }
        public void disableEditButtons()
        {
            buttonAdd.Enabled = false;
            buttonModify.Enabled = false;
            buttonDelete.Enabled = false;
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
        private void changeLanguageES()
        {
            // Change description
            labelQuestionDescription.Text = "Pregunta";
            labelCorrectAnswerDescription.Text = "Respuesta \n correcta";
            labelIncorrectAnswer1Description.Text = "Respuesta \n incorrecta";
            labelIncorrectAnswer2Description.Text = "Respuesta \n incorrecta";
            labelIncorrectAnswer3Description.Text = "Respuesta \n incorrecta";
            labelCategoryDescription.Text = "Categoría";
            labelDifficultyDescription.Text = "Dificultad";
            // Change ADD, MODIFY AND DELTE buttons
            buttonAdd.Text = "Añadir";
            buttonModify.Text = "Modificar";
            buttonDelete.Text = "Eliminar";
            // Change OK and Cancel buttons
            buttonCancel.Text = "Cancelar";
            buttonOk.Text = "Guardar";
            // Change Category Collection Items
            comboBoxCategoryDescription.Items.Clear();
            comboBoxCategoryDescription.Items.Add("Ciencia ficción");
            comboBoxCategoryDescription.Items.Add("Acción");
            comboBoxCategoryDescription.Items.Add("Comedia");
            comboBoxCategoryDescription.Items.Add("Animación");
            comboBoxCategoryDescription.Items.Add("Miedo");
            comboBoxCategoryDescription.Items.Add("Drama");
            // Change Diffulty Collection Items
            comboBoxDifficultDescription.Items.Clear();
            comboBoxDifficultDescription.Items.Add("Fácil");
            comboBoxDifficultDescription.Items.Add("Media");
            comboBoxDifficultDescription.Items.Add("Difícil");
            comboBoxDifficultDescription.Items.Add("Leyenda");
        }
        private void changeLanguageEN()
        {
            // Change description
            labelQuestionDescription.Text = "Question";
            labelCorrectAnswerDescription.Text = "Correct \n answer";
            labelIncorrectAnswer1Description.Text = "Incorrect \n answer";
            labelIncorrectAnswer2Description.Text = "Incorrect \n answer";
            labelIncorrectAnswer3Description.Text = "Incorrect \n answer";
            labelCategoryDescription.Text = "Category";
            labelDifficultyDescription.Text = "Difficulty";
            // Change ADD, MODIFY AND DELTE buttons
            buttonAdd.Text = "Add";
            buttonModify.Text = "Modifify";
            buttonDelete.Text = "Delete";
            // Change OK and Cancel buttons
            buttonCancel.Text = "Cancel";
            buttonOk.Text = "Save";
            // Change Category Collection Items
            comboBoxCategoryDescription.Items.Clear();
            comboBoxCategoryDescription.Items.Add("Science Fiction");
            comboBoxCategoryDescription.Items.Add("Action");
            comboBoxCategoryDescription.Items.Add("Comedy");
            comboBoxCategoryDescription.Items.Add("Animation");
            comboBoxCategoryDescription.Items.Add("Horror");
            comboBoxCategoryDescription.Items.Add("Drama");
            // Change Diffulty Collection Items
            comboBoxDifficultDescription.Items.Clear();
            comboBoxDifficultDescription.Items.Add("Easy");
            comboBoxDifficultDescription.Items.Add("Medium");
            comboBoxDifficultDescription.Items.Add("Hard");
            comboBoxDifficultDescription.Items.Add("Legend");
        }
        private void changeLanguageCA()
        {
            // Change description
            labelQuestionDescription.Text = "Pregunta";
            labelCorrectAnswerDescription.Text = "Resposta \n correcta";
            labelIncorrectAnswer1Description.Text = "Resposta \n incorrecta";
            labelIncorrectAnswer2Description.Text = "Resposta \n incorrecta";
            labelIncorrectAnswer3Description.Text = "Resposta \n incorrecta";
            labelCategoryDescription.Text = "Categoria";
            labelDifficultyDescription.Text = "Dificultat";
            // Change ADD, MODIFY AND DELTE buttons
            buttonAdd.Text = "Afegir";
            buttonModify.Text = "Modificar";
            buttonDelete.Text = "Eliminar";
            // Change OK and Cancel buttons
            buttonCancel.Text = "Cancelar";
            buttonOk.Text = "Guardar";
            // Change Category Collection Items
            comboBoxCategoryDescription.Items.Clear();
            comboBoxCategoryDescription.Items.Add("Ciència ficció");
            comboBoxCategoryDescription.Items.Add("Acció");
            comboBoxCategoryDescription.Items.Add("Comedia");
            comboBoxCategoryDescription.Items.Add("Animació");
            comboBoxCategoryDescription.Items.Add("Terror");
            comboBoxCategoryDescription.Items.Add("Drama");
            // Change Diffulty Collection Items
            comboBoxDifficultDescription.Items.Clear();
            comboBoxDifficultDescription.Items.Add("Fàcil");
            comboBoxDifficultDescription.Items.Add("Mitja");
            comboBoxDifficultDescription.Items.Add("Difícil");
            comboBoxDifficultDescription.Items.Add("Llegenda");
        }
    }
}

