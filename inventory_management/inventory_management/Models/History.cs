using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;

using System.Text;

namespace Inventory_management.Models
{

    public class History
    {

        [PrimaryKey, AutoIncrement]
        public int IdHistory { get; set; }
        [ForeignKey(typeof(Product))]
        public int IdProduct { get; set; }
        [ForeignKey(typeof(Product))]
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public int OperationType { get; set; }

        [ManyToMany(typeof(ProductHistory))]
        public List<Product> Product { get; set; }

    }
}
