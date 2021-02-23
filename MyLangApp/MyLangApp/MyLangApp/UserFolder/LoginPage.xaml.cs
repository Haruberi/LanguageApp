using MyLangApp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyLangApp.UserFolder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            if (Application.Current.Properties.ContainsKey("Username") && Application.Current.Properties.ContainsKey("Password"))
            {
                var username = Application.Current.Properties["Username"] as string;
                var password = Application.Current.Properties["Password"] as string;

            if(entryUsername.Text == username && entryPassword.Text == password)
                {

                }
            }
        }

        //Navigate to First page to choose whether login/register (UserLoginPage)
        private void btnCancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UserLoginPage());
        }

        //Navigate to StartPage for languages (
        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StartPage());
        }
    }
}