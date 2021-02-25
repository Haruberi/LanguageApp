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

                //Skriver inn fel
                if (result.Count() ==0)
                {
                    await DisplayAlert("Alert", "Incorrect Username or Password", "OK");
                }
                //Skriver in rätt?
                else if (result.Count() == 1)
                {
                    await (Navigation.PushAsync(new StartPage()));
                }
                else if (result.Count() >= 1)
                {
                    await DisplayAlert("OOPS!", "You are already an registered member, please try again.", "OK");

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
                await this.DisplayAlert("ATTENTION", "You need to enter a valid username", "OK");
                return false;
            }
            else
            {
                //för email: 
                //bool isEmail = Regex.IsMatch(entryUsername.Text, @"\A(?:[a-z0 - 9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                //för username:, om error: ^(?=[a-zA-Z0-9._]{8,20}$)(?!.*[_.]{2})[^_.].*[^_.]$
                bool isUsername = Regex.IsMatch(entryUsername.Text, @"^(?=.{4,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$", RegexOptions.IgnoreCase);
                if(! isUsername)
                {
                    await this.DisplayAlert("ATTENTION", "Wrong username", "OK");
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