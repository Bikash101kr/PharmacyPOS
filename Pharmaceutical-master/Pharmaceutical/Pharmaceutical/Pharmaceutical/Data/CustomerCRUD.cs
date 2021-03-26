using Pharmaceutical.Model;
using SQLite;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace Pharmaceutical.Data
{
    public class CustomerCRUD
    {
        static object locker = new object();

        SQLiteConnection conn;


        public CustomerCRUD()
        {
            conn = DependencyService.Get<ISQLiteDB>().GetConnection();
            //create table
            conn.CreateTable<Customers>();
        }
        //Insert 
        public int InsertDetails(Customers aCustomer)
        {
            lock (locker)
            {
                return conn.Insert(aCustomer);
            }
        }

        //Update 
        public int UpdateDetails(Customers aCustomer)
        {
            lock (locker)
            {
                return conn.Update(aCustomer);
            }
        }

        //Delete 
        public int DeleteCustomer(Customers aCustomer)
        {
            lock (locker)
            {
                return conn.Delete(aCustomer);
            }
        }

        //Get all 
        public IEnumerable<Customers> GetCustomerList()
        {
            lock (locker)
            {
                return (from i in conn.Table<Customers>() select i).ToList();
            }
        }

        //get all CustomerName
        public List<Customers> GetCustomertNameList()
        {
            lock (locker)
            {
                return (from i in conn.Table<Customers>() select i).ToList();
            }
        }



        //get customer  Age
        public Customers GetCustomerAge(string aCustomer)
        {
            lock (locker)
            {
                return conn.Table<Customers>().FirstOrDefault(t => t.customer_age.Equals(aCustomer));
            }
        }

        //get Customer ID No
        public Customers GetCustomerIDNo(string aCustomer)
        {
            lock (locker)
            {
                return conn.Table<Customers>().FirstOrDefault(t => t.customer_id.Equals(aCustomer));
            }
        }
        //get Customer ID type
        public Customers GetCustomerIDType(string aCustomer)
        {
            lock (locker)
            {
                return conn.Table<Customers>().FirstOrDefault(t => t.customerID_type.Equals(aCustomer));
            }
        }
        public Customers GetCustomerAddress(string aCustomer)
        {
            lock (locker)
            {
                return conn.Table<Customers>().FirstOrDefault(t => t.customer_address.Equals(aCustomer));
            }
        }
        //Get specific product by Name
        public Customers GetCustomerUsername(string Username)
        {
            lock (locker)
            {
                return conn.Table<Customers>().LastOrDefault(t => t.username.Equals(Username));
            }
        }

        //Dispose
        public void Dispose()
        {
            conn.Dispose();
        }
    }
}
