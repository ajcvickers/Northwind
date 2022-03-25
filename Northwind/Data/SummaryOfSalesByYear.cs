using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class SummaryOfSalesByYear
{
    public SummaryOfSalesByYear(
        int orderId)
    {
        OrderId = orderId;
    }

    public int OrderId { get; }
    public DateTime? ShippedDate { get; set; }
    public decimal? Subtotal { get; set; }
}
