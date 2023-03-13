using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Quiz_By_Aditya_Sharma
{
    public class Question
    {//question mein autoproperty lagani h
        public string QuestionText
        {
            get;
            set;
        }
        public int Points
        {
            get;
            set;
        }
        public string CorrectAnswer
        {
            get;
            set;
        }

        //public Question(string questionText, string correctAnswer)
        //{
        //    QuestionText = questionText;
        //    CorrectAnswer = correctAnswer;
        //} 
              

             
    }
}
