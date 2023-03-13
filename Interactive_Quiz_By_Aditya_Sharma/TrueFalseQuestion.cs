using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Quiz_By_Aditya_Sharma
{
    public class TrueFalseQuestion : Question
    {
        private string[] options;

        public TrueFalseQuestion() { }

        public TrueFalseQuestion(string ques, string ans, int point, string[] option)
        {
            this.QuestionText = ques;
            this.CorrectAnswer = ans;
            this.Points= point;
            this.options= option;
        }
    }
}
