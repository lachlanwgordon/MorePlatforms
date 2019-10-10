using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MorePlatformsC.Services;
using MorePlatformsC.Views;

namespace MorePlatformsC
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
