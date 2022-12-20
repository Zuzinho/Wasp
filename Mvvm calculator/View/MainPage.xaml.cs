using WaspMaui.ViewModel;

namespace WaspMaui.View;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new CalculatorViewModel();
	}
}

