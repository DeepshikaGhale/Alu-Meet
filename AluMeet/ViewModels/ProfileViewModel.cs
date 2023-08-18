using System;
using AluMeet.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json;

namespace AluMeet.ViewModels
{
	internal partial class ProfileViewModel: ObservableObject
	{
		[ObservableProperty]
		private string email;

        [ObservableProperty]
        private string name;

        [ObservableProperty]
        private string classOf;

        [ObservableProperty]
        private string phoneNumber;

        [ObservableProperty]
        private string job;

        [ObservableProperty]
        private string program;

        private INavigation _navigation;

        public ProfileViewModel(INavigation navigation)
        {
			LogoutUser = new Command(Logout);
            this._navigation = navigation;
        }

        private void GetProfileInfo()
		{
			var userInfo = JsonConvert.DeserializeObject<Firebase.Auth.FirebaseAuth>(Preferences.Get("FirebaseToken",""));
			Email = userInfo.User.Email;
		}

		public Command LogoutUser { get; }		

		private async void Logout(object obj) { 

            CheckProperty checkProperty = new CheckProperty();
			Preferences.Clear();
			checkProperty.ShowViewIfDataIsPresent();
			await _navigation.PopAsync();
		}

        public void ShowProfile() {
            var checkData = Preferences.Get("name", "");

            if (checkData != "") {
                setData();
            }
            else {
                AddData();
                setData();
            }
        }

        private void setData() {
            Name = Preferences.Get("name", "");
            ClassOf = Preferences.Get("classOf", "");
            Program = Preferences.Get("program", "");
            PhoneNumber = Preferences.Get("phone", "");
            Job = Preferences.Get("job", "");
        }


        //to show profile
        private static async void AddData()
        {
            AlumniDirectoryViewmodel alumniDirectoryViewmodel = new AlumniDirectoryViewmodel();

            await alumniDirectoryViewmodel.FetchAlumniData();

			var alumList = alumniDirectoryViewmodel.AluminiList;

			foreach (var alum in alumList) {
                if (alum.Id == UserInformation.GetUserId()) {
                    UserInformation.SaveUserData(alum.Name, alum.ProgramStudied, alum.ContactDetails, alum.CurrentPosition, alum.GraduationYear.ToString());
                }
            }

        }
    }
}

