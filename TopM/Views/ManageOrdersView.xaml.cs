using TopM.ViewModels;

namespace TopM.Views;

public partial class ManageOrdersView : ContentPage
{
	public ManageOrdersView(ManageOrdersViewModel ctx)
	{
		InitializeComponent();
		BindingContext = ctx;
	}
}