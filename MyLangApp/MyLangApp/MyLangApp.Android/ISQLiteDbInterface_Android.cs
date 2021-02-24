using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MyLangApp.Droid.Dependancies;
using MyLangApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite.Net;
using Xamarin.Forms;
using System.IO;

[assembly: Dependency(typeof(GetSQLiteConnection))]
namespace MyLangApp.Droid.Dependancies
{
    public class GetSQLiteConnection : ISQLiteInterface
    {
        //public GetSQLiteConnection()
        //{

        public SQLite.SQLiteConnection GetLiteConnection()
        {
            throw new NotImplementedException();
        }

        interface ISQLiteDbInterface_Android
        {
        }
    }
}