using MyLangApp.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyLangApp.UserFolder
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserRegisterPage : ContentPage
    {
        //CollectionView collectionView = new CollectionView();

        public UserRegisterPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetUserAsync();
            //collectionView.ItemsSourse = await App.Database.GetUserAsync();
            
        }

        //Navigate to loginpage
        //By clicking Register button, save the data to the database
        async void btnRegister_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(enterUsername.Text) && !string.IsNullOrWhiteSpace(enterPassword.Text) && !string.IsNullOrWhiteSpace(enterEmail.Text))
            {
                await App.Database.SaveUserAsync(new User
                {
                    Name = enterUsername.Text,
                    Password = enterPassword.Text,
                    Email = enterEmail.Text
                });

                enterUsername.Text = enterPassword.Text = enterEmail.Text = string.Empty;
                collectionView.ItemsSource = await App.Database.GetUserAsync();
            }
            //skapar första databasen
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<RegUserTable>();

            //Data från RegUserTable innehåller data som läggs in från UserRegisterPage.xaml
            var item = new RegUserTable()
            {
                Username = enterUsername.Text,
                Password = enterPassword.Text,
                Email = enterEmail.Text
            };

            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Congratulations!", "User Registration Successful", "Yes", "Cancel");

                if (result)
                {
                    await Navigation.PushAsync(new LoginPage());
                }
            });
            //
        }

        private void btnCancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UserLoginPage());
        }
    }
}