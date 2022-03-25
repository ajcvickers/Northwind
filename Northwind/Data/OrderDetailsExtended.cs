using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class OrderDetailsExtended
{
    public OrderDetailsExtended(
        float discount, 
        int orderId, 
        int productId, 
        string productName, 
        short quantity, 
        decimal unitPrice)
    {
        Discount = discount;
        OrderId = orderId;
        ProductId = productId;
        ProductName = productName;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }

    public float Discount { get; }
    public decimal? ExtendedPrice { get; set; }
    public int OrderId { get; }
    public int ProductId { get; }
    public string ProductName { get; }
    public short Quantity { get; }
    public decimal UnitPrice { get; }
}
