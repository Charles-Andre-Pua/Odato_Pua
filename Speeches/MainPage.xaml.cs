using Speeches.Views;

namespace Speeches
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //warakoy lingaw
        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    SplashAnimation.Progress = new TimeSpan(0, 0, 0);
        //    SplashAnimation.IsAnimationEnabled = true;
        //}
        private async void OnAnimationCompleted(object? sender, EventArgs e)
        {
            await Task.Delay(500);
            await Navigation.PushAsync(new Login());
            Navigation.RemovePage(this);
        }
    }

}
