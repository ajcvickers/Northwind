using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class Territory
{
    private readonly string _territoryId = null!;
    private readonly int _regionId;

    public Territory(
        string territoryDescription)
    {
        TerritoryDescription = territoryDescription;
    }

    public string TerritoryDescription { get; }
    public Region Region { get; set; } = null!;
    public ICollection<Employee> Employees { get; } = new List<Employee>();
}
