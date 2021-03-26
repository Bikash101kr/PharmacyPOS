using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmaceutical.Model
{
    public class Sales
    {
        [PrimaryKey]
        public int bill_no { get; set; }        
        [ForeignKey(typeof(Products))]
        public string product_name { get; set; }
        public string buyrs_name { get; set; }
        public string sales_date { get; set; }
        public int sales_quantity { get; set; }
        public int rate { get; set; }
        public int total_amount { get; set; } 
        public int amount_paid { get; set; }
        public int change { get; set; }
    }
}
