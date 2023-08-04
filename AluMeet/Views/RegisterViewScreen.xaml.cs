using AluMeet.ViewModels;

namespace AluMeet.Views;

public partial class RegisterViewScreen : ContentPage
{
	public RegisterViewScreen()
	{
		InitializeComponent();
		BindingContext = new RegisterViewModel(Navigation);
	}
}
