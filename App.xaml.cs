using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace RepeatProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Changed from the home page as i feel a login page was needed.
            //MainPage = new MainPage();

            //Login To Homepage which will be a page where you will be able to login to your account and then access and use your calculator.
            MainPage = new MainPage(new Login());
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
