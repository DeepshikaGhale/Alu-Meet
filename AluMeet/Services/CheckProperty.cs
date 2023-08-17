using System.ComponentModel;
using Microsoft.Maui.Controls;

namespace AluMeet.Services;
public class CheckProperty : INotifyPropertyChanged
{
        private bool _hasDataInPreferences;

        public bool HasDataInPreferences
        {
            get => _hasDataInPreferences;
            set
            {
                if (_hasDataInPreferences != value)
                {
                    _hasDataInPreferences = value;
                    OnPropertyChanged(nameof(HasDataInPreferences));
                }
            }
        }

        public bool ShowProfile;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    // check if the token is present or not
    public void ShowViewIfDataIsPresent() { 
        //UserInformation userInformation = new UserInformation();
        var firebaseToken = UserInformation.GetFirebaseToken();

        var hasData = (firebaseToken != null);
        HasDataInPreferences = hasData;
        ShowProfile = !HasDataInPreferences;
    }
}
