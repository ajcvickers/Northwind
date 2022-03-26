using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class Region
{
    private readonly int _regionId;

    public Region(
        string regionDescription)
    {
        RegionDescription = regionDescription;
    }

    public string RegionDescription { get; }
    public ICollection<Territory> Territories { get; } = new List<Territory>();
}
