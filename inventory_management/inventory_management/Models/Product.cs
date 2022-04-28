using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Inventory_management.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int IdProduct { get; set; }
        [AutoIncrement]
        public int Code { get; set; }
        public string BarCode { get; set; }
        public string Name { get; set; }
        public int TotalQuantity { get; set; }
        public DateTime Date { get; set; }


        [ManyToMany(typeof(ProductHistory))]
        public List<History> History { get; set; }


    }
}
