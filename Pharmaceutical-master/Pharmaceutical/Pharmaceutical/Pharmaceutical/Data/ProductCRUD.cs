using Pharmaceutical.Model;
using SQLite;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Pharmaceutical.Data
{
    public class ProductCRUD
    {
        static object locker = new object();

        SQLiteConnection conn;

        //============================================= 
        // Reference P1: personal assistance 
        // Purpose: deal with CRUD functionality  
        // Date: 24 Apr 2018 
        // Source: fellow student Sajan Mahato 
        // Assistance: explained getting and inserting data to database
        //============================================= 

        public ProductCRUD()
        {
            conn = DependencyService.Get<ISQLiteDB>().GetConnection();
            //create table
            conn.CreateTable<Products>();
        }
        //Insert 
        public int InsertDetails(Products aProduct)
        {
            lock (locker)
            {
                return conn.Insert(aProduct);
            }
        }

        //Update 
        public int UpdateDetails(Products aProduct)
        {
            lock (locker)
            {
                return conn.Update(aProduct);
            }
        }

        //Delete 
        public int DeleteProduct(Products aProduct)
        {
            lock (locker)
            {
                return conn.Delete(aProduct);
            }
        }

        //Get all 
        public IEnumerable<Products> GetProductList()
        {
            lock (locker)
            {
                return (from i in conn.Table<Products>() select i).ToList();
            }
        }

        //get all productName
        public List<Products> GetProductNameList()
        {
            lock (locker)
            {
                return (from i in conn.Table<Products>() select i).ToList();
            }
        }

        

        //get product rate
        public Products GetProductRate(string aproduct)
        {
            lock (locker)
            {
                return conn.Table<Products>().FirstOrDefault(t => t.quantity.Equals(aproduct));
            }
        }

        //get product Quantity
        public Products GetProductQuantity(string aproduct)
        {
            lock (locker)
            {
                return conn.Table<Products>().FirstOrDefault(t => t.rate.Equals(aproduct));
            }
        }

        //Get specific product by Name
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
