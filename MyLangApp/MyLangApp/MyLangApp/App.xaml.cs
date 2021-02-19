using MyLangApp.Main;
using MyLangApp.UserFolder;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyLangApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new UserLoginPage());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
