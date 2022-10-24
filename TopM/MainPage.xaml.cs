using TopM.ViewModels;

namespace TopM;

public partial class MainPage : ContentPage
{

	public MainPage(MainPageViewModel ctx)
	{
		InitializeComponent();
		BindingContext = ctx;
	}

}

