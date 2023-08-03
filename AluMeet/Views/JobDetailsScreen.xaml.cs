using AluMeet.Model;

namespace AluMeet.Views;

public partial class JobDetailsScreen : ContentPage
{

	private JobModel currentJob;

	public JobDetailsScreen(JobModel selectedJob)
	{
		InitializeComponent();
		currentJob = selectedJob;

		if (currentJob != null) {
			JobName.Text = currentJob.JobTitle;
			CompanyName.Text = $"Company Name: {currentJob.CompanyName}";
			Deadline.Text = $"Apply Till: { currentJob.JobDeadline}";
			Location.Text = $"Location: {currentJob.Location}";
			JobDescription.Text = currentJob.JobDescription;
        }
	}
}
