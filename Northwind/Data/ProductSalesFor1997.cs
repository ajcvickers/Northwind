using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class ProductSalesFor1997
{
    public ProductSalesFor1997(
        string categoryName, 
        string productName)
    {
        CategoryName = categoryName;
        ProductName = productName;
    }

    public string CategoryName { get; }
    public string ProductName { get; }
    public decimal? ProductSales { get; set; }
}
