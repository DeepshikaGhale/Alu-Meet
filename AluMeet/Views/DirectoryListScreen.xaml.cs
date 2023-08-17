using System.Collections.ObjectModel;
using AluMeet.Model;
using AluMeet.ViewModels;

namespace AluMeet.Views;

public partial class DirectoryListScreen : ContentPage
{
    private AlumniDirectoryViewmodel _alumniViewModel;

    public DirectoryListScreen()
    {
        InitializeComponent();

        _alumniViewModel = new AlumniDirectoryViewmodel();

        BindingContext = _alumniViewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        //loads the data
        _alumniViewModel.FetchAlumniData();
    }

}
