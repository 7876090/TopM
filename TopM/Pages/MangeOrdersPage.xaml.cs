using TopM.Models;

namespace TopM.Pages;

public partial class MangeOrdersPage : ContentPage
{
	public MangeOrdersPage(ManageOrdersPageModel ctx)
	{
		InitializeComponent();
		BindingContext = ctx;
	}
}