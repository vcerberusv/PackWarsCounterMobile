using System;
using SQLite;

namespace PackWarsCounterMobile
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
