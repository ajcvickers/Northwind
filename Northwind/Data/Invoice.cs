using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data;

public partial class Invoice
{
    public Invoice(
        string customerName, 
        float discount, 
        int orderId, 
        int productId, 
        string productName, 
        short quantity, 
        string salesperson, 
        string shipperName, 
        decimal unitPrice)
    {
        CustomerName = customerName;
        Discount = discount;
        OrderId = orderId;
        ProductId = productId;
        ProductName = productName;
        Quantity = quantity;
        Salesperson = salesperson;
        ShipperName = shipperName;
        UnitPrice = unitPrice;
    }

    public string? Address { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? CustomerId { get; set; }
    public string CustomerName { get; }
    public float Discount { get; }
    public decimal? ExtendedPrice { get; set; }
    public decimal? Freight { get; set; }
    public DateTime? OrderDate { get; set; }
    public int OrderId { get; }
    public string? PostalCode { get; set; }
    public int ProductId { get; }
    public string ProductName { get; }
    public short Quantity { get; }
    public string? Region { get; set; }
    public DateTime? RequiredDate { get; set; }
    public string Salesperson { get; }
    public string? ShipAddress { get; set; }
    public string? ShipCity { get; set; }
    public string? ShipCountry { get; set; }
    public string? ShipName { get; set; }
    public string? ShipPostalCode { get; set; }
    public string? ShipRegion { get; set; }
    public DateTime? ShippedDate { get; set; }
    public string ShipperName { get; }
    public decimal UnitPrice { get; }
}
