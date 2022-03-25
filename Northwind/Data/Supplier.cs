﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class Supplier
{
    public Supplier(
        int supplierId, 
        string companyName)
    {
        SupplierId = supplierId;
        CompanyName = companyName;
    }

    public int SupplierId { get; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string CompanyName { get; }
    public string? ContactName { get; set; }
    public string? ContactTitle { get; set; }
    public string? Country { get; set; }
    public string? Fax { get; set; }
    public string? HomePage { get; set; }
    public string? Phone { get; set; }
    public string? PostalCode { get; set; }
    public string? Region { get; set; }
    public ICollection<Product> Products { get; } = new List<Product>();
}
