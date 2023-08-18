using System;
using System.Collections.ObjectModel;
using AluMeet.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using Firebase.Database;

namespace AluMeet.ViewModels
{
internal partial class AlumniDirectoryViewmodel: ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<AlumniModel> aluminiList = new ();
       
        public async Task FetchAlumniData()
        {
            AluminiList.Clear();
            try
            {
                FirebaseClient firebaseClient = new FirebaseClient("https://alummeet-af9e0-default-rtdb.firebaseio.com/");
                var obj = await firebaseClient.Child("Alumni").OnceAsync<AlumniModel>();

                var alumniData = new ObservableCollection<AlumniModel>(
                    obj.Select(item => new AlumniModel
                    {
                        Name = item.Object.Name,
                        Email = item.Object.Email,
                        GraduationYear = item.Object.GraduationYear,
                        Id = item.Object.Id,
                        ProgramStudied = "Business Administration",
                        ContactDetails = "987-654-3210",
                        CurrentEmployer = "XYZ Corporation",
                        CurrentPosition = "Marketing Manager",
                        TwitterHandle = "@janesmith",
                        FacebookHandle = "facebook.com/janesmith",
                        LinkedInHandle = "linkedin.com/in/janesmith",
                        ProfilePicture = "profile_picture2.jpg"
                    }).ToList());

                foreach (var alumni in alumniData)
                {
                    AluminiList.Add(alumni);
                }

                Console.WriteLine("Success");
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }



        }
    }
}

