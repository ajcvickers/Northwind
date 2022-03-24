using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class Category
{
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }  = null!;
        public string? Description { get; set; } 
        public byte[]? Picture { get; set; } 
        public ICollection<Product> Products { get; } = new List<Product>();
}
