using MyLangApp.ChineseLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyLangApp.Languages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChineseCourses : ContentPage
    {
        public ChineseCourses()
        {
            InitializeComponent();
        }

        //Navigate to levels
        private void chilevel1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChiLevel1());
        }

        private void chilevel2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChiLevel2());
        }

        private void chilevel3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChiLevel3());
        }
    }
}