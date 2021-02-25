using SQLite;
using SQLite.Net;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyLangApp.Data
{
    public class DataBase
    {
        public const string DatabaseFilename = "LanguageSQLite.db3";

        public const SQLiteOpenFlags Flags =
            SQLiteOpenFlags.ReadWrite | //open database in read/write mode
            SQLiteOpenFlags.Create | //create database if it doesent exist
            SQLiteOpenFlags.SharedCache; //enable multi-threaded database acsess

        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }
            
    }
}
