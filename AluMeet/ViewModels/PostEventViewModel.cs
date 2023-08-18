using System;
using System.ComponentModel;
using AluMeet.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using Firebase.Database;
using AluMeet.Model;
using Firebase.Database.Query;

namespace AluMeet.ViewModels;

internal partial class PostEventViewModel : ObservableObject
{
    public PostEventViewModel(INavigation navigation)
    {
        PostEvent = new Command(PostEventBtnTapped);
        this._navigation = navigation;

        DeleteEvent = new Command(DeleteEventData);
        this._navigation = navigation;
    }

    private INavigation _navigation;

    [ObservableProperty]
    private string eventName;

    [ObservableProperty]
    private string location;

    [ObservableProperty]
    private string dateOfEvent;

    [ObservableProperty]
    private string timeOfEvent;

    [ObservableProperty]
    private string amPM;

    [ObservableProperty]
    private string description;

    [ObservableProperty]
    private string rsvps;

    [ObservableProperty]
    private string eventID;

    public Command PostEvent { get; }

    public Command DeleteEvent { get; }

    private async void PostEventBtnTapped(object obj)
    {
        await SaveEventDataToDatabaseAsync(obj);
    }

    private async Task SaveEventDataToDatabaseAsync(object obj)
    {
        // Firebase Realtime Database URL
        string firebaseDatabaseUrl = "https://alummeet-af9e0-default-rtdb.firebaseio.com/";


        // Initialize Firebase Realtime Database client
        FirebaseClient firebaseClient = new FirebaseClient(firebaseDatabaseUrl);
        var userId = UserInformation.GetUserId();

        // Save event data to Firebase Realtime Database under "Alumni" node
        try
        {
            var res = await firebaseClient.Child("Events").Child(userId).PostAsync(new EventModel
            {
                EventTitle = EventName,
                Location = Location,
                DateOfEvent = DateOfEvent,
                TimeOfEvent = TimeOfEvent,
                Description = Description
            });
            await App.Current.MainPage.DisplayAlert("Success", "Event has been posted sucessfully", "OK");
            Console.WriteLine("Data has been created successfully");
            await this._navigation.PopAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }



    //delete data
    private async void DeleteEventData(object obj)
    {
        bool confirmed = await App.Current.MainPage.DisplayAlert("Confirm Delete", "Are you sure you want to delete this event?", "Yes", "No");
        if (confirmed)
        {
            await DeleteEventDataFromDatabaseAsync(obj);
        }
    }


    private async Task DeleteEventDataFromDatabaseAsync(object obj) {
        // Firebase Realtime Database URL
        string firebaseDatabaseUrl = "https://alummeet-af9e0-default-rtdb.firebaseio.com/";

        // Initialize Firebase Realtime Database client
        FirebaseClient firebaseClient = new FirebaseClient(firebaseDatabaseUrl);
        var userId = UserInformation.GetUserId();

        try
        {
            await firebaseClient.Child("Events").Child(userId).Child(EventID).DeleteAsync();
            await App.Current.MainPage.DisplayAlert("Delete Success", "Event has been deleted successfully.", "Ok");
            await _navigation.PopAsync();
        }
        catch (Exception e)
        {
            await App.Current.MainPage.DisplayAlert("Delete Failed", e.ToString(), "Ok");
        }
    }
}



