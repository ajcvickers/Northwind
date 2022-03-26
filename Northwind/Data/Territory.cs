using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class Territory
{
    private readonly string _territoryId = null!;

    public Territory(
        int regionId, 
        string territoryDescription)
    {
        RegionId = regionId;
        TerritoryDescription = territoryDescription;
    }

    public int RegionId { get; }
    public string TerritoryDescription { get; }
    public Region Region { get; set; } = null!;
    public ICollection<Employee> Employees { get; } = new List<Employee>();
}
