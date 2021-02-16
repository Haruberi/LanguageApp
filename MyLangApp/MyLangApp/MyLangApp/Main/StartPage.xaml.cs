using MyLangApp.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyLangApp.Main
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        //Click button on StartPage to navigate to Language courses
        private void japanese_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new JapaneseCourses());
        }

        private void chinese_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChineseCourses());
        }

        private void korean_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new KoreanCourses());
        }
        //Navigation through Toolbar
        private void ToolbarItemJapanese_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new JapaneseCourses());
        }
        private void ToolbarItemChinese_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChineseCourses());
        }
        private void ToolbarItemKorean_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new KoreanCourses());

        }
    }
    }
