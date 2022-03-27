using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class Order
{
    private readonly int _orderId;
    private readonly string _customerId = null!;
    private readonly int? _employeeId;
    private readonly int? _shipVia;

    public Order()
    {
    }

    public decimal? Freight { get; set; }
    public DateTime? OrderDate { get; set; }
    public DateTime? RequiredDate { get; set; }
    public string? ShipAddress { get; set; }
    public string? ShipCity { get; set; }
    public string? ShipCountry { get; set; }
    public string? ShipName { get; set; }
    public string? ShipPostalCode { get; set; }
    public string? ShipRegion { get; set; }
    public DateTime? ShippedDate { get; set; }
    public Customer? Customer { get; set; }
    public Employee? Employee { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();
    public Shipper? ShipViaNavigation { get; set; }
}
