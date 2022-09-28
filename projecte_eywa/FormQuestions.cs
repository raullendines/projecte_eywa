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
    public partial class FormQuestions : Form
    {
        BindingList<QuizQuestion> quizQuestions = new BindingList<QuizQuestion>();
        int index = -1;
        List<string> incorrectAnswers = new List<string>();
        bool addQuestion = false;
        bool modifyQuestion = false;
        public FormQuestions()
        {
            InitializeComponent();
            getData();
        }

        private void getData()
        {
            incorrectAnswers.Add("1");
            incorrectAnswers.Add("2");
            incorrectAnswers.Add("3");

            quizQuestions.Add(new QuizQuestion(1, "Test", 1, "Science Fiction", "a", incorrectAnswers));
            quizQuestions.Add(new QuizQuestion(2, "2Test", 2, "Action", "a", incorrectAnswers));
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
                comboBoxDifficultDescription.Text = quizQuestions[index].difficulty.ToString();
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
                // Enable dataGrid 
                dataGridViewQuestions.Enabled = true;
                initializeEmptyBoxes();
                disableBoxes();

                disableOkCancelButtons();

                // Disable Add button
                addQuestion = false;
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


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            index = dataGridViewQuestions.CurrentCell.RowIndex;
            dataGridViewQuestions.Rows.RemoveAt(index);
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
    }
}

