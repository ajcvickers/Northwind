using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class CustomerDemographic
{
        public string CustomerTypeId { get; set; }  = null!;
        public string? CustomerDesc { get; set; } 
        public ICollection<Customer> Customers { get; } = new List<Customer>();
}
