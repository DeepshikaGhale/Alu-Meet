using System.Collections.ObjectModel;
using AluMeet.Model;
using AluMeet.ViewModels;
using AndroidX.Lifecycle;

namespace AluMeet.Views;

public partial class JobListScreen : ContentPage
{
    private JobListViewModel _jobListViewModel;

    public JobListScreen()
	{
		InitializeComponent();
        _jobListViewModel = new JobListViewModel();
        BindingContext = _jobListViewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        //loads the data
        _jobListViewModel.FetchJobData();
    }

    void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
    {
        Console.WriteLine("Called");
        if (args.SelectedItem is JobModel job)
        {
            // Navigate to the details page and pass the selected note to it
            Navigation.PushAsync(new JobDetailsScreen(job));
        }
        else
        {
            Console.WriteLine(args.SelectedItem);
            Console.WriteLine("Did not print");
        }

        // Reset the selected item (so it can be selected again if needed)
        JobListView.SelectedItem = null;
    }


    private void AddJobDetailsClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PostJobDetailsScreen());
    }
}
