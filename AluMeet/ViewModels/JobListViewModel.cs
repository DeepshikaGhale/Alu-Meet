using System;
using System.Collections.ObjectModel;
using AluMeet.Model;
using Firebase.Database;

namespace AluMeet.ViewModels
{
	public class JobListViewModel
	{
        public ObservableCollection<JobModel> JobList { get; set; }

        public JobListViewModel()
		{
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
            }, };
            FetchJobData();
        }


        public void FetchJobData()
        {
            FirebaseClient firebaseClient = new FirebaseClient("https://alummeet-af9e0-default-rtdb.firebaseio.com/");
            var observable = firebaseClient.Child("Jobs")
                .AsObservable<JobModel>()
                .Subscribe(obj =>
                {
                    if (obj.Object != null)
                    {
                        JobList.Add(obj.Object);
                    }
                });
        }
	}
}

