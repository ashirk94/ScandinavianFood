using System;
using Xunit;
using ScandinavianFood.Models;

namespace UnitTests
{
    public class QuizTest
    {
        [Fact]
        public void TestNumCorrect()
        {
            var quiz = new QuizState();

            //wrong answers
            quiz.Answer1 = "A";
            quiz.Answer2 = "C";
            quiz.Answer3 = "B";
            quiz.NumCorrect();
            Assert.True(quiz.Score == 0);

            //right answers
            quiz.Answer1 = "D";
            quiz.Answer2 = "B";
            quiz.Answer3 = "A";
            quiz.NumCorrect();

            Assert.True(quiz.Score == 3);
        }
    }
}
