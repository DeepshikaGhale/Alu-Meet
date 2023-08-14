using Newtonsoft.Json;

namespace AluMeet.Views;

public partial class ProfileViewScreen : ContentPage
{
	public ProfileViewScreen()
	{
		InitializeComponent();
        //BindingContext = new ProfileViewScreen();
        GetProfileInfo();

    }

    private void GetProfileInfo()
    {
        var userInfo = JsonConvert.DeserializeObject<Firebase.Auth.FirebaseAuth>(Preferences.Get("FirebaseToken", ""));
        UserEmail.Text = userInfo.User.Email;
    }
}
