using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class OrderDetailsExtended
{
        public float Discount { get; set; }
        public decimal? ExtendedPrice { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }  = null!;
        public short Quantity { get; set; }
        public decimal UnitPrice { get; set; }
}
