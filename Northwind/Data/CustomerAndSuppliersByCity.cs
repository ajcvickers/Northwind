using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class CustomerAndSuppliersByCity
{
        public string? City { get; set; } 
        public string CompanyName { get; set; }  = null!;
        public string? ContactName { get; set; } 
        public string Relationship { get; set; }  = null!;
}
