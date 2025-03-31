using Speeches.Views;

namespace Speeches
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //Test
        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    SplashAnimation.Progress = new TimeSpan(0, 0, 0);
        //    SplashAnimation.IsAnimationEnabled = true;
        //}

        //Animation ends 
        private async void OnAnimationCompleted(object? sender, EventArgs e)
        {
            await Task.Delay(500);
            //Next page
            await Navigation.PushAsync(new Login());
            Navigation.RemovePage(this);
        }
    }

}
