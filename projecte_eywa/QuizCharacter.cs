using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecte_eywa
{

    public class QuizCharacter
    {

        public String name { get; set; }
        public String film { get; set; }
        public String category { get; set; }
        public String difficulty { get; set; }
        public decimal num_correct  { get; set; }
        public String image { get; set; }
        public String description_cat { get; set; }
        public String description_esp { get; set; }
        public String description_eng { get; set; }


        public QuizCharacter()
        {

        }


        public QuizCharacter(String nameCharacter, String filmCharacter, String categoryCharacter, String difficultyCharacter, int correctNumCharacter, String urlImageCharacter, String descCharacterEsp, String descCharacterEng, String descCharacterCat)
        {
            this.name = nameCharacter;
            this.film = filmCharacter;
            this.category = categoryCharacter;
            this.difficulty = difficultyCharacter;
            this.num_correct = correctNumCharacter;
            this.image = urlImageCharacter;
            this.description_esp = descCharacterEsp;
            this.description_eng = descCharacterEng;
            this.description_cat = descCharacterCat;

        }

       
    }
   
}
