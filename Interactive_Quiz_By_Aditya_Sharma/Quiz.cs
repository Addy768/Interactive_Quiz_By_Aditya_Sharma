using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Quiz_By_Aditya_Sharma
{
    public class Quiz
    {
        //Quiz _quiz = new Quiz("My Quiz");
        //private List<MultipleChoiceQuestion> _questionList1 = new List<MultipleChoiceQuestion>();
        //private List<TrueFalseQuestion> _questionList2 = new List<TrueFalseQuestion>();
        private List<Question> _questionList = new List<Question>();
        private int _currentQuestionIndex = -1;
        private string _title;
        private int _score;
        public int _point;
        //private MultipleChoiceQuestion quesWithOptions = new MultipleChoiceQuestion();
        //private TrueFalseQuestion tfQuesWithOptions = new TrueFalseQuestion();

        public string Title
        {
            get
            { 
                return _title; 
            }
            set
            {
                _title = value;
            }
        }

        public int Score
        {
            get 
            {
                return _score;
            }
             set
            {
                _score = value;
            }
        }

        public int Point { 
            get
            {
                return _point;  

            } 
            set
            {
                _point = value; 
            } 
        }

        public Quiz(string title)
        {
            _title = title;
            //_questionList = new List<Question>();
            LoadQuestions();
        }

        
         private void LoadQuestions()
         {
             // Add 5 multiple choice questions
             _questionList.Add(new MultipleChoiceQuestion("Which country held 2022 football worldcup?", "Qatar", 1, new string[] { "USA", "China", "Canada", "Qatar" }));
             _questionList.Add(new MultipleChoiceQuestion("What is the nation capital of India ?", "Delhi", 1, new string[] { "Maharashtra", "Rajasthan", "Kerala" }));
             _questionList.Add(new MultipleChoiceQuestion("Which is the largest mammal?", "Blue Whale", 1, new string[] { "Elephant", "Giraffe", "Hippopotamus" }));
             _questionList.Add(new MultipleChoiceQuestion("What team won 2022 football worldcup ?", "Argentina", 1, new string[] { "Germany", "France", "Morocco" }));
             _questionList.Add(new MultipleChoiceQuestion("Which country is known as land of maple syrup", "Canada", 1, new string[] { "Chine", "USA", "Russia" }));

          
            // Add 5 true/false questions
            _questionList.Add(new TrueFalseQuestion("The Great Wall of China is visible from space.", "false", 1, new string[] { "true", "false" }));
            _questionList.Add(new TrueFalseQuestion("The human body has three lungs.", "false", 1, new string[] { "true", "false" }));
            _questionList.Add(new TrueFalseQuestion("The Earth is square.", "false", 1, new string[] { "true", "false" }));
            _questionList.Add(new TrueFalseQuestion("The Statue of Liberty is in Germany.", "false", 1, new string[] { "true", "false" }));
            _questionList.Add(new TrueFalseQuestion("The sun rises in the east and sets in the west.", "true", 1, new string[] { "true", "false" }));
        }
        
        public String OnOption1()
        {
            MultipleChoiceQuestion question = (MultipleChoiceQuestion)_questionList[_currentQuestionIndex];
            String option = question.options[0];
            return option;
        }
        public String OnOption2()
        {
            MultipleChoiceQuestion question = (MultipleChoiceQuestion)_questionList[_currentQuestionIndex];
            String option = question.options[1];
            return option;
        }
        public String OnOption3()
        {
            MultipleChoiceQuestion question = (MultipleChoiceQuestion)_questionList[_currentQuestionIndex];
            String option = question.options[2];
            return option;
        }
        public String OnOption4()
        {
            MultipleChoiceQuestion question = (MultipleChoiceQuestion)_questionList[_currentQuestionIndex];
            String option = question.options[3];
            return option;
        }
        
        public int GetCurrentques()
        {
            return _currentQuestionIndex;
        }
//loads the question with the option of the question with answer being blank
        private Question GetQuestionWithoutAnswer()
        {
            if (_currentQuestionIndex < _questionList.Count())
            {
                Question question = _questionList[_currentQuestionIndex];
                Question _questionWithoutAnswer = new Question
                {
                    QuestionText = question.QuestionText,
                    Points = question.Points,

                    CorrectAnswer = "",
                };

                return _questionWithoutAnswer;

            }
            else
            {
                throw new Exception("No More Questions available please");

            }

        }
        public Question GetNextQuestion()
        {
            if (_currentQuestionIndex == _questionList.Count())
            {
                throw new Exception("No More Questions Available");
            }


            _currentQuestionIndex++;
            return GetQuestionWithoutAnswer();

        }


        public String ForAnswer()
        {
            if (_currentQuestionIndex <= 5)
            {
                MultipleChoiceQuestion question = (MultipleChoiceQuestion)_questionList[_currentQuestionIndex];
                String options = question.CorrectAnswer;
                return options;
            }
            else
            {
                Question question = _questionList[_currentQuestionIndex];
                String options = question.CorrectAnswer;
                return options;
            }
        }


        public bool CheckUserAnswer( string userAnswer)
        {
            if (_currentQuestionIndex <= 5)
            {
                bool Final = userAnswer == ForAnswer();
                if (Final == true)
                {
                    Score++;
                    
                }

                return Final;

            }
            else
            {
                if (userAnswer == ForAnswer())
                {
                    bool result = true;
                    Score++;
                    
                    return result;
                }

                else
                {
                    bool result = false;
                    return result;
                }

            }




        }
        public int ForTotalPoints()
        {
            int Points = 0;
            for (int i = 0; i < _questionList.Count(); i++)
            {
                Question question = (Question)_questionList[i];
                Points += question.Points;
            }
            return Points;
        }

       


        /* private void LoadQuestions()
         {
             // Add 5 multiple choice questions
             _questionList1.Add(new MultipleChoiceQuestion("Which country held 2022 football worldcup?", "Qatar", 1, new string[] { "USA", "China", "Canada", "Qatar" }));
             _questionList1.Add(new MultipleChoiceQuestion("What is the nation capital of India ?", "Delhi", 1, new string[] { "Maharashtra", "Rajasthan", "Kerala" }));
             _questionList1.Add(new MultipleChoiceQuestion("Which is the largest mammal?", "Blue Whale", 1, new string[] { "Elephant", "Giraffe", "Hippopotamus" }));
             _questionList1.Add(new MultipleChoiceQuestion("What team won 2022 football worldcup ?", "Argentina", 1, new string[] { "Germany", "France", "Morocco" }));
             _questionList1.Add(new MultipleChoiceQuestion("Which country is known as land of maple syrup", "Canada", 1, new string[] { "Chine", "USA", "Russia","Canada" }));

             // Add 5 true/false questions
             _questionList2.Add(new TrueFalseQuestion("The Great Wall of China is visible from space.", "false", 1, new string[] {"true", "false"}));
             _questionList2.Add(new TrueFalseQuestion("The human body has three lungs.", "false", 1, new string[] { "true", "false" }));
             _questionList2.Add(new TrueFalseQuestion("The Earth is square.", "false", 1, new string[] { "true", "false" }));
             _questionList2.Add(new TrueFalseQuestion("The Statue of Liberty is in Germany.", "false", 1, new string[] { "true", "false" }));
             _questionList2.Add(new TrueFalseQuestion("The sun rises in the east and sets in the west.", "true", 1, new string[] { "true", "false" }));

         }*/

        /*
        public Question GetNextQuestion()
        {
            Question currentQues = new Question();
            _currentQuestion++;
            if (_currentQuestion < _questionList1.Count())
            {
                currentQues = GetMCQQuestionWithoutAnswer(_currentQuestion);
            }
            else if (_currentQuestion < (_questionList1.Count() + 5))
            {
                if (_currentQuestion == 5)
                {
                    _currentQuestion = 5;
                }
                currentQues=  GetTFQuestionWithoutAnswer(_currentQuestion - 5);
            }
            else if (_currentQuestion == 10)
            {
                throw new Exception("No More Questions Available");
            }
            return currentQues;
        }
        */

        /* public MultipleChoiceQuestion GetNextQuestion()
         {
             MultipleChoiceQuestion currentQues = new MultipleChoiceQuestion();
             _currentQuestion++;
             if (_currentQuestion < _questionList1.Count())
             {
                 currentQues = GetMCQQuestionWithoutAnswer(_currentQuestion);
             }
             return currentQues;
         }

         private MultipleChoiceQuestion GetMCQQuestionWithoutAnswer(int currentQuestion)
         {

             quesWithOptions.QuestionText = _questionList1[currentQuestion].QuestionText;
             quesWithOptions.Points = _questionList1[currentQuestion].Points;
             quesWithOptions.CorrectAnswer = "";
             quesWithOptions.options = _questionList1[currentQuestion].options;
             return quesWithOptions;
         }

         private TrueFalseQuestion GetTFQuestionWithoutAnswer(int currentQuestion)
         {
             tfQuesWithOptions.QuestionText = _questionList2[currentQuestion].QuestionText;
             tfQuesWithOptions.Points = _questionList2[currentQuestion].Points;
             tfQuesWithOptions.CorrectAnswer = "";
             return tfQuesWithOptions;
         }*/

        //public void CheckUserAnswer(Question question, string userAnswer)
        //{
        //    if(question.CorrectAnswer == userAnswer)
        //    {
        //        Score++;
        //    }
        //}
    }


        //public virtual bool CheckAnswer(string userAnswer)
        //{
        //    //return userAnswer.ToLower() == Answer


}

      