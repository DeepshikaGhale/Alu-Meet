using AluMeet.Model;

namespace AluMeet.Views;

public partial class EventDetailsScreen : ContentPage
{
	private EventModel currentEventModel;

	public EventDetailsScreen(EventModel selectedEventModel)
	{
		InitializeComponent();

		currentEventModel = selectedEventModel;

		EventName.Text = currentEventModel.EventTitle;
		EventDateAndTime.Text = $"{currentEventModel.DateOfEvent} {currentEventModel.TimeOfEvent}";
		EventDescription.Text = currentEventModel.Description;
    }
}
