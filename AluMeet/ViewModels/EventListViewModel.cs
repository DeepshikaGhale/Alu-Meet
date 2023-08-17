using System;
using System.Collections.ObjectModel;
using AluMeet.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using Firebase.Database;
using Firebase.Database.Query;
using AluMeet.Services;

namespace AluMeet.ViewModels
{
	internal partial class EventListViewModel: ObservableObject
	{
        [ObservableProperty]
        public ObservableCollection<EventModel> eventList = new ();

        public async void FetchEventData()
        {
            EventList.Clear();
            try
            {
                FirebaseClient firebaseClient = new FirebaseClient("https://alummeet-af9e0-default-rtdb.firebaseio.com/");
                var obj = await firebaseClient.Child($"Events/{UserInformation.GetUserId()}")
                     .OnceAsync<EventModel>();

                var eventData = new ObservableCollection<EventModel>(
                    obj.Select(item => new EventModel
                    {
                        EventTitle = item.Object.EventTitle,
                        Location = item.Object.Location,
                        DateOfEvent = item.Object.DateOfEvent,
                        TimeOfEvent = item.Object.TimeOfEvent,
                        Description = item.Object.Description
                    }).ToList());

                foreach (var eventItem in eventData) {
                    EventList.Add(eventItem);
                }
                    Console.WriteLine(EventList[0].EventTitle);
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }
    }
}

