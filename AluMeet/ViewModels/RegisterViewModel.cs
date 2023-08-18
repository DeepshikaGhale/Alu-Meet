using System;
using System.ComponentModel;
using AluMeet.Model;
using AluMeet.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;

namespace AluMeet.ViewModels
{
    internal partial class RegisterViewModel : ObservableObject
	{
        [ObservableProperty]
        private string email;

        [ObservableProperty]
        private string password;

        [ObservableProperty]
        private string fullName;

        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string graduationYear = "";

        private INavigation _navigation;

        private string userId;

        public RegisterViewModel(INavigation navigation)
		{
			RegisterUser = new Command(RegisterBtnTappedAsync);
            this._navigation = navigation;
		}

        private async void RegisterBtnTappedAsync(object obj)
        {
            
            try
            {
                // Connect our application to firebase auth
                FirebaseAuthProvider firebaseAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(WebAPIKey));
                // Firebase auth selected createUserWithEmailAndPassword option
                var auth = await firebaseAuthProvider.CreateUserWithEmailAndPasswordAsync(Email, Password);
                // after register firebase give us token
                var token = auth.FirebaseToken;
                // check token if it is null give alert message else back to login page


                userId = auth.User.LocalId;

                await SaveUserDataToDatabaseAsync();

                if (token != null)

                    await App.Current.MainPage.DisplayAlert("Alert", "User Registered successfully", "OK");

                 await this._navigation.PopAsync();
            }
            catch (FirebaseAuthException ex)
            {
                if (ex.Reason == AuthErrorReason.EmailExists)
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Email already exists. Please choose a different email.", "OK");
                }
                else if (ex.Reason == AuthErrorReason.InvalidEmailAddress)
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Invalid email address. Please enter a valid email.", "OK");
                }
                else if (ex.Reason == AuthErrorReason.WeakPassword)
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Weak password. Please choose a stronger password.", "OK");
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Registration failed. Please try again.", "OK");
                }
            }
        }

        private async Task  SaveUserDataToDatabaseAsync()
        {
            // Firebase Realtime Database URL
            string firebaseDatabaseUrl = "https://alummeet-af9e0-default-rtdb.firebaseio.com/";


            // Initialize Firebase Realtime Database client
            FirebaseClient firebaseClient = new FirebaseClient(firebaseDatabaseUrl);

            // Save user data to Firebase Realtime Database under "Alumni" node
            var alumni = await firebaseClient.Child("Alumni").PostAsync(new AlumniModel
            {
                Name = FullName,
                Email = Email,
                GraduationYear = int.Parse(GraduationYear),
                Id = userId,
                ProgramStudied = "Business Administration",
                ContactDetails = "987-654-3210",
                CurrentEmployer = "XYZ Corporation",
                CurrentPosition = "Marketing Manager",
                TwitterHandle = "@janesmith",
                FacebookHandle = "facebook.com/janesmith",
                LinkedInHandle = "linkedin.com/in/janesmith",
                ProfilePicture = "profile_picture2.jpg"
            });
        }

        public string WebAPIKey = "AIzaSyCkRo_giGFKNA04W7NArjMPXeHHpKnooAo";

     
        public Command RegisterUser { get; }

        
    }
}

