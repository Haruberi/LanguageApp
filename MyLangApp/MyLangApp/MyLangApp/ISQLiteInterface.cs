using SQLite;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLangApp.Interfaces
{
    public interface ISQLiteInterface
    {
        SQLite.SQLiteConnection GetLiteConnection();
    }
}
