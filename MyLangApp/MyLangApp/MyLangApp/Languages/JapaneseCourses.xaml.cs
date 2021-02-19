using MyLangApp.JapaneseLevel;
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
    public partial class JapaneseCourses : ContentPage
    {
        public JapaneseCourses()
        {
            InitializeComponent();
        }
        //Navigte to levels
        private void japlevel1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new JapLevel1());
        }

        private void japlevel2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new JapLevel2());
        }

        private void japlevel3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new JapLevel3());
        }
    }
}