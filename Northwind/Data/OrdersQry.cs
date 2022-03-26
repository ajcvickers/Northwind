using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class OrdersQry
{

    public OrdersQry(
        string companyName, 
        int orderId)
    {
        CompanyName = companyName;
        OrderId = orderId;
    }

    public string? Address { get; set; }
    public string? City { get; set; }
    public string CompanyName { get; }
    public string? Country { get; set; }
    public string? CustomerId { get; set; }
    public int? EmployeeId { get; set; }
    public decimal? Freight { get; set; }
    public DateTime? OrderDate { get; set; }
    public int OrderId { get; }
    public string? PostalCode { get; set; }
    public string? Region { get; set; }
    public DateTime? RequiredDate { get; set; }
    public string? ShipAddress { get; set; }
    public string? ShipCity { get; set; }
    public string? ShipCountry { get; set; }
    public string? ShipName { get; set; }
    public string? ShipPostalCode { get; set; }
    public string? ShipRegion { get; set; }
    public int? ShipVia { get; set; }
    public DateTime? ShippedDate { get; set; }
}
