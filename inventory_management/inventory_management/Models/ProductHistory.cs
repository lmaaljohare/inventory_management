using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory_management.Models
{
    public class ProductHistory
    {
        [ForeignKey(typeof(Product))]
        public int IdProduct { get; set; }

        [ForeignKey(typeof(History))]
        public int IdHistory { get; set; }
    }
}
