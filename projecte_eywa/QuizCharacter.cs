using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecte_eywa
{

    public class QuizCharacter
    {

        public String nameCharacter { get; set; }
        public String filmCharacter { get; set; }
        public String categoryCharacter { get; set; }
        public String difficultyCharacter { get; set; }
        public decimal correctNumCharacter  { get; set; }
        public String urlImageCharacter { get; set; }
        public String descCharacter { get; set; }
       
        public QuizCharacter()
        {

        }


        public QuizCharacter(String nameCharacter, String filmCharacter, String categoryCharacter, String difficultyCharacter, int correctNumCharacter, String urlImageCharacter, String descCharacter)
        {
            this.nameCharacter = nameCharacter;
            this.filmCharacter = filmCharacter;
            this.categoryCharacter = categoryCharacter;
            this.difficultyCharacter = difficultyCharacter;
            this.correctNumCharacter = correctNumCharacter;
            this.urlImageCharacter = urlImageCharacter;
            this.descCharacter = descCharacter;
        }

       
    }
   
}
