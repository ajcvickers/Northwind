using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class OrderDetail
{
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public float Discount { get; set; }
        public short Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public Order Order { get; set; } = null!;
        public Product Product { get; set; } = null!;
}
