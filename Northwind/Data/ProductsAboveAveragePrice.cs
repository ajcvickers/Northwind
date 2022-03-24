using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class ProductsAboveAveragePrice
{
        public string ProductName { get; set; }  = null!;
        public decimal? UnitPrice { get; set; }
}
