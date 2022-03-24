using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class Territory
{
        public string TerritoryId { get; set; }  = null!;
        public int RegionId { get; set; }
        public string TerritoryDescription { get; set; }  = null!;
        public Region Region { get; set; } = null!;
        public ICollection<Employee> Employees { get; } = new List<Employee>();
}
