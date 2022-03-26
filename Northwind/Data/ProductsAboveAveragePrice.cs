using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class ProductsAboveAveragePrice
{

    public ProductsAboveAveragePrice(
        string productName)
    {
        ProductName = productName;
    }

    public string ProductName { get; }
    public decimal? UnitPrice { get; set; }
}
