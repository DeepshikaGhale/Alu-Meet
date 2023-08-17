
using System.Collections.ObjectModel;
using AluMeet.Model;
using AluMeet.ViewModels;

namespace AluMeet.Views;

public partial class EventListScreen : ContentPage
{
    private EventListViewModel _eventListViewModel;

    public EventListScreen()
	{
		InitializeComponent();
        _eventListViewModel = new EventListViewModel();
         BindingContext = _eventListViewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        //loads the data
        _eventListViewModel.FetchEventData();
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
