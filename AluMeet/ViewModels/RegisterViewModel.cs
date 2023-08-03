using System;
using System.ComponentModel;
using AluMeet.Model;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;

namespace AluMeet.ViewModels
{
    public class RegisterViewModel : INotifyPropertyChanged
	{
        string email;
        string password;
        string fullName;
        string username;
        int graduationYear;
        private INavigation _navigation;
        public string Email
        {
            get { return email; }
            set
            {
                if (email != value)
                {
                    email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        public string Username
        {
            get { return username; }
            set
            {
                if (username != value)
                {
                    username = value;
                    OnPropertyChanged(nameof(Username));
                }
            }
        }

        public string FullName
        {
            get { return fullName; }
            set
            {
                if (fullName != value)
                {
                    fullName = value;
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }

        public int GraduationYear
        {
            get { return graduationYear; }
            set
            {
                if (graduationYear != value)
                {
                    graduationYear = value;
                    OnPropertyChanged(nameof(GraduationYear));
                }
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

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
                string token = auth.FirebaseToken;
                // check token if it is null give alert message else back to login page

                
                if (token != null)
                {
                    await App.Current.MainPage.DisplayAlert("Alert", "User Registered successfully", "OK");
                    SaveUserDataToDatabaseAsync();
                    await this._navigation.PopAsync();
                }
                
                





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

        private void  SaveUserDataToDatabaseAsync()
        {
            // Firebase Realtime Database URL
            string firebaseDatabaseUrl = "https://alummeet-af9e0-default-rtdb.firebaseio.com/";


            // Initialize Firebase Realtime Database client
            FirebaseClient firebaseClient = new FirebaseClient(firebaseDatabaseUrl);
       

            // Save user data to Firebase Realtime Database under "Alumni" node
            var alumni = firebaseClient.Child("Alumni").PostAsync(new AlumniModel
            {
                Name = FullName,
                Email = Email,
                GraduationYear = GraduationYear
            });
        }

        public string WebAPIKey = "AIzaSyCkRo_giGFKNA04W7NArjMPXeHHpKnooAo";

        public event PropertyChangedEventHandler PropertyChanged;

        public Command RegisterUser { get; }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

