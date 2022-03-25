using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class AlphabeticalListOfProduct
{
    public AlphabeticalListOfProduct(
        string categoryName, 
        bool discontinued, 
        int productId, 
        string productName)
    {
        CategoryName = categoryName;
        Discontinued = discontinued;
        ProductId = productId;
        ProductName = productName;
    }

    public int? CategoryId { get; set; }
    public string CategoryName { get; }
    public bool Discontinued { get; }
    public int ProductId { get; }
    public string ProductName { get; }
    public string? QuantityPerUnit { get; set; }
    public short? ReorderLevel { get; set; }
    public int? SupplierId { get; set; }
    public decimal? UnitPrice { get; set; }
    public short? UnitsInStock { get; set; }
    public short? UnitsOnOrder { get; set; }
}
