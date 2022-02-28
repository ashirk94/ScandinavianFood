using ScandinavianFood.Models;
using Xunit;

namespace UnitTests
{
    public class QuizTests
    {
        [Fact]
        public void TestNumCorrect()
        {
            var quiz = new QuizVM()
            {
                //wrong answers
                Question1 = "A",
                Question2 = "C",
                Question3 = "B"
            };

            quiz.NumCorrect();
            Assert.True(quiz.Score == 0);

            //right answers
            quiz.Question1 = "D";
            quiz.Question2 = "B";
            quiz.Question3 = "A";
            quiz.NumCorrect();

            Assert.True(quiz.Score == 3);
        }
    }
}
