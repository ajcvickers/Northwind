using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class Product
{
    private readonly int _productId;
    private readonly int? _categoryId;
    private readonly int? _supplierId;

    public Product(
        bool discontinued, 
        string productName)
    {
        Discontinued = discontinued;
        ProductName = productName;
    }

    public bool Discontinued { get; }
    public string ProductName { get; }
    public string? QuantityPerUnit { get; set; }
    public short? ReorderLevel { get; set; }
    public decimal? UnitPrice { get; set; }
    public short? UnitsInStock { get; set; }
    public short? UnitsOnOrder { get; set; }
    public Category? Category { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();
    public Supplier? Supplier { get; set; }
}
