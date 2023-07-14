using Microsoft.Maui.Controls;
using Android.App;
using Application = Android.App.Application;

namespace AluMeet.Views;

public partial class PostEventScreen : ContentPage
{
	public PostEventScreen()
	{
		InitializeComponent();
	}

    private async void BackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }

    private void ChooseDate(object sender, EventArgs e)
    {
            var dateOfEvent = DateTime.Now.ToString("MM/dd/yyyy");
            DateOfEvent.Text = dateOfEvent;
    }

    private void AddPostDetails(object sender, EventArgs e)
    {
        
    }
}
