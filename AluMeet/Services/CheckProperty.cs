using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Controls;

namespace AluMeet.Services;
internal partial class CheckProperty : ObservableObject
{
        [ObservableProperty]
        private bool hasDataInPreferences;

        [ObservableProperty]
        public bool showLoginAndRegisterBtn;


        // check if the token is present or not
        public void ShowViewIfDataIsPresent() { 
        //UserInformation userInformation = new UserInformation();
        var firebaseToken = UserInformation.GetFirebaseToken();

        var hasData = (firebaseToken != "");
        HasDataInPreferences = hasData;
        ShowLoginAndRegisterBtn = !HasDataInPreferences;
        Console.WriteLine(ShowLoginAndRegisterBtn);
    }
}
