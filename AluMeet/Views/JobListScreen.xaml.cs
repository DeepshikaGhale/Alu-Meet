using System.Collections.ObjectModel;
using AluMeet.Model;
<<<<<<< HEAD
using AluMeet.ViewModels;
=======
using static Android.Provider.ContactsContract.CommonDataKinds;
>>>>>>> main

namespace AluMeet.Views;

public partial class JobListScreen : ContentPage
{
    //public ObservableCollection<JobModel> JobList { get; set; }

    public JobListScreen()
	{
		InitializeComponent();

        //JobList = new ObservableCollection<JobModel> {
        //    new JobModel{
        //        ID = "1",
        //        CompanyName = "E.K Bana Solutions",
        //        JobDeadline = DateTime.Now,
        //        JobDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not! Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not!",
        //        JobTitle = "Intern",
        //        Location = "Lalitpur"
        //    },
        //    new JobModel{
        //        ID = "1",
        //        CompanyName = "E.K Bana Solutions",
        //        JobDeadline = DateTime.Now,
        //        JobDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not! Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not!",
        //        JobTitle = "Intern",
        //        Location = "Lalitpur"
        //    },
        //    new JobModel{
        //        ID = "1",
        //        CompanyName = "E.K Bana Solutions",
        //        JobDeadline = DateTime.Now,
        //        JobDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not! Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not!",
        //        JobTitle = "Intern",
        //        Location = "Lalitpur"
        //    },
        //    new JobModel{
        //        ID = "1",
        //        CompanyName = "E.K Bana Solutions",
        //        JobDeadline = DateTime.Now,
        //        JobDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not! Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not!",
        //        JobTitle = "Intern",
        //        Location = "Lalitpur"
        //    },
        //    new JobModel{
        //        ID = "1",
        //        CompanyName = "E.K Bana Solutions",
        //        JobDeadline = DateTime.Now,
        //        JobDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not! Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not!",
        //        JobTitle = "Intern",
        //        Location = "Lalitpur"
            //},
        //};

        BindingContext = new JobListViewModel();;
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
