using Pharmaceutical.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Pharmaceutical.Data
{
    public class SalesCRUD
    {
        static object locker = new object();

        SQLiteConnection conn;

        public SalesCRUD()
        {
            conn = DependencyService.Get<ISQLiteDB>().GetConnection();
            conn.CreateTable<Sales>();
        }
        //Insert 
        public int InsertDetails(Sales sales)
        {
            lock (locker)
            {
                return conn.Insert(sales);
            }
        }

        //Update 
        public int UpdateDetails(Sales sales)
        {
            lock (locker)
            {
                return conn.Update(sales);
            }
        }

        //Delete 
        public int DeleteSales(Sales sales)
        {
            lock (locker)
            {
                return conn.Delete(sales);
            }
        }

        //Get all 
        public IEnumerable<Sales> GetSalesList()
        {
            lock (locker)
            {
                return (from i in conn.Table<Sales>() select i).ToList();
            }
        }

        
        //Get specific Product by Name
        public Products GetProductname(string name)
        {
            lock (locker)
            {
                return conn.Table<Products>().LastOrDefault(t => t.product_name.Equals(name));
            }
        }

        //Dispose
        public void Dispose()
        {
            conn.Dispose();
        }
    }
}
