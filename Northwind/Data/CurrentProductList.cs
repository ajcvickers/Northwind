using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class CurrentProductList
{
    public CurrentProductList(
        int productId, 
        string productName)
    {
        ProductId = productId;
        ProductName = productName;
    }

    public int ProductId { get; }
    public string ProductName { get; }
}
