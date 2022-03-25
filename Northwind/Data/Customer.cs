﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class Customer
{
    public Customer(
        string customerId, 
        string companyName)
    {
        CustomerId = customerId;
        CompanyName = companyName;
    }

    public string CustomerId { get; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string CompanyName { get; }
    public string? ContactName { get; set; }
    public string? ContactTitle { get; set; }
    public string? Country { get; set; }
    public string? Fax { get; set; }
    public string? Phone { get; set; }
    public string? PostalCode { get; set; }
    public string? Region { get; set; }
    public ICollection<Order> Orders { get; } = new List<Order>();
    public ICollection<CustomerDemographic> CustomerTypes { get; } = new List<CustomerDemographic>();
}
