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

        public UserRegisterPage()
        {
            InitializeComponent();
        }

        //Navigate to loginpage
        private void btnRegister_Clicked(object sender, EventArgs e)
        {
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