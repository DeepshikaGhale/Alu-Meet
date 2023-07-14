using AluMeet.Views;

namespace AluMeet;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	// func to navigate to login screen
	private void loginNavBtnItemTapped(object obj, EventArgs e) {
		Navigation.PushAsync(new LoginViewScreen());
	}

    // func to navigate to register screen
    private void RegisterNavBtnItemTapped(object obj, EventArgs e)
    {
        Navigation.PushAsync(new RegisterViewScreen());
    }

    // func to navigate to events screen
    private void PostEventsNavBtnItemTapped(object obj, EventArgs e)
    {
        Navigation.PushAsync(new EventListScreen());
    }

    // func to navigate to jobs screen
    private void JobNavBtnItemTapped(object obj, EventArgs e)
    {
        Navigation.PushAsync(new JobListScreen());
    }
}


