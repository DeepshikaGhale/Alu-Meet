using System;
using System.ComponentModel;
using AluMeet.Model;
using AluMeet.Services;
using Firebase.Database;
using Firebase.Database.Query;
using Microsoft.Extensions.Logging;

namespace AluMeet.ViewModels;

public class JobViewModel : INotifyPropertyChanged
	{
		public JobViewModel(INavigation navigation)
		{
        PostJob = new Command(PostJobBtnTapped);
        this._navigation = navigation;

        DeleteJob = new Command(DeleteJobData);
        this._navigation = navigation;
    }

    private INavigation _navigation;

    string jobTitle;
    DateTime jobDeadline;
    string jobDescription;
    string companyName;
    string jobLocation;
    string jobID;

    public string JobID
    {
        get { return jobID; }
        set
        {
            if (jobID != value)
            {
                jobID = value;
                OnPropertyChanged(nameof(JobID));
            }
        }
    }

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

    public Command DeleteJob { get; }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    //post job details
    private async void PostJobBtnTapped(object obj)
    {
        await SaveUserDataToDatabaseAsync(obj);
    }

        private async Task SaveUserDataToDatabaseAsync(object obj)
    {
        // Firebase Realtime Database URL
        string firebaseDatabaseUrl = "https://alummeet-af9e0-default-rtdb.firebaseio.com/";
  

        // Initialize Firebase Realtime Database client
        FirebaseClient firebaseClient = new FirebaseClient(firebaseDatabaseUrl);
        var userId = UserInformation.GetUserId();

        // Save user data to Firebase Realtime Database under "Alumni" node
        var res = await firebaseClient.Child("Jobs").Child(userId).PostAsync(new JobModel
        {
            JobTitle = JobTitle,
            JobDeadline = JobDeadline,
            JobDescription = JobDescription,
            CompanyName = CompanyName,
            Location = JobLocation
            
        });
        await App.Current.MainPage.DisplayAlert("Success", "Event has been posted sucessfully", "OK");

        await this._navigation.PopAsync();

    }

    //delete data
    private async void DeleteJobData(object obj)
    {
        bool confirmed = await App.Current.MainPage.DisplayAlert("Confirm Delete", "Are you sure you want to delete this job details?", "Yes", "No");
        if (confirmed)
        {
            await DeleteJobDataFromDatabaseAsync(obj);
        }
    }


    private async Task DeleteJobDataFromDatabaseAsync(object obj)
    {
        // Firebase Realtime Database URL
        string firebaseDatabaseUrl = "https://alummeet-af9e0-default-rtdb.firebaseio.com/";

        // Initialize Firebase Realtime Database client
        FirebaseClient firebaseClient = new FirebaseClient(firebaseDatabaseUrl);
        var userId = UserInformation.GetUserId();

        try
        {
            await firebaseClient.Child("Jobs").Child(userId).Child(jobID).DeleteAsync();
            await App.Current.MainPage.DisplayAlert("Delete Success", "Job has been deleted successfully.", "Ok");
            await _navigation.PopAsync();
        }
        catch (Exception e)
        {
            await App.Current.MainPage.DisplayAlert("Delete Failed", "Job details cannot be deleted.", "Ok");
        }
    }


}

