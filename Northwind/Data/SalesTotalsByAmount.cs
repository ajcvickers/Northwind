using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class SalesTotalsByAmount
{
        public string CompanyName { get; set; }  = null!;
        public int OrderId { get; set; }
        public decimal? SaleAmount { get; set; }
        public DateTime? ShippedDate { get; set; }
}
