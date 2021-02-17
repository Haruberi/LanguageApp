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
    }
}