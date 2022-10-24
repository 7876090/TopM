using TopM.Models;

namespace TopM;

public partial class MainPage : ContentPage
{

	public MainPage(MainPageModel ctx)
	{
		InitializeComponent();
		BindingContext = ctx;
	}

}

