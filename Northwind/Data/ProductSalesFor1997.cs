﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class ProductSalesFor1997
{
        public string CategoryName { get; set; }  = null!;
        public string ProductName { get; set; }  = null!;
        public decimal? ProductSales { get; set; }
}
