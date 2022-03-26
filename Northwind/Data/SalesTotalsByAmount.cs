using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class SalesTotalsByAmount
{

    public SalesTotalsByAmount(
        string companyName, 
        int orderId)
    {
        CompanyName = companyName;
        OrderId = orderId;
    }

    public string CompanyName { get; }
    public int OrderId { get; }
    public decimal? SaleAmount { get; set; }
    public DateTime? ShippedDate { get; set; }
}
