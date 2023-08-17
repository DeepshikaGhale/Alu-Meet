using System;
using System.Collections.ObjectModel;
using AluMeet.Model;
using Firebase.Database;
using AluMeet.Services;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AluMeet.ViewModels;

	internal partial class JobListViewModel: ObservableObject
	{
    [ObservableProperty]
    private ObservableCollection<JobModel> jobList = new();

    public async void FetchJobData()
    {
        try
        {
            FirebaseClient firebaseClient = new FirebaseClient("https://alummeet-af9e0-default-rtdb.firebaseio.com/");
            var obj = await firebaseClient.Child($"Jobs/{UserInformation.GetUserId()}")
                .OnceAsync<JobModel>();

            var jobData = new ObservableCollection<JobModel>(
                obj.Select(item => new JobModel
                {
                    ID = item.Object.ID,
                    CompanyName = item.Object.CompanyName,
                    JobDeadline = item.Object.JobDeadline,
                    JobDescription = item.Object.JobDescription,
                    JobTitle = item.Object.JobTitle,
                    Location = item.Object.Location
                }).ToList());

            foreach (var job in jobData)
            {
                JobList.Add(job);
            }

            Console.WriteLine(JobList[0].CompanyName);
        }
        catch (Exception e){
            Console.WriteLine(e);
        }


        //var observable = await firebaseClient.Child($"Jobs/{UserInformation.GetUserId}")
        //    .AsObservable<JobModel>()
        //    .Subscribe(obj =>
        //    {
        //        if (obj.Object != null)
        //        {
        //            JobList.Add(obj.Object);
        //        }
        //    });
        //Console.WriteLine(observable.ToString());
    }
	}

