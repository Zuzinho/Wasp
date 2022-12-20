namespace WaspMaui;

public partial class MainPage : ContentPage
{
	private string _rightCode;
	private Button[] _buttons;
	public MainPage()
	{
		InitializeComponent();
		_rightCode = "1234";
		_buttons = new Button[] { Button0, Button1 , Button2, 
			Button3 , Button4 , Button5 ,
            Button6, Button7, Button8 ,
            Button9, ButtonEnter, ButtonAC};

	}

	private void NumberClicked(object sender, EventArgs e)
	{
		PasswordLabel.Text += (sender as Button).Text;
	}

	private void ClearClicked(object sender, EventArgs e)
	{
		PasswordLabel.Text = "";
	}

	private void EnterClicked(object sender, EventArgs e)
	{
		if(_rightCode != PasswordLabel.Text)
		{
			ClearClicked(sender, e);
			return;
		}
		foreach (Button button in _buttons) button.IsEnabled = false;
		PasswordLabel.Text = "Right code";
		PasswordLabel.TextColor = new Color(0, 128, 0);
	}
}