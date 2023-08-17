using AluMeet.Views;
using AluMeet.Services;

namespace AluMeet;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        CheckProperty checkProperty = new CheckProperty();
        checkProperty.ShowViewIfDataIsPresent();
        BindingContext = new CheckProperty();
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
    private void JobNavBtnItemTapped(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new JobListScreen());
    }

    // func to navigate to jobs screen
    private void DirectoryNavBtnItemTapped(object obj, EventArgs e)
    {
        Navigation.PushAsync(new DirectoryListScreen());
    }

    
    // func to navigate to profile screen
    private void ProfileNavBtnTapped(object obj, EventArgs e)
    {
        Navigation.PushAsync(new ProfileScreen());
    }

   
}   


