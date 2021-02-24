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
        //Lägg till Application.Current.Properties här
        //Kan lagra data här

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
