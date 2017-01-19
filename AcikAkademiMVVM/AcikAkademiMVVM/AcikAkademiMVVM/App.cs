using AcikAkademiMVVM.Views;
using Xamarin.Forms;

namespace AcikAkademiMVVM
{
    public class App : Application
    {
        public App()
        {
            MainPage = new PersonPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
