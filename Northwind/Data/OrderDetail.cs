using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class OrderDetail
{
    private readonly int _orderId;
    private readonly int _productId;

    public OrderDetail(
        float discount, 
        short quantity, 
        decimal unitPrice)
    {
        Discount = discount;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }

    public float Discount { get; }
    public short Quantity { get; }
    public decimal UnitPrice { get; }
    public Order Order { get; set; } = null!;
    public Product Product { get; set; } = null!;
}
