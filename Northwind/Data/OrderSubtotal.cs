using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class OrderSubtotal
{

    public OrderSubtotal(
        int orderId)
    {
        OrderId = orderId;
    }

    public int OrderId { get; }
    public decimal? Subtotal { get; set; }
}
