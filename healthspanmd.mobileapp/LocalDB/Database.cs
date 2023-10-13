using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace healthspanmd.mobileapp.LocalDB
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _connection;

        public Database(string dbPath)
        {
            _connection = new SQLiteAsyncConnection(dbPath);
            _connection.CreateTableAsync<TestTable>();
        }

        public Task<List<TestTable>> getTestDataAsync()
        {
            return _connection.Table<TestTable>().ToListAsync();
        }

        public Task<int> SaveTestData(TestTable TestData)
        {
            return _connection.InsertAsync(TestData);
        }

    }
}
