using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class OrderDetail
{
    public OrderDetail(
        int orderId, 
        int productId, 
        float discount, 
        short quantity, 
        decimal unitPrice)
    {
        OrderId = orderId;
        ProductId = productId;
        Discount = discount;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }

    public int OrderId { get; }
    public int ProductId { get; }
    public float Discount { get; }
    public short Quantity { get; }
    public decimal UnitPrice { get; }
    public Order Order { get; set; } = null!;
    public Product Product { get; set; } = null!;
}
