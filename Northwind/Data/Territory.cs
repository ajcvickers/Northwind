using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class Territory
{
    public Territory(
        string territoryId, 
        int regionId, 
        string territoryDescription)
    {
        TerritoryId = territoryId;
        RegionId = regionId;
        TerritoryDescription = territoryDescription;
    }

    public string TerritoryId { get; }
    public int RegionId { get; }
    public string TerritoryDescription { get; }
    public Region Region { get; set; } = null!;
    public ICollection<Employee> Employees { get; } = new List<Employee>();
}
