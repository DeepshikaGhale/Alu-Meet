using System;
using Newtonsoft.Json;

namespace AluMeet.Services
{
	public class UserInformation
	{
		public UserInformation()
		{

		}

        public string GetUserId()
        {
            // Retrieve the current user ID from preferences or authentication (e.g., Firebase Auth)
            var userInfo = JsonConvert.DeserializeObject<Firebase.Auth.FirebaseAuth>(Preferences.Get("FirebaseToken", ""));
            return userInfo.User.LocalId;
        }

        public string GetFirebaseToken()
        {
            // Retrieve the current firebase token from preferences or authentication (e.g., Firebase Auth)
            var userInfo = JsonConvert.DeserializeObject<Firebase.Auth.FirebaseAuth>(Preferences.Get("FirebaseToken", ""));
            return userInfo.FirebaseToken;
        }
    }
}

