﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class OrderSubtotal
{
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
}
