using System.Collections.ObjectModel;
using AluMeet.Model;

namespace AluMeet.Views;

public partial class JobListScreen : ContentPage
{
    public ObservableCollection<JobModel> JobList { get; set; }

    public JobListScreen()
	{
		InitializeComponent();

        JobList = new ObservableCollection<JobModel> {
            new JobModel{
                ID = "1",
                CompanyName = "E.K Bana Solutions",
                JobDeadline = DateTime.Now,
                JobDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not! Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not!",
                JobTitle = "Intern",
                Location = "Lalitpur"
            },
            new JobModel{
                ID = "1",
                CompanyName = "E.K Bana Solutions",
                JobDeadline = DateTime.Now,
                JobDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not! Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not!",
                JobTitle = "Intern",
                Location = "Lalitpur"
            },
            new JobModel{
                ID = "1",
                CompanyName = "E.K Bana Solutions",
                JobDeadline = DateTime.Now,
                JobDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not! Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not!",
                JobTitle = "Intern",
                Location = "Lalitpur"
            },
            new JobModel{
                ID = "1",
                CompanyName = "E.K Bana Solutions",
                JobDeadline = DateTime.Now,
                JobDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not! Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not!",
                JobTitle = "Intern",
                Location = "Lalitpur"
            },
            new JobModel{
                ID = "1",
                CompanyName = "E.K Bana Solutions",
                JobDeadline = DateTime.Now,
                JobDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not! Lorem Ipsum is simply dummy text of the printing and typesetting industry. This is to test if it works or not!",
                JobTitle = "Intern",
                Location = "Lalitpur"
            },
        };

        BindingContext = this;
    }

    private void AddJobDetailsClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PostJobDetailsScreen());
    }
}
