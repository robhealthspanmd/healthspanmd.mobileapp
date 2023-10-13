using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace healthspanmd.mobileapp.LocalDB
{
    public class TestTable
    {
        [PrimaryKey, AutoIncrement]
        public int TestId { get; set; }
        public string testString { get; set; }
        public bool testBool { get; set; }
    }
}
