using System;
<<<<<<< HEAD
using AluMeet.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
using Firebase.Database;
using Newtonsoft.Json;

namespace AluMeet.ViewModels
{
	internal partial class LoginViewModel: ObservableObject
	{
		[ObservableProperty]
		private string email;

		[ObservableProperty]
		private string password;

		string apiKey = "AIzaSyCkRo_giGFKNA04W7NArjMPXeHHpKnooAo";

		private INavigation _navigation;

        public Command LognBtn { get; }

        public LoginViewModel(INavigation navigation)
		{
			this._navigation = navigation;
			LognBtn = new Command(LoginBtnTappedAsync);
		}

		
		private async void LoginBtnTappedAsync(Object obj)
		{
			var authProvider = new FirebaseAuthProvider(new FirebaseConfig(apiKey));
			try
			{
				var auth = await authProvider.SignInWithEmailAndPasswordAsync(Email, Password);
				var content = await auth.GetFreshAuthAsync();
				var serializedContent = JsonConvert.SerializeObject(content);
				Preferences.Set("FirebaseToken", serializedContent);
				await _navigation.PushAsync(new ProfileViewScreen());
			}
			catch (FirebaseAuthException e)
			{
				if(e.Reason == AuthErrorReason.InvalidEmailAddress)
				{
                    await App.Current.MainPage.DisplayAlert("Error", "Invalid email address. Please enter a valid email.", "OK");
                }
			}
		}

=======
namespace AluMeet.ViewModels
{
	public class LoginViewModel
	{
		public LoginViewModel()
		{
		}
>>>>>>> main
	}
}

