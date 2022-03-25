using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class CustomerAndSuppliersByCity
{
    public CustomerAndSuppliersByCity(
        string companyName, 
        string relationship)
    {
        CompanyName = companyName;
        Relationship = relationship;
    }

    public string? City { get; set; }
    public string CompanyName { get; }
    public string? ContactName { get; set; }
    public string Relationship { get; }
}
