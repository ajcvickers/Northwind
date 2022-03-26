using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class Shipper
{
    private readonly int _shipperId;

    public Shipper(
        string companyName)
    {
        CompanyName = companyName;
    }

    public string CompanyName { get; }
    public string? Phone { get; set; }
    public ICollection<Order> Orders { get; } = new List<Order>();
}
