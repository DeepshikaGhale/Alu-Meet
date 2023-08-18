using AluMeet.Model;
using AluMeet.ViewModels;

namespace AluMeet.Views;

public partial class EventDetailsScreen : ContentPage
{
	private EventModel currentEventModel;
	private PostEventViewModel _postEventViewModel;

	public EventDetailsScreen(EventModel selectedEventModel)
	{
		InitializeComponent();

		currentEventModel = selectedEventModel;

		EventName.Text = currentEventModel.EventTitle;
		EventDateAndTime.Text = $"{currentEventModel.DateOfEvent} {currentEventModel.TimeOfEvent}";
		EventDescription.Text = currentEventModel.Description;

		_postEventViewModel = new PostEventViewModel(Navigation);
        _postEventViewModel.EventID = currentEventModel.ID;
        BindingContext = _postEventViewModel;

		
    }
}
