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
    public partial class UserLoginPage : ContentPage
    {
        public UserLoginPage()
        {
            InitializeComponent();
        }

        //Navigate to page for Registration (UserRegisterPage)
        private void btnRegister_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UserRegisterPage());
        }

        //Navigate to page for Login (LoginPage)
        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

    }
}