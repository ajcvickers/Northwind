using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class Category
{
    private readonly int _categoryId;

    public Category(
        string categoryName)
    {
        CategoryName = categoryName;
    }

    public string CategoryName { get; }
    public string? Description { get; set; }
    public byte[]? Picture { get; set; }
    public ICollection<Product> Products { get; } = new List<Product>();
}
