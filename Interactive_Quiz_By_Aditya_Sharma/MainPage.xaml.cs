using System.Diagnostics;

namespace Interactive_Quiz_By_Aditya_Sharma;

public partial class MainPage : ContentPage
{
	public string _correctanswer;
	Quiz _quiz = new Quiz("My Quiz");
    public string userAnswer;


	public MainPage()
	{
		InitializeComponent();
       _quiz.Title = title.Text;
        _quiz.Title = "GENERAL KNOWLEDGE";
        title.Text = _quiz.Title;
        GetQuestion();
        GetOptions();


    }

    public void GetQuestion()
    {
        Question ques = _quiz.GetNextQuestion();
        question.Text = ques.QuestionText;
    }



    public void GetOptions()
    {
        String userAnswer;
        int _currentQuestionIndex = _quiz.GetCurrentques();
        if (_currentQuestionIndex <= 4)
        {
            Option1.Text = _quiz.OnOption1();
            Option2.Text = _quiz.OnOption2();
            Option3.Text = _quiz.OnOption3();
            Option4.Text = _quiz.OnOption4();
            userAnswer = _quiz.ForAnswer();
        }
        if (_currentQuestionIndex > 4)
        {
            Option1.IsVisible = false;
            Option2.Text = "True";
            Option3.Text = "False";
            Option4.IsVisible = false;
            userAnswer = _quiz.ForAnswer();
        }

    }

    private void OnOption1Clicked(object sender, EventArgs e)
    {

        userAnswer = _quiz.OnOption1();


        bool isUserAnswerCorrect = _quiz.CheckUserAnswer(userAnswer);
        Option1.BackgroundColor = isUserAnswerCorrect ? Colors.Green : Colors.Red; //ternary operator

        Option4.IsEnabled = false;
        Option2.IsEnabled = false;
        Option3.IsEnabled = false;


    }


    private void OnOption2Clicked(object sender, EventArgs e)
    {
        if (_quiz.GetCurrentques() <= 4)
        {
            userAnswer = _quiz.OnOption2();
        }
        else
        {
            userAnswer = "True";
        }

        bool isUserAnswerCorrect = _quiz.CheckUserAnswer(userAnswer);
        Option2.BackgroundColor = isUserAnswerCorrect ? Colors.Green : Colors.Red;

        Option1.IsEnabled = false;
        Option3.IsEnabled = false;
        Option4.IsEnabled = false;

    }
    private void OnOption3Clicked(object sender, EventArgs e)
    {
        if (_quiz.GetCurrentques() <= 4)
        {
            userAnswer = _quiz.OnOption3();
        }
        else
        {
            userAnswer = "False";
        }

        bool isUserAnswerCorrect = _quiz.CheckUserAnswer(userAnswer);
        Option3.BackgroundColor = isUserAnswerCorrect ? Colors.Green : Colors.Red;

        Option1.IsEnabled = false;
        Option2.IsEnabled = false;
        Option4.IsEnabled = false;


    }
    private void OnOption4Clicked(object sender, EventArgs e)
    {
        userAnswer = _quiz.OnOption4();


        bool isUserAnswerCorrect = _quiz.CheckUserAnswer(userAnswer);
        Option4.BackgroundColor = isUserAnswerCorrect ? Colors.Green : Colors.Red;
        
        Option1.IsEnabled = false;
        Option2.IsEnabled = false;
        Option3.IsEnabled = false;





    }
    //Button exitButton = new Button
    //{
    //    Text = "Exit"
    //};

    private void OnNextClicked(object sender, EventArgs e)
    {

        if (_quiz.GetCurrentques() == 9)
        {

            DisplayAlert("Score", $"You scored {_quiz.Score} out of {_quiz.GetCurrentques() +1} questions.", "OK");

        }
        else
        {
            GetQuestion();
            GetOptions();
            Resetebtn();

        }



    }
    public void Resetebtn()
    {
        Button[] buttons = { Option1, Option2, Option3, Option4 };

        foreach (Button button in buttons)
        {
            button.BackgroundColor = Colors.White;
            button.IsEnabled = true;
        }
    }
    private void OnExitClicked(object sender, EventArgs e)
    {
        Application.Current?.CloseWindow(Application.Current.MainPage.Window);

    }
}

