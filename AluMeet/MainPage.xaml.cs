using AluMeet.Views;
using AluMeet.Services;
using AluMeet.ViewModels;

namespace AluMeet;

public partial class MainPage : ContentPage
{
    private CheckProperty _checkProperty;

	public MainPage()
	{
		InitializeComponent();
        _checkProperty = new CheckProperty();
        BindingContext = _checkProperty;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        //checks the data
        _checkProperty.ShowViewIfDataIsPresent();
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


