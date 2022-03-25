using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class Category
{
    public Category(
        int categoryId, 
        string categoryName)
    {
        CategoryId = categoryId;
        CategoryName = categoryName;
    }

    public int CategoryId { get; }
    public string CategoryName { get; }
    public string? Description { get; set; }
    public byte[]? Picture { get; set; }
    public ICollection<Product> Products { get; } = new List<Product>();
}
