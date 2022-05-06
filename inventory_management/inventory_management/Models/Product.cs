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
<<<<<<< HEAD
        [PrimaryKey, AutoIncrement]
=======
        //[PrimaryKey, AutoIncrement]
>>>>>>> 163a026fb41c3efc8cf790f95b2acc7adbc7f1ad
        public int Code { get; set; }
        public string BarCode { get; set; }
        public string Name { get; set; }
        public double TotalQuantity { get; set; }
        public DateTime Date { get; set; }


        [ManyToMany(typeof(ProductHistory))]
        public List<History> History { get; set; }


    }
}
