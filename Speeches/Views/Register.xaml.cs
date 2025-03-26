namespace Speeches.Views;

public partial class Register : ContentPage
{
	public Register()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();

    }
}