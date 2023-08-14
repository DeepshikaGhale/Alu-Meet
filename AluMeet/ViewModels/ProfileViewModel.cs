using System;
using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;

namespace AluMeet.ViewModels
{
	internal partial class ProfileViewModel: ObservableObject
	{
		[ObservableProperty]
		private string email;

		public ProfileViewModel()
		{
		}

		private void GetProfileInfo()
		{
			var userInfo = JsonConvert.DeserializeObject<Firebase.Auth.FirebaseAuth>(Preferences.Get("FirebaseToken",""));
			Email = userInfo.User.Email;
		}
	}
}

