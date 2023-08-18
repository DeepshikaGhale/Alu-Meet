using Microsoft.Maui.Controls;
using AluMeet.ViewModels;

namespace AluMeet.Views;

public partial class PostEventScreen : ContentPage
{
	public PostEventScreen()
	{
		InitializeComponent();
        BindingContext = new PostEventViewModel(Navigation);
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
