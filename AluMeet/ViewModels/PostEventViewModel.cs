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

    public Command PostEvent { get; }

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

            Console.WriteLine("Data has been created successfully");
            await this._navigation.PopAsync();
        }
        catch (Exception e) {
            Console.WriteLine(e);
        }
    }

    
}



