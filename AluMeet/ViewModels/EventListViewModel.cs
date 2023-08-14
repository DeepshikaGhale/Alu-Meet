using System;
using System.Collections.ObjectModel;
using AluMeet.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using Firebase.Database;
using Firebase.Database.Query;

namespace AluMeet.ViewModels
{
	internal partial class EventListViewModel: ObservableObject
	{
        public ObservableCollection<EventModel> EventList { get; set; }

        [ObservableProperty]
        private string eventTitle;


        public EventListViewModel()
		{
            EventList = new ObservableCollection<EventModel>
        {
            new EventModel{
                ID = 1,
                EventTitle = "Hosting Alumini MeetUp",
                Location= "College RefreshMent Center",
                DateOfEvent = "2023/08/21",
                TimeOfEvent = "1:00 PM",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not! Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not!"
            },
            new EventModel{
                ID = 1,
                EventTitle = "Hosting Alumini MeetUp",
                Location= "College RefreshMent Center",
                DateOfEvent = "2023/08/21",
                TimeOfEvent = "1:00 PM",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not! Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not!"
            },
            new EventModel{
                ID = 1,
                EventTitle = "Hosting Alumini MeetUp",
                Location= "College RefreshMent Center",
                DateOfEvent = "2023/08/21",
                TimeOfEvent = "1:00 PM",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not! Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not!"
            },
            new EventModel{
                ID = 1,
                EventTitle = "Hosting Alumini MeetUp",
                Location= "College RefreshMent Center",
                DateOfEvent = "2023/08/21",
                TimeOfEvent = "1:00 PM",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not! Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not!"
            },
            new EventModel{
                ID = 1,
                EventTitle = "Hosting Alumini MeetUp",
                Location= "College RefreshMent Center",
                DateOfEvent = "2023/08/21",
                TimeOfEvent = "1:00 PM",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not! Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not!"
            },
            new EventModel{
                ID = 1,
                EventTitle = "Hosting Alumini MeetUp",
                Location= "College RefreshMent Center",
                DateOfEvent = "2023/08/21",
                TimeOfEvent = "1:00 PM",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not! Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not!"
            },
            new EventModel{
                ID = 1,
                EventTitle = "Hosting Alumini MeetUp",
                Location= "College RefreshMent Center",
                DateOfEvent = "2023/08/21",
                TimeOfEvent = "1:00 PM",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not! Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not!"
            },
         };
        }

        public void FetchEventData()
        {
            FirebaseClient firebaseClient = new FirebaseClient("https://alummeet-af9e0-default-rtdb.firebaseio.com/");
            var observable = firebaseClient.Child("Events")
                .AsObservable<EventModel>()
                .Subscribe(obj =>
                {
                    if (obj.Object != null)
                    {
                        EventList.Add(obj.Object);
                    }
                });
        }
    }
}

