using MyLangApp.KoreanLevel;
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
    public partial class KoreanCourses : ContentPage
    {
        public KoreanCourses()
        {
            InitializeComponent();
        }
        //Navigate to levels
        private void korlevel1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new KorLevel1());
        }

        private void korlevel2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new KorLevel2());
        }

        private void korlevel3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new KorLevel3());
        }
    }
}