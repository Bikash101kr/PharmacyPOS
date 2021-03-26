using System;
using System.IO;
using Pharmaceutical.Data;
using Pharmaceutical.iOS;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDB))]
namespace Pharmaceutical.iOS
{
    public class SQLiteDB : ISQLiteDB
    {
        public SQLiteConnection GetConnection()
        {
            var fileName = "Pharmacy.db";
            string dbPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder  
            string libraryPath = Path.Combine(dbPath, "..", "Library"); // Library folder  
            var path = Path.Combine(libraryPath, fileName);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}