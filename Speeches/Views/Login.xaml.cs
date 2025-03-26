using System.Diagnostics;

namespace Speeches.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
    }

    private void ForgotPassword_Tapped(object sender, TappedEventArgs e)
    {
        //Code will be added
    }
    private void Register_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new Register());
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        //Warakoy lingaw
        //await Navigation.PopToRootAsync();
    }
}