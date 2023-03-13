using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Quiz_By_Aditya_Sharma
{
    public class MultipleChoiceQuestion : Question
    {

        public string[] options;

        public MultipleChoiceQuestion() { }

        public MultipleChoiceQuestion(string ques, string ans, int point, string[] strings)
        {
            this.QuestionText = ques;
            this.CorrectAnswer = ans;
            this.Points = point;
            this.options = strings;
        }




    }
}
