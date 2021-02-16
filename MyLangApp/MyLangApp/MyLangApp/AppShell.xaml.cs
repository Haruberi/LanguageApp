using MyLangApp.ViewModels;
using MyLangApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MyLangApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
