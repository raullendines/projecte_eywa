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
            JArray QuizQuestionsArray = (JArray)JToken.FromObject(quizQuestions);

            File.WriteAllText(EN_PATH, QuizQuestionsArray.ToString());
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
                    break;
                case "ES":
                    quizQuestions = quizQuestionsES;
                    break;
                case "CA":
                    quizQuestions = quizQuestionsCA;
                    break;
            }
            dataGridViewQuestions.DataSource = null;
            dataGridViewQuestions.DataSource = quizQuestions;
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
            // Enable boxes
            textBoxQuestionDescription.ReadOnly = false;
            textBoxCorrectAnswer.ReadOnly = false;
            textBoxIncorrectAnswer1.ReadOnly = false;
            textBoxIncorrectAnswer2.ReadOnly = false;
            textBoxIncorrectAnswer3.ReadOnly = false;
            comboBoxCategoryDescription.Enabled = true;
            comboBoxDifficultDescription.Enabled = true;
            // Enable buttons
            buttonOk.Visible = true;
            buttonCancel.Visible = true;


        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (addQuestion)
            {
                int last = quizQuestions.Last().id + 1;
                String newId = last.ToString();
                textBoxIdDescription.Text = newId;
                List<string> ListIncorrects = new List<string>();
                ListIncorrects.Add(textBoxIncorrectAnswer1.Text);
                ListIncorrects.Add(textBoxIncorrectAnswer2.Text);
                ListIncorrects.Add(textBoxIncorrectAnswer3.Text);

                quizQuestions.Add(new QuizQuestion(
                    last,
                    textBoxQuestionDescription.Text,
                    comboBoxDifficultDescription.SelectedIndex + 1,
                    comboBoxCategoryDescription.Text,
                    textBoxCorrectAnswer.Text,
                    ListIncorrects
                    ));
                // Disable dataGrid 
                dataGridViewQuestions.Enabled = true;
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
                // Disable boxes
                textBoxQuestionDescription.ReadOnly = true;
                textBoxCorrectAnswer.ReadOnly = true;
                textBoxIncorrectAnswer1.ReadOnly = true;
                textBoxIncorrectAnswer2.ReadOnly = true;
                textBoxIncorrectAnswer3.ReadOnly = true;

                // Enable buttons
                buttonOk.Visible = false;
                buttonCancel.Visible = false;

                // Disable Add button
                addQuestion = false;
            }
            else if (modifyQuestion)
            {



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
            // Enable boxes
            textBoxQuestionDescription.ReadOnly = false;
            textBoxCorrectAnswer.ReadOnly = false;
            textBoxIncorrectAnswer1.ReadOnly = false;
            textBoxIncorrectAnswer2.ReadOnly = false;
            textBoxIncorrectAnswer3.ReadOnly = false;
            comboBoxCategoryDescription.Enabled = true;
            comboBoxDifficultDescription.Enabled = true;
            // Enable buttons
            buttonOk.Visible = true;
            buttonCancel.Visible = true;


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            index = dataGridViewQuestions.CurrentCell.RowIndex;
            dataGridViewQuestions.Rows.RemoveAt(index);
        }

        private void buttonCatala_Click(object sender, EventArgs e)
        {
            currentSheet = "CA";
            changeSheets();
        }

        private void buttonEspañol_Click(object sender, EventArgs e)
        {
            currentSheet = "ES";
            changeSheets();
        }

        private void buttonEnglish_Click(object sender, EventArgs e)
        {
            currentSheet = "EN";
            changeSheets();
        }
    }
}

