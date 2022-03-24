using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Data;

using var context = new NorthwindContext();

Console.WriteLine("Products:");
foreach (var category in context.Categories
             .Include(e => e.Products).ThenInclude(e => e.Supplier))
{
    Console.WriteLine($"  {category.CategoryId}: {category.CategoryName}");
    foreach (var product in category.Products)
    {
        Console.WriteLine($"    {product.ProductId}: {product.ProductName} (supplied by {product.Supplier!.CompanyName})");
    }
}

Console.WriteLine();
Console.WriteLine("Customers:");
foreach (var customer in context.Customers
             .Include(e => e.Orders).ThenInclude(e => e.OrderDetails).ThenInclude(e => e.Product)
             .Include(e => e.Orders).ThenInclude(e => e.ShipViaNavigation))
{
    Console.WriteLine($"  {customer.CustomerId}: {customer.CompanyName}");
    foreach (var order in customer.Orders)
    {
        Console.WriteLine($"    Order: {order.OrderDate} (shipped by {order.ShipViaNavigation!.CompanyName})");
        foreach (var orderDetail in order.OrderDetails)
        {
            Console.WriteLine($"      {orderDetail.Product.ProductName} ({orderDetail.Quantity} at ${orderDetail.UnitPrice})");
        }
    }
}

Console.WriteLine();
Console.WriteLine("Employees:");
foreach (var employee in context.Employees
             .Include(e => e.ReportsToNavigation)
             .Include(e => e.Territories).ThenInclude(e => e.Region))
{
    Console.WriteLine($"  {employee.FirstName} {employee.LastName} (reports to {employee.ReportsToNavigation?.LastName})");
    Console.WriteLine("    Covers:");
    foreach (var territory in employee.Territories)
    {
        Console.WriteLine($"      {territory.TerritoryDescription.Trim()} ({territory.Region.RegionDescription.Trim()})");
    }
}
