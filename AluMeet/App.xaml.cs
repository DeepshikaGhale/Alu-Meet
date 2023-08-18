
using AluMeet.Views;
namespace AluMeet;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}

