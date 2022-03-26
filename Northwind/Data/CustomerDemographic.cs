using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class CustomerDemographic
{
    private readonly string _customerTypeId = null!;

    public CustomerDemographic()
    {
    }

    public string? CustomerDesc { get; set; }
    public ICollection<Customer> Customers { get; } = new List<Customer>();
}
