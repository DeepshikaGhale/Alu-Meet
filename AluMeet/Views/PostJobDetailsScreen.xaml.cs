using AluMeet.ViewModels;

namespace AluMeet.Views;

public partial class PostJobDetailsScreen : ContentPage
{
	public PostJobDetailsScreen()
	{
		InitializeComponent();
        BindingContext = new JobViewModel(Navigation);
    }

    private void ChooseDate(object sender, EventArgs e)
    {
        var dateOfEvent = DateTime.Now.ToString("MM/dd/yyyy");
        DateOfEvent.Text = dateOfEvent;
    }

    private void AddJobDetailsClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PostJobDetailsScreen());
    }
}
