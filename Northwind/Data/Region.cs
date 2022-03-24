using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class Region
{
        public int RegionId { get; set; }
        public string RegionDescription { get; set; }  = null!;
        public ICollection<Territory> Territories { get; } = new List<Territory>();
}
