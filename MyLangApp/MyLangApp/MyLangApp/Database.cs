using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MyLangApp.Tables;
using SQLite;

namespace MyLangApp
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath) 
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<User>().Wait();
        }
        public Task<List<User>> GetUserAsync()
        {
            return _database.Table<User>().ToListAsync();
        }

        public Task<int> SaveUserAsync(User user)
        {
            return _database.InsertAsync(user);
        }
    }
}
