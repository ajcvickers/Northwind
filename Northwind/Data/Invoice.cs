﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class Invoice
{
        public string? Address { get; set; } 
        public string? City { get; set; } 
        public string? Country { get; set; } 
        public string? CustomerId { get; set; } 
        public string CustomerName { get; set; }  = null!;
        public float Discount { get; set; }
        public decimal? ExtendedPrice { get; set; }
        public decimal? Freight { get; set; }
        public DateTime? OrderDate { get; set; }
        public int OrderId { get; set; }
        public string? PostalCode { get; set; } 
        public int ProductId { get; set; }
        public string ProductName { get; set; }  = null!;
        public short Quantity { get; set; }
        public string? Region { get; set; } 
        public DateTime? RequiredDate { get; set; }
        public string Salesperson { get; set; }  = null!;
        public string? ShipAddress { get; set; } 
        public string? ShipCity { get; set; } 
        public string? ShipCountry { get; set; } 
        public string? ShipName { get; set; } 
        public string? ShipPostalCode { get; set; } 
        public string? ShipRegion { get; set; } 
        public DateTime? ShippedDate { get; set; }
        public string ShipperName { get; set; }  = null!;
        public decimal UnitPrice { get; set; }
}
