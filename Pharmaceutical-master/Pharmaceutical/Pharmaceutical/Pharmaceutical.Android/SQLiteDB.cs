using System;
using System.IO;
using Pharmaceutical.Data;
using Pharmaceutical.Droid;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDB))]
namespace Pharmaceutical.Droid
{
    public class SQLiteDB : ISQLiteDB
    {
        public SQLiteConnection GetConnection()
        {
            var filename = "pharmacy.db"; // database file name
            var dbPath = Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);// Documents folder
            var path = Path.Combine(dbPath, filename);
            var conn = new SQLiteConnection(path);
            // Return the database connection 
            return conn;
        }
    }
}