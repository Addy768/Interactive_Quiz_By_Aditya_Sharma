using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Quiz_By_Aditya_Sharma
{
    public class TrueFalseQuestion : Question
    {
        private string[] options; //declares the options variable as a private array of strings

        public TrueFalseQuestion() { }

        public TrueFalseQuestion(string ques, string ans, int point, string[] option)
        {
            this.QuestionText = ques; //The first property, QuestionText, is a string that holds the text of the question.
            this.CorrectAnswer = ans; // is a string that holds the correct answer to the question
            this.Points= point; //is an integer that holds the number of points the question is worth
            this.options= option; //is an array of strings that holds the available options
        }
    }
}
