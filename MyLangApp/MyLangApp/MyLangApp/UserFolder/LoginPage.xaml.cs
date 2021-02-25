using MyLangApp.Data;
using MyLangApp.Main;
using MyLangApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyLangApp.UserFolder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        UserDB userData = new UserDB();
        public LoginPage()
        {
            InitializeComponent();
        }

        //Navigate to First page to choose whether login/register (UserLoginPage)
        private void btnCancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UserLoginPage());
            //break?
        }

        //Navigate to StartPage for languages (
        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            if (await ValidateForm())
            {
                IEnumerable<User> result = userData.whereUser(entryUsername.Text.Trim(), entryPassword.Text.Trim());

                if (result.Count() ==0)
                {
                    await DisplayAlert("Alert", "Incorrect Password", "OK");
                }
                else if (result.Count() ==1)
                {
                    await (Navigation.PushAsync(new StartPage()));
                }
                else if (result.Count()>=1)
                {
                    await DisplayAlert("Alert", "You are already an registered member, please try again.", "OK");

                }
            }
            {

            }
            //Navigation.PushAsync(new StartPage());
        }

        private async Task<bool> ValidateForm()
        {
            if (String.IsNullOrWhiteSpace(entryUsername.Text))
            {
                await this.DisplayAlert("WARNING", "You need to enter an email", "OK");
                return false;
            }
            else
            {
                bool isEmail = Regex.IsMatch(entryUsername.Text, @"\ A (?:[a-z0-9! # $% & '* + /=? ^_`{|} ~ -] + (?: \. [a-z0-9] (?: [a-z0-9 -] * [a-z0-9]?) \ Z ", RegexOptions.IgnoreCase);
                if (! isEmail)
                {
                    await this.DisplayAlert("WARNING", "Email format is wrong", "OK");
                    return false;
                }
                if (String.IsNullOrWhiteSpace(entryPassword.Text))
                {
                    await this.DisplayAlert("WARNING", "You need to enter a password", "OK");
                    return false;
                }

                return true;
            }

        }
    }
}