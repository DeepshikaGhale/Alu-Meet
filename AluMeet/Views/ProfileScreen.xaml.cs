using Newtonsoft.Json;
using AluMeet.ViewModels;

namespace AluMeet.Views;

public partial class ProfileScreen : ContentPage
{
    private ProfileViewModel _profileViewModel;

	public ProfileScreen()
	{
		InitializeComponent();
        _profileViewModel = new ProfileViewModel(Navigation);
        BindingContext = _profileViewModel;
        GetProfileInfo();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        //loads the data
        _profileViewModel.ShowProfile();
    }


    private void GetProfileInfo()
    {
        var userInfo = JsonConvert.DeserializeObject<Firebase.Auth.FirebaseAuth>(Preferences.Get("FirebaseToken", ""));
        Email.Text = userInfo.User.Email;
    }
}
