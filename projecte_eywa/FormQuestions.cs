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
        const string EN_PATH_TEST = PATH + "test_questions_en.json";
        const string ES_PATH = PATH + "questions_es.json";
        const string CA_PATH = PATH + "questions_ca.json";
        
        // LISTS 
        BindingList<QuizQuestion> quizQuestions = new BindingList<QuizQuestion>();
        BindingList<QuizQuestion> quizQuestionsEN = new BindingList<QuizQuestion>();
        BindingList<QuizQuestion> quizQuestionsES = new BindingList<QuizQuestion>();
        BindingList<QuizQuestion> quizQuestionsCA = new BindingList<QuizQuestion>();

        // CURRENT LANGUAGE
        string currentSheet = "EN";

        int index = -1;
        //List<string> incorrectAnswers = new List<string>();
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
            File.WriteAllText(EN_PATH_TEST, QuizQuestionsArrayEN.ToString());
            //JArray QuizQuestionsArrayES = (JArray)JToken.FromObject(quizQuestionsES);
            //File.WriteAllText(ES_PATH, QuizQuestionsArrayES.ToString());
            //JArray QuizQuestionsArrayCA = (JArray)JToken.FromObject(quizQuestionsCA);
            //File.WriteAllText(CA_PATH, QuizQuestionsArrayCA.ToString());
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
            // hacer un booleano para saber si se aplica el filtro, y si se aplica pillar la info desde filtredList (se tiene que probar xd)
            if (temporal != index)
            {
                string category = quizQuestions[index].category;
                textBoxIdDescription.Text = quizQuestions[index].id.ToString();
                textBoxQuestionDescription.Text = quizQuestions[index].question;
                textBoxCorrectAnswer.Text = quizQuestions[index].correct_answer;
                textBoxIncorrectAnswer1.Text = quizQuestions[index].incorrect_answers[0];
                textBoxIncorrectAnswer2.Text = quizQuestions[index].incorrect_answers[1];
                textBoxIncorrectAnswer3.Text = quizQuestions[index].incorrect_answers[2];
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
                comboBoxCategoryDescription.SelectedItem = comboBoxCategoryDescription.SelectedItem.ToString();
                
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
                question.difficulty = comboBoxDifficultDescription.SelectedIndex + 1;
                
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
                enableAddModifyDeleteButtons();
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
            disableAddModifyDeleteButtons();
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
            
        }

        private void FormQuestions_FormClosed(object sender, FormClosedEventArgs e)
        {
            saveJSON();
        }

        private void changeLanguageES()
        {
            // Change Description
            labelQuestionDescription.Text = "Pregunta";
            labelCorrectAnswerDescription.Text = "Respuesta \n correcta";
            labelIncorrectAnswer1Description.Text = "Respuesta \n incorrecta";
            labelIncorrectAnswer2Description.Text = "Respuesta \n incorrecta";
            labelIncorrectAnswer3Description.Text = "Respuesta \n incorrecta";
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
        }
        private void changeLanguageEN()
        {
            // Change Description
            labelQuestionDescription.Text = "Question";
            labelCorrectAnswerDescription.Text = "Correct \n answer";
            labelIncorrectAnswer1Description.Text = "Incorrect \n answer";
            labelIncorrectAnswer2Description.Text = "Incorrect \n answer";
            labelIncorrectAnswer3Description.Text = "Incorrect \n answer";
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
        }
        private void changeLanguageCA()
        {
            // Change Description
            labelQuestionDescription.Text = "Pregunta";
            labelCorrectAnswerDescription.Text = "Resposta \n correcta";
            labelIncorrectAnswer1Description.Text = "Resposta \n incorrecta";
            labelIncorrectAnswer2Description.Text = "Resposta \n incorrecta";
            labelIncorrectAnswer3Description.Text = "Resposta \n incorrecta";
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
            string category =  null;
            if (comboBoxFilter != null && comboBoxFilter.SelectedItem != null)
            {
                int index = comboBoxFilter.Items.IndexOf(comboBoxFilter.SelectedItem);
                switch (index)
                {
                    case 0:
                        category = "science fiction";
                        
                        break;
                    case 1:
                        category= "action";
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
                BindingList<QuizQuestion> quizQuestionsCopy = quizQuestions;
                BindingList<QuizQuestion> filteredList = new BindingList<QuizQuestion>(quizQuestionsCopy.Where(m => m.category.Contains(category) == true).ToList());
                
                dataGridViewQuestions.DataSource = filteredList;


            }
        }
    }
}

