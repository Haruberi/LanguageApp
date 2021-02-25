using MyLangApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLangApp.Data
{
    public class UserDB
    {
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
          {
              return new SQLiteAsyncConnection(DataBase.DatabasePath, DataBase.Flags);
          });

        static SQLiteAsyncConnection Database => lazyInitializer.Value;
        static bool initialized = false;

        public UserDB()
        {
            InitializeAsync().SafeFireAndForget(false);
        }

        async Task InitializeAsync()
        {
            if (! initialized)
            {
                if (! Database.TableMappings.Any(m => m.MappedType.Name ==typeof(User).Name))
                {
                    //await Database.CreateTableAsync(CreateFlags.None, typeof(User)).ConfigureAwait(false);
                    await Database.CreateTableAsync<User>().ConfigureAwait(false);
                    initialized = true;
                }

            }
        }
        #region login methods
        public IEnumerable<User> whereUser(string strEmail, string strPwd)
        {
            var result = Database.QueryAsync<User>("Select * from User Where email=? and password=?", strEmail, strPwd);

            return result.Result;
        }
        #endregion
    }
}
