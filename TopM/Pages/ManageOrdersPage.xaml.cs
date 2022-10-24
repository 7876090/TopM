using TopM.Models;

namespace TopM.Pages;

public partial class ManageOrdersPage : ContentPage
{
	public ManageOrdersPage(ManageOrdersPageModel ctx)
	{
		InitializeComponent();
		BindingContext = ctx;
	}
}