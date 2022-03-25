using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class Shipper
{
    public Shipper(
        int shipperId, 
        string companyName)
    {
        ShipperId = shipperId;
        CompanyName = companyName;
    }

    public int ShipperId { get; }
    public string CompanyName { get; }
    public string? Phone { get; set; }
    public ICollection<Order> Orders { get; } = new List<Order>();
}
