using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class SalesByCategory
{
    public SalesByCategory(
        int categoryId, 
        string categoryName, 
        string productName)
    {
        CategoryId = categoryId;
        CategoryName = categoryName;
        ProductName = productName;
    }

    public int CategoryId { get; }
    public string CategoryName { get; }
    public string ProductName { get; }
    public decimal? ProductSales { get; set; }
}
