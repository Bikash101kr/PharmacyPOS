using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmaceutical.Model
{
    public class Products
    {
        //============================================= 
        // Reference P2: personal assistance 
        // Purpose: Create Table and add data member 
        // Date: 10 Sep 2018 
        // Source: fellow student Saroj Ojha
        // Assistance: datatype and data that stores in database
        //============================================= 

        // column in table in database
        [PrimaryKey]
        public string batch_no { get; set; }
        [MaxLength(255)]
        public string product_name { get; set; }
        [MaxLength(255)]
        public string mfd_date { get; set; }

        public string exp_date { get; set; }
        public string quantity { get; set; }
        public string rate { get; set; }
        public string user { get; set; }
        
    }
}
