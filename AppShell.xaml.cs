namespace CRUD_mob_app;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
	}
}
