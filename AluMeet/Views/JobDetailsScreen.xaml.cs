﻿using AluMeet.Model;

namespace AluMeet.Views;

public partial class JobDetailsScreen : ContentPage
{

	private JobModel currentJob;
    // The constructor for "JobDetailsScreen" takes a "JobModel" object (selectedJob) as a parameter, which represents the job item selected from the list.
    public JobDetailsScreen(JobModel selectedJob)
	{
		InitializeComponent();
		currentJob = selectedJob;// Assigning the selected job item to the private field.

        if (currentJob != null) {
            JobName.Text = currentJob.JobTitle; // Display the job title in the "JobName" label.
            CompanyName.Text = $"Company Name: {currentJob.CompanyName}"; // Display the company name in the "CompanyName" label.
            Deadline.Text = $"Apply Till: {currentJob.JobDeadline}"; // Display the job deadline in the "Deadline" label.
            Location.Text = $"Location: {currentJob.Location}"; // Display the job location in the "Location" label.
            JobDescription.Text = currentJob.JobDescription; // Display the job description in the "JobDescription" label.
        }
    }
}