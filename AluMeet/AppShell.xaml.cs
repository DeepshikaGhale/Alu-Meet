using AluMeet.Views;

namespace AluMeet;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(LoginViewScreen), typeof(LoginViewScreen));
        Routing.RegisterRoute(nameof(RegisterViewScreen), typeof(RegisterViewScreen));
        Routing.RegisterRoute(nameof(JobListScreen), typeof(JobListScreen));
        Routing.RegisterRoute(nameof(PostEventScreen), typeof(PostEventScreen));
    }
}

