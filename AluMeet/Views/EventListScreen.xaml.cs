
using System.Collections.ObjectModel;
using AluMeet.Model;

namespace AluMeet.Views;

public partial class EventListScreen : ContentPage
{   //data for list view
    public ObservableCollection<EventModel> EventList { get; set; }

    public EventListScreen()
	{
		InitializeComponent();
        //populate list view with data
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
         BindingContext = this;

    }

    void OnEventItemSelected(object sender, SelectedItemChangedEventArgs args)
    {
        if (args.SelectedItem is EventModel eventModel)
        {
            // Navigate to the details page and pass the selected event to it
            Navigation.PushAsync(new EventDetailsScreen(eventModel));
        }

        EventListView.SelectedItem = null;
    }


    private void AddEventDetailsClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PostEventScreen());
        Console.WriteLine("Goes to new screen");
    }
}
