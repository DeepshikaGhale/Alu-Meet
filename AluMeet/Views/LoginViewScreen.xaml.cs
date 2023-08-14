using AluMeet.ViewModels;

namespace AluMeet.Views;

public partial class LoginViewScreen : ContentPage
{
    public LoginViewScreen()
	{
		InitializeComponent();
		BindingContext = new LoginViewModel(Navigation);
	}
}
