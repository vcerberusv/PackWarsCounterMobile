using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;


namespace PackWarsCounterMobile
{
    public class PWCGameDatabase
    {
        SQLiteConnection database;

        public PWCGameDatabase()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<PWCGames>();
        }

        public IEnumerable<PWCGames> GetItems()
        {
            return (from i in database.Table<PWCGames>() select i).ToList();
        }

        public PWCGames GetItem(int id)
        {
            return database.Table<PWCGames>().FirstOrDefault(x => x.ID == id);
        }

        public int DeleteItem(int id)
        {
            return database.Delete<PWCGames>(id);
        }
    }
}
