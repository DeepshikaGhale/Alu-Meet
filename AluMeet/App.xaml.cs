
using AluMeet.Views;
namespace AluMeet;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(EventListScreen), typeof(EventListScreen));
        Routing.RegisterRoute(nameof(PostEventScreen), typeof(PostEventScreen));
    }
}

