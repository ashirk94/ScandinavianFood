using System.ComponentModel.DataAnnotations;

namespace ScandinavianFood.Models
{
    public class QuizState
    {
        public string Answer1 { get; } = "D";

        public string Answer2 { get; } = "B";

        public string Answer3 { get; } = "A";

        [Compare("Answer1", ErrorMessage = "Incorrect")]
        public string Question1 { get; set; } = "";
        [Compare("Answer2", ErrorMessage = "Incorrect")]
        public string Question2 { get; set; } = "";
        [Compare("Answer3", ErrorMessage = "Incorrect")]
        public string Question3 { get; set; } = "";

        public int Score { get; set; } = 0;

        public int NumWrong { get; set; } = 0;

        public int NumCorrect()
        {
            //check all answers
            if (Question1 == Answer1)
            {
                Score++;
            }
            else
            {
                NumWrong++;
            }
            if (Question2 == Answer2)
            {
                Score++;
            }
            else
            {
                NumWrong++;
            }
            if (Question3 == Answer3)
            {
                Score++;
            }
            else
            {
                NumWrong++;
            }
            return Score;
        }
    }
}
