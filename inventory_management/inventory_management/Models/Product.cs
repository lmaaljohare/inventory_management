﻿using System;
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
        //[PrimaryKey, AutoIncrement]
        public int Code { get; set; }
        public string BarCode { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime CreatedAt { get; set; }


        [ManyToMany(typeof(ProductHistory))]
        public List<History> History { get; set; }


    }
}
