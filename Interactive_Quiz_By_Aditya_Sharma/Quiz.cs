using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Quiz_By_Aditya_Sharma
{
    public class Quiz
    {
      
        private List<Question> _questionList = new List<Question>(); //initiating list
        private int _currentQuestionIndex = -1; //initialising index with -1
        private string _title; //title of the quiz
        private int _score; // variabkle to score final score
        
      
        //Getter setter for Title
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

        //Getter setter for Score
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


        // Method to load the quiz
        public Quiz(string title)
        {
            _title = title;
            //_questionList = new List<Question>();
            LoadQuestions();
        }

        // Method to add all questions in list
        private void LoadQuestions()
        {
            // Add 5 multiple choice questions
            _questionList.Add(new MultipleChoiceQuestion("Which country held 2022 football worldcup?", "Qatar", 1, new string[] { "USA", "China", "Canada", "Qatar" }));
            _questionList.Add(new MultipleChoiceQuestion("What is the nation capital of India ?", "Delhi", 1, new string[] { "Maharashtra", "Rajasthan", "Kerala", "Delhi" }));
            _questionList.Add(new MultipleChoiceQuestion("Which is the largest mammal?", "Blue Whale", 1, new string[] { "Elephant", "Giraffe", "Blue Whale", "Hippopotamus" }));
            _questionList.Add(new MultipleChoiceQuestion("What team won 2022 football worldcup ?", "Argentina", 1, new string[] { "Argentina", "Germany", "France", "Morocco" }));
            _questionList.Add(new MultipleChoiceQuestion("Which country is known as land of maple syrup", "Canada", 1, new string[] { "Chine", "Canada", "USA", "Russia" }));

            // Add 5 true/false questions
            _questionList.Add(new TrueFalseQuestion("The Great Wall of China is visible from space.", "False", 1, new string[] { "True", "False" }));
            _questionList.Add(new TrueFalseQuestion("The human body has three lungs.", "False", 1, new string[] { "True", "False" }));
            _questionList.Add(new TrueFalseQuestion("The Earth is square.", "False", 1, new string[] { "True", "False" }));
            _questionList.Add(new TrueFalseQuestion("The Statue of Liberty is in Germany.", "False", 1, new string[] { "True", "False" }));
            _questionList.Add(new TrueFalseQuestion("The sun rises in the east and sets in the west.", "True", 1, new string[] { "True", "False" }));
        }

        //Methoda to load next question
        public Question GetNextQuestion()
        {
            if (_currentQuestionIndex == _questionList.Count())
            {
                throw new Exception("No More Questions Available");
            }
            _currentQuestionIndex++;
            return GetQuestionWithoutAnswer(); // Calling GetQuestionWithoutAnswer method to get Question and options and returning it.
        }

        // Retyrning current index of question
        public int GetCurrentques()
        {
            return _currentQuestionIndex;
        }

        // Loads the question present on current index with the options and keeping the answer being blank
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

        //Below 4 methods to load options of current question
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
        
        // Correct answer of current question
        public String ForAnswer()
        {
            if (_currentQuestionIndex <= 4)
            {
                MultipleChoiceQuestion question = (MultipleChoiceQuestion)_questionList[_currentQuestionIndex];
                String option = question.CorrectAnswer;
                return option;
            }
            else
            {
                Question question = _questionList[_currentQuestionIndex];
                String option = question.CorrectAnswer;
                return option;
            }
        }

        // Method to compare user answer with actual answer and increases the score accordingly
        public bool CheckUserAnswer( string userAnswer)
        {
            // Comapre answer for MCQ questons
            if (_currentQuestionIndex <= 4)
            {
                bool Final = userAnswer == ForAnswer();
                if (Final == true)
                {
                    Score++;
                }
                return Final;
            }
            // Comapre answer for True/False questons
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
    }
}

      