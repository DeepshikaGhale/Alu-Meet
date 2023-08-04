using System;
using System.ComponentModel;
using AluMeet.Model;
using Firebase.Database;
using Firebase.Database.Query;

namespace AluMeet.ViewModels
{
    public class JobViewModel : INotifyPropertyChanged
	{
		public JobViewModel(INavigation navigation)
		{
            PostJob = new Command(SaveUserDataToDatabaseAsync);
            this._navigation = navigation;
		}

        private INavigation _navigation;

        string jobTitle;
        DateTime jobDeadline;
        string jobDescription;
        string companyName;
        string jobLocation;


        public string JobTitle
        {
            get { return jobTitle; }
            set
            {
                if (jobTitle != value)
                {
                    jobTitle = value;
                    OnPropertyChanged(nameof(JobTitle));
                }
            }
        }

        public DateTime JobDeadline
        {
            get { return jobDeadline; }
            set
            {
                if (jobDeadline != value)
                {
                    jobDeadline = value;
                    OnPropertyChanged(nameof(JobDeadline));
                }
            }
        }

        public string JobDescription
        {
            get { return jobDescription; }
            set
            {
                if (jobDescription != value)
                {
                    jobDescription = value;
                    OnPropertyChanged(nameof(JobDescription));
                }
            }
        }

        public string CompanyName
        {
            get { return companyName; }
            set
            {
                if (companyName != value)
                {
                    companyName = value;
                    OnPropertyChanged(nameof(CompanyName));
                }
            }
        }

        public string JobLocation
        {
            get { return jobLocation; }
            set
            {
                if (jobLocation != value)
                {
                    jobLocation = value;
                    OnPropertyChanged(nameof(JobLocation));
                }
            }
        }

        public Command PostJob { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void  SaveUserDataToDatabaseAsync(object obj)
        {
            // Firebase Realtime Database URL
            string firebaseDatabaseUrl = "https://alummeet-af9e0-default-rtdb.firebaseio.com/";
      

            // Initialize Firebase Realtime Database client
            FirebaseClient firebaseClient = new FirebaseClient(firebaseDatabaseUrl);


            // Save user data to Firebase Realtime Database under "Alumni" node
            var res = firebaseClient.Child("Jobs").PostAsync(new JobModel
            {
                JobTitle = JobTitle,
                JobDeadline = JobDeadline,
                JobDescription = JobDescription,
                CompanyName = CompanyName,
                Location = JobLocation
                
            });

            string s = "s";
            
        }
    }


}

