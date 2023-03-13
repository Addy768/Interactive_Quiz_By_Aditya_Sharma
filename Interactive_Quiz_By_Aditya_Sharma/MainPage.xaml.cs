namespace Interactive_Quiz_By_Aditya_Sharma;

public partial class MainPage : ContentPage
{
	public string _correctanswer;
	Quiz _quiz = new Quiz("My Quiz");

	public MainPage()
	{
		InitializeComponent();
       _quiz.Title = title.Text;
        MultipleChoiceQuestion ques = _quiz.GetNextQuestion();
        Console.WriteLine("Result fo Next Ques method ::::: " +ques);
        question.Text = ques.QuestionText;
        Option1.Text = ques.options[0];
        Option2.Text = ques.options[1];
        Option3.Text = ques.options[2];
        Option4.Text = ques.options[3];

    }

    //private void OnCounterClicked(object sender, EventArgs e)
    //{

    //}

    private void OnOption1Clicked(object sender, EventArgs e)
    {
        //_correctanswer = question.Text;

        //SemanticScreenReader.Announce(Option1.Text);

    }


    private void OnOption2Clicked(object sender, EventArgs e)
    {
        

    }
    private void OnOption3Clicked(object sender, EventArgs e)
    {
   

    }
    private void OnOption4Clicked(object sender, EventArgs e)
    {
      

    }
}

