using System.Collections.ObjectModel;
using AluMeet.Model;
using AluMeet.ViewModels;

namespace AluMeet.Views;

public partial class DirectoryListScreen : ContentPage
{
    //public ObservableCollection<AlumniModel> AluminiList { get; set; }

    public DirectoryListScreen()
    {
        InitializeComponent();

        //AluminiList = new ObservableCollection<AlumniModel>
        //{
        //    new AlumniModel
        //    {
        //        Id = 1,
        //        ProgramStudied = "Computer Science",
        //        Name = "John Doe",
        //        GraduationYear = 2020,
        //        ContactDetails = "123-456-7890",
        //        CurrentEmployer = "ABC Company",
        //        CurrentPosition = "Software Engineer",
        //        Email = "john.doe@example.com",
        //        TwitterHandle = "@johndoe",
        //        FacebookHandle = "facebook.com/johndoe",
        //        LinkedInHandle = "linkedin.com/in/johndoe",
        //        ProfilePicture = "profile_picture1.jpg"
        //    },
        //    new AlumniModel
        //    {
        //        Id = 2,
        //        ProgramStudied = "Business Administration",
        //        Name = "Jane Smith",
        //        GraduationYear = 2018,
        //        ContactDetails = "987-654-3210",
        //        CurrentEmployer = "XYZ Corporation",
        //        CurrentPosition = "Marketing Manager",
        //        Email = "jane.smith@example.com",
        //        TwitterHandle = "@janesmith",
        //        FacebookHandle = "facebook.com/janesmith",
        //        LinkedInHandle = "linkedin.com/in/janesmith",
        //        ProfilePicture = "profile_picture2.jpg"
        //    }
        //};
        BindingContext = new AlumniDirectoryViewmodel();
    }
}
