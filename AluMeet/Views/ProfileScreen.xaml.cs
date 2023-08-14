namespace AluMeet.Views;

public partial class ProfileScreen : ContentPage
{
	public ProfileScreen()
	{
		InitializeComponent();
		ClassOf.Text = "2022";
		Program.Text = "Project Management";
		Email.Text = "someone@gmail.com";
		Phone.Text = "012345678";
		Job.Text = "Assistant Project Manager";
	}
}
