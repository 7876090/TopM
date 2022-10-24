using TopM.Views;

namespace TopM;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
		Routing.RegisterRoute(nameof(ManageOrdersView), typeof(ManageOrdersView));
	}
}
