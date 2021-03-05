using MyLangApp.Main;
using MyLangApp.UserFolder;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace MyLangApp
{
    public partial class App : Application
    {

        public App()
        {
            //InitializeComponent();
            MainPage = new NavigationPage(new UserLoginPage());

        }

        protected override void OnStart()
        {
            //Handle when your app starts
        }

        protected override void OnSleep()
        {
            //Handle when your app sleeps
        }

        protected override void OnResume()
        {
            //Handle when your app resumes
        }
    }
}
