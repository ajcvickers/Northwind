using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class CustomerDemographic
{
    public CustomerDemographic(
        string customerTypeId)
    {
        CustomerTypeId = customerTypeId;
    }

    public string CustomerTypeId { get; }
    public string? CustomerDesc { get; set; }
    public ICollection<Customer> Customers { get; } = new List<Customer>();
}
