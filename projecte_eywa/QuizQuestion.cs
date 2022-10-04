using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecte_eywa
{
    public class QuizQuestion
    {

        public int id { get; set; }
        public string question { get; set; }
        public int difficulty { get; set; }
        public string category { get; set; }
        public string correct_answer { get; set; }
        public List<string> incorrect_answers { get; set; }

        public QuizQuestion(int id, string question, int difficulty, string category, string correctAnswer, List<string> incorrectAnswer)
        {
            this.id = id;
            this.question = question;
            this.difficulty = difficulty;
            this.category = category;
            this.correct_answer = correctAnswer;
            this.incorrect_answers = incorrectAnswer;
        }
        public QuizQuestion() { }
    }
}
