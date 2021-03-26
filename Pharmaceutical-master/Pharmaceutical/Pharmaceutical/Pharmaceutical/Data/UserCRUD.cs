using Pharmaceutical.Model;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Pharmaceutical.Data
{
    public class UserCRUD
    {
        static object locker = new object();

        SQLiteConnection conn;

        public UserCRUD()
        {
            conn = DependencyService.Get<ISQLiteDB>().GetConnection();
            conn.CreateTable<Users>();
        }

        //Insert 
        public int InsertDetails(Users user)
        {
            lock (locker)
            {
                return conn.Insert(user);
            }
        }

        //Update 
        public int UpdateDetails(Users user)
        {
            lock (locker)
            {
                return conn.Update(user);
            }
        }

        //Delete 
        public int Delete(Users user)
        {
            lock (locker)
            {
                return conn.Delete(user);
            }
        }

        //Get all 
        public IEnumerable<Users> GetUserList()
        {
            lock (locker)
            {
                return (from i in conn.Table<Users>() select i).ToList();
            }
        }


        //Get specific user by name
        public Users GetUsername(string name)
        {
            lock (locker)
            {
                return conn.Table<Users>().LastOrDefault(t => t.Username.Equals(name));
            }
        }

        //Dispose
        public void Dispose()
        {
            conn.Dispose();
        }
    }
}
        