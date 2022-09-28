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
        public string correctAnswer { get; set; }
        public List<string> incorrectAnswer { get; set; }

        public QuizQuestion(int id, string question, int difficulty, string category, string correctAnswer, List<string> incorrectAnswer)
        {
            this.id = id;
            this.question = question;
            this.difficulty = difficulty;
            this.category = category;
            this.correctAnswer = correctAnswer;
            this.incorrectAnswer = incorrectAnswer;
        }
    }
}
