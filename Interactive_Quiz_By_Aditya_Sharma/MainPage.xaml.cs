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
        if (_currentQuestionIndex <= 5)
        {
            Option1.Text = _quiz.OnOption1();
            Option2.Text = _quiz.OnOption2();
            Option3.Text = _quiz.OnOption3();
            Option4.Text = _quiz.OnOption4();
            userAnswer = _quiz.ForAnswer();
        }
        if (_currentQuestionIndex > 5)
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


        if (_quiz.CheckUserAnswer( userAnswer))
        {
            Option1.BackgroundColor = Colors.Green;
        }
        else
        {
            Option1.BackgroundColor = Colors.Red;
        }
        Option4.IsVisible = false;
        Option2.IsVisible = false;
        Option3.IsVisible = false;


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

        if (_quiz.CheckUserAnswer(userAnswer))
        {
            Option2.BackgroundColor = Colors.Green;
        }
        else
        {
            Option2.BackgroundColor = Colors.Red;
        }
        Option1.IsVisible = false;
        Option3.IsVisible = false;
        Option4.IsVisible = false;

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


        if (_quiz.CheckUserAnswer(userAnswer))
        {
            Option3.BackgroundColor = Colors.Green;

        }
        else
        {
            Option3.BackgroundColor = Colors.Red;
        }
        Option1.IsVisible = false;
        Option2.IsVisible = false;
        Option4.IsVisible = false;


    }
    private void OnOption4Clicked(object sender, EventArgs e)
    {
        userAnswer = _quiz.OnOption4();


        if (_quiz.CheckUserAnswer(userAnswer))
        {
            Option4.BackgroundColor = Colors.Green;
        }
        else
        {
            Option4.BackgroundColor = Colors.Red;
        }
        Option1.IsVisible = false;
        Option2.IsVisible = false;
        Option3.IsVisible = false;





    }
    private void OnNextClicked(object sender, EventArgs e)
    {

        if (_quiz.GetCurrentques() == 10)
        {

            DisplayAlert("Score", $"You scored {_quiz.Score} out of {_quiz.GetCurrentques()} questions. You got {_quiz.Point} points out of {_quiz.ForTotalPoints()}", "OK");

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
}

