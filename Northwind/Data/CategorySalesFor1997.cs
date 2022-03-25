using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class CategorySalesFor1997
{
    public CategorySalesFor1997(
        string categoryName)
    {
        CategoryName = categoryName;
    }

    public string CategoryName { get; }
    public decimal? CategorySales { get; set; }
}
