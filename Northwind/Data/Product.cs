using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class Product
{
        public int ProductId { get; set; }
        public int? CategoryId { get; set; }
        public bool Discontinued { get; set; }
        public string ProductName { get; set; }  = null!;
        public string? QuantityPerUnit { get; set; } 
        public short? ReorderLevel { get; set; }
        public int? SupplierId { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public Category? Category { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();
        public Supplier? Supplier { get; set; }
}
