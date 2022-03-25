using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class Region
{
    public Region(
        int regionId, 
        string regionDescription)
    {
        RegionId = regionId;
        RegionDescription = regionDescription;
    }

    public int RegionId { get; }
    public string RegionDescription { get; }
    public ICollection<Territory> Territories { get; } = new List<Territory>();
}
