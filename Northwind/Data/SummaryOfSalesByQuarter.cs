using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class SummaryOfSalesByQuarter
{
        public int OrderId { get; set; }
        public DateTime? ShippedDate { get; set; }
        public decimal? Subtotal { get; set; }
}
