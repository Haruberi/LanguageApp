﻿using MyLangApp.Main;
using MyLangApp.UserFolder;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace MyLangApp
{
    public partial class App : Application
    {
        static Database database;
        public static Database Database
        {
            get
            {
                if (database==null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LanguageUser.db3"));
                }
                return database;
            }
        }

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
