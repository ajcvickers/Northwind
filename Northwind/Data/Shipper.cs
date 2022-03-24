using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class Shipper
{
        public int ShipperId { get; set; }
        public string CompanyName { get; set; }  = null!;
        public string? Phone { get; set; } 
        public ICollection<Order> Orders { get; } = new List<Order>();
}
