using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class ProductsByCategory
{

    public ProductsByCategory(
        string categoryName, 
        bool discontinued, 
        string productName)
    {
        CategoryName = categoryName;
        Discontinued = discontinued;
        ProductName = productName;
    }

    public string CategoryName { get; }
    public bool Discontinued { get; }
    public string ProductName { get; }
    public string? QuantityPerUnit { get; set; }
    public short? UnitsInStock { get; set; }
}
