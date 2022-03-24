using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class AlphabeticalListOfProduct
{
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }  = null!;
        public bool Discontinued { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }  = null!;
        public string? QuantityPerUnit { get; set; } 
        public short? ReorderLevel { get; set; }
        public int? SupplierId { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
}
