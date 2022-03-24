using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class ProductsByCategory
{
        public string CategoryName { get; set; }  = null!;
        public bool Discontinued { get; set; }
        public string ProductName { get; set; }  = null!;
        public string? QuantityPerUnit { get; set; } 
        public short? UnitsInStock { get; set; }
}
