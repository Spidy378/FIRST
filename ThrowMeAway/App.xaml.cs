using Xamarin.Forms;

namespace ThrowMeAway
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ThrowMeAwayPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            var someCode = false;
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
