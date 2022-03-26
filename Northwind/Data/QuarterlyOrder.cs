using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class QuarterlyOrder
{

    public QuarterlyOrder()
    {
    }

    public string? City { get; set; }
    public string? CompanyName { get; set; }
    public string? Country { get; set; }
    public string? CustomerId { get; set; }
}
