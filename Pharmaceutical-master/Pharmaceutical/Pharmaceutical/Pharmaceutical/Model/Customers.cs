using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmaceutical.Model
{
    public class Customers
    {
        [PrimaryKey]
        public string customer_id { get; set; }
        public string customerID_type { get; set; }
        [MaxLength(255)]
        public string customer_name { get; set; }
        [MaxLength(255)]
        public string customer_address { get; set; }

        public string customer_age { get; set; }
        [MaxLength(255), Unique]
        public string username { get; set; }
        public string user { get; set; }
    }
}
