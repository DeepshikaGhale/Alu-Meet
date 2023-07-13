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

    private void ChooseDate(object sender, EventArgs e)
    {
            var dateOfEvent = DateTime.Now.ToString("MM/dd/yyyy");
            DateOfEvent.Text = dateOfEvent;
    }
}
