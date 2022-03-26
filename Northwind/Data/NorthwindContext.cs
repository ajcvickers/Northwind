﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Northwind.Data;

public partial class NorthwindContext : DbContext
{
    public NorthwindContext()
    {
    }

    public NorthwindContext(DbContextOptions<NorthwindContext> options)
        : base(options)
    {
    }

    public DbSet<AlphabeticalListOfProduct> AlphabeticalListOfProducts => Set<AlphabeticalListOfProduct>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<CategorySalesFor1997> CategorySalesFor1997s => Set<CategorySalesFor1997>();
    public DbSet<CurrentProductList> CurrentProductLists => Set<CurrentProductList>();
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<CustomerAndSuppliersByCity> CustomerAndSuppliersByCities => Set<CustomerAndSuppliersByCity>();
    public DbSet<CustomerDemographic> CustomerDemographics => Set<CustomerDemographic>();
    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<Invoice> Invoices => Set<Invoice>();
    public DbSet<Order> Orders => Set<Order>();
    public DbSet<OrderDetail> OrderDetails => Set<OrderDetail>();
    public DbSet<OrderDetailsExtended> OrderDetailsExtendeds => Set<OrderDetailsExtended>();
    public DbSet<OrderSubtotal> OrderSubtotals => Set<OrderSubtotal>();
    public DbSet<OrdersQry> OrdersQries => Set<OrdersQry>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<ProductSalesFor1997> ProductSalesFor1997s => Set<ProductSalesFor1997>();
    public DbSet<ProductsAboveAveragePrice> ProductsAboveAveragePrices => Set<ProductsAboveAveragePrice>();
    public DbSet<ProductsByCategory> ProductsByCategories => Set<ProductsByCategory>();
    public DbSet<QuarterlyOrder> QuarterlyOrders => Set<QuarterlyOrder>();
    public DbSet<Region> Regions => Set<Region>();
    public DbSet<SalesByCategory> SalesByCategories => Set<SalesByCategory>();
    public DbSet<SalesTotalsByAmount> SalesTotalsByAmounts => Set<SalesTotalsByAmount>();
    public DbSet<Shipper> Shippers => Set<Shipper>();
    public DbSet<SummaryOfSalesByQuarter> SummaryOfSalesByQuarters => Set<SummaryOfSalesByQuarter>();
    public DbSet<SummaryOfSalesByYear> SummaryOfSalesByYears => Set<SummaryOfSalesByYear>();
    public DbSet<Supplier> Suppliers => Set<Supplier>();
    public DbSet<Territory> Territories => Set<Territory>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AlphabeticalListOfProduct>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("Alphabetical list of products");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName).HasMaxLength(15);
            entity.Property(e => e.Discontinued);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductName).HasMaxLength(40);
            entity.Property(e => e.QuantityPerUnit).HasMaxLength(20);
            entity.Property(e => e.ReorderLevel);
            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.UnitPrice).HasColumnType("money");
            entity.Property(e => e.UnitsInStock);
            entity.Property(e => e.UnitsOnOrder);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey("_categoryId");
            entity.Property<int>("_categoryId").HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName).HasMaxLength(15);
            entity.Property(e => e.Description);
            entity.Property(e => e.Picture).HasColumnType("image");
            entity.HasIndex("CategoryName");
        });

        modelBuilder.Entity<CategorySalesFor1997>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("Category Sales for 1997");
            entity.Property(e => e.CategoryName).HasMaxLength(15);
            entity.Property(e => e.CategorySales).HasColumnType("money");
        });

        modelBuilder.Entity<CurrentProductList>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("Current Product List");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductName).HasMaxLength(40);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey("_customerId");
            entity.Property<string>("_customerId").HasColumnName("CustomerID").HasMaxLength(5).IsFixedLength();
            entity.Property(e => e.Address).HasMaxLength(60);
            entity.Property(e => e.City).HasMaxLength(15);
            entity.Property(e => e.CompanyName).HasMaxLength(40);
            entity.Property(e => e.ContactName).HasMaxLength(30);
            entity.Property(e => e.ContactTitle).HasMaxLength(30);
            entity.Property(e => e.Country).HasMaxLength(15);
            entity.Property(e => e.Fax).HasMaxLength(24);
            entity.Property(e => e.Phone).HasMaxLength(24);
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.Region).HasMaxLength(15);
            entity.HasIndex("City");
            entity.HasIndex("CompanyName");
            entity.HasIndex("PostalCode");
            entity.HasIndex("Region");
            entity.HasMany(e => e.CustomerTypes)
                .WithMany(e => e.Customers)
                .UsingEntity<Dictionary<string, object>>(
                    "CustomerCustomerDemo",
                        l => l.HasOne<CustomerDemographic>().WithMany().HasForeignKey("CustomerTypeId"),
                        r => r.HasOne<Customer>().WithMany().HasForeignKey("CustomerId"),
                        j =>
                        {
                            j.ToTable("CustomerCustomerDemo");
                        });
        });

        modelBuilder.Entity<CustomerAndSuppliersByCity>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("Customer and Suppliers by City");
            entity.Property(e => e.City).HasMaxLength(15);
            entity.Property(e => e.CompanyName).HasMaxLength(40);
            entity.Property(e => e.ContactName).HasMaxLength(30);
            entity.Property(e => e.Relationship).HasMaxLength(9);
        });

        modelBuilder.Entity<CustomerDemographic>(entity =>
        {
            entity.HasKey("_customerTypeId");
            entity.Property<string>("_customerTypeId").HasColumnName("CustomerTypeID").HasMaxLength(10).IsFixedLength();
            entity.Property(e => e.CustomerDesc);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey("_employeeId");
            entity.Property<int>("_employeeId").HasColumnName("EmployeeID");
            entity.Property(e => e.Address).HasMaxLength(60);
            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.City).HasMaxLength(15);
            entity.Property(e => e.Country).HasMaxLength(15);
            entity.Property(e => e.Extension).HasMaxLength(4);
            entity.Property(e => e.FirstName).HasMaxLength(10);
            entity.Property(e => e.HireDate).HasColumnType("datetime");
            entity.Property(e => e.HomePhone).HasMaxLength(24);
            entity.Property(e => e.LastName).HasMaxLength(20);
            entity.Property(e => e.Notes);
            entity.Property(e => e.Photo).HasColumnType("image");
            entity.Property(e => e.PhotoPath).HasMaxLength(255);
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.Region).HasMaxLength(15);
            entity.Property(e => e.ReportsTo);
            entity.Property(e => e.Title).HasMaxLength(30);
            entity.Property(e => e.TitleOfCourtesy).HasMaxLength(25);
            entity.HasIndex("LastName");
            entity.HasIndex("PostalCode");
            entity.HasOne(e => e.ReportsToNavigation).WithMany(e => e.InverseReportsToNavigation).HasForeignKey("ReportsTo");
            entity.HasMany(e => e.Territories)
                .WithMany(e => e.Employees)
                .UsingEntity<Dictionary<string, object>>(
                    "EmployeeTerritory",
                        l => l.HasOne<Territory>().WithMany().HasForeignKey("TerritoryId"),
                        r => r.HasOne<Employee>().WithMany().HasForeignKey("EmployeeId"),
                        j =>
                        {
                            j.ToTable("EmployeeTerritories");
                        });
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("Invoices");
            entity.Property(e => e.Address).HasMaxLength(60);
            entity.Property(e => e.City).HasMaxLength(15);
            entity.Property(e => e.Country).HasMaxLength(15);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID").HasMaxLength(5).IsFixedLength();
            entity.Property(e => e.CustomerName).HasMaxLength(40);
            entity.Property(e => e.Discount);
            entity.Property(e => e.ExtendedPrice).HasColumnType("money");
            entity.Property(e => e.Freight).HasColumnType("money");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductName).HasMaxLength(40);
            entity.Property(e => e.Quantity);
            entity.Property(e => e.Region).HasMaxLength(15);
            entity.Property(e => e.RequiredDate).HasColumnType("datetime");
            entity.Property(e => e.Salesperson).HasMaxLength(31);
            entity.Property(e => e.ShipAddress).HasMaxLength(60);
            entity.Property(e => e.ShipCity).HasMaxLength(15);
            entity.Property(e => e.ShipCountry).HasMaxLength(15);
            entity.Property(e => e.ShipName).HasMaxLength(40);
            entity.Property(e => e.ShipPostalCode).HasMaxLength(10);
            entity.Property(e => e.ShipRegion).HasMaxLength(15);
            entity.Property(e => e.ShippedDate).HasColumnType("datetime");
            entity.Property(e => e.ShipperName).HasMaxLength(40);
            entity.Property(e => e.UnitPrice).HasColumnType("money");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey("_orderId");
            entity.Property<int>("_orderId").HasColumnName("OrderID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID").HasMaxLength(5).IsFixedLength();
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Freight).HasColumnType("money").HasDefaultValueSql("((0))");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.RequiredDate).HasColumnType("datetime");
            entity.Property(e => e.ShipAddress).HasMaxLength(60);
            entity.Property(e => e.ShipCity).HasMaxLength(15);
            entity.Property(e => e.ShipCountry).HasMaxLength(15);
            entity.Property(e => e.ShipName).HasMaxLength(40);
            entity.Property(e => e.ShipPostalCode).HasMaxLength(10);
            entity.Property(e => e.ShipRegion).HasMaxLength(15);
            entity.Property(e => e.ShipVia);
            entity.Property(e => e.ShippedDate).HasColumnType("datetime");
            entity.HasIndex("CustomerId");
            entity.HasIndex("CustomerId");
            entity.HasIndex("EmployeeId");
            entity.HasIndex("EmployeeId");
            entity.HasIndex("OrderDate");
            entity.HasIndex("ShipPostalCode");
            entity.HasIndex("ShippedDate");
            entity.HasIndex("ShipVia");
            entity.HasOne(e => e.Customer).WithMany(e => e.Orders).HasForeignKey("CustomerId");
            entity.HasOne(e => e.Employee).WithMany(e => e.Orders).HasForeignKey("EmployeeId");
            entity.HasOne(e => e.ShipViaNavigation).WithMany(e => e.Orders).HasForeignKey("ShipVia");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey("_orderId", "_productId");
            entity.ToTable("Order Details");
            entity.Property<int>("_orderId").HasColumnName("OrderID");
            entity.Property<int>("_productId").HasColumnName("ProductID");
            entity.Property(e => e.Discount);
            entity.Property(e => e.Quantity).HasDefaultValueSql("((1))");
            entity.Property(e => e.UnitPrice).HasColumnType("money");
            entity.HasIndex("_orderId");
            entity.HasIndex("_orderId");
            entity.HasIndex("_productId");
            entity.HasIndex("_productId");
            entity.HasOne(e => e.Order).WithMany(e => e.OrderDetails).HasForeignKey("_orderId");
            entity.HasOne(e => e.Product).WithMany(e => e.OrderDetails).HasForeignKey("_productId");
        });

        modelBuilder.Entity<OrderDetailsExtended>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("Order Details Extended");
            entity.Property(e => e.Discount);
            entity.Property(e => e.ExtendedPrice).HasColumnType("money");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductName).HasMaxLength(40);
            entity.Property(e => e.Quantity);
            entity.Property(e => e.UnitPrice).HasColumnType("money");
        });

        modelBuilder.Entity<OrderSubtotal>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("Order Subtotals");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Subtotal).HasColumnType("money");
        });

        modelBuilder.Entity<OrdersQry>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("Orders Qry");
            entity.Property(e => e.Address).HasMaxLength(60);
            entity.Property(e => e.City).HasMaxLength(15);
            entity.Property(e => e.CompanyName).HasMaxLength(40);
            entity.Property(e => e.Country).HasMaxLength(15);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID").HasMaxLength(5).IsFixedLength();
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Freight).HasColumnType("money");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.Region).HasMaxLength(15);
            entity.Property(e => e.RequiredDate).HasColumnType("datetime");
            entity.Property(e => e.ShipAddress).HasMaxLength(60);
            entity.Property(e => e.ShipCity).HasMaxLength(15);
            entity.Property(e => e.ShipCountry).HasMaxLength(15);
            entity.Property(e => e.ShipName).HasMaxLength(40);
            entity.Property(e => e.ShipPostalCode).HasMaxLength(10);
            entity.Property(e => e.ShipRegion).HasMaxLength(15);
            entity.Property(e => e.ShipVia);
            entity.Property(e => e.ShippedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey("_productId");
            entity.Property<int>("_productId").HasColumnName("ProductID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Discontinued);
            entity.Property(e => e.ProductName).HasMaxLength(40);
            entity.Property(e => e.QuantityPerUnit).HasMaxLength(20);
            entity.Property(e => e.ReorderLevel).HasDefaultValueSql("((0))");
            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.UnitPrice).HasColumnType("money").HasDefaultValueSql("((0))");
            entity.Property(e => e.UnitsInStock).HasDefaultValueSql("((0))");
            entity.Property(e => e.UnitsOnOrder).HasDefaultValueSql("((0))");
            entity.HasIndex("CategoryId");
            entity.HasIndex("CategoryId");
            entity.HasIndex("ProductName");
            entity.HasIndex("SupplierId");
            entity.HasIndex("SupplierId");
            entity.HasOne(e => e.Category).WithMany(e => e.Products).HasForeignKey("CategoryId");
            entity.HasOne(e => e.Supplier).WithMany(e => e.Products).HasForeignKey("SupplierId");
        });

        modelBuilder.Entity<ProductSalesFor1997>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("Product Sales for 1997");
            entity.Property(e => e.CategoryName).HasMaxLength(15);
            entity.Property(e => e.ProductName).HasMaxLength(40);
            entity.Property(e => e.ProductSales).HasColumnType("money");
        });

        modelBuilder.Entity<ProductsAboveAveragePrice>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("Products Above Average Price");
            entity.Property(e => e.ProductName).HasMaxLength(40);
            entity.Property(e => e.UnitPrice).HasColumnType("money");
        });

        modelBuilder.Entity<ProductsByCategory>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("Products by Category");
            entity.Property(e => e.CategoryName).HasMaxLength(15);
            entity.Property(e => e.Discontinued);
            entity.Property(e => e.ProductName).HasMaxLength(40);
            entity.Property(e => e.QuantityPerUnit).HasMaxLength(20);
            entity.Property(e => e.UnitsInStock);
        });

        modelBuilder.Entity<QuarterlyOrder>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("Quarterly Orders");
            entity.Property(e => e.City).HasMaxLength(15);
            entity.Property(e => e.CompanyName).HasMaxLength(40);
            entity.Property(e => e.Country).HasMaxLength(15);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID").HasMaxLength(5).IsFixedLength();
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey("_regionId");
            entity.ToTable("Region");
            entity.Property<int>("_regionId").HasColumnName("RegionID");
            entity.Property(e => e.RegionDescription).HasMaxLength(50).IsFixedLength();
        });

        modelBuilder.Entity<SalesByCategory>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("Sales by Category");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName).HasMaxLength(15);
            entity.Property(e => e.ProductName).HasMaxLength(40);
            entity.Property(e => e.ProductSales).HasColumnType("money");
        });

        modelBuilder.Entity<SalesTotalsByAmount>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("Sales Totals by Amount");
            entity.Property(e => e.CompanyName).HasMaxLength(40);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.SaleAmount).HasColumnType("money");
            entity.Property(e => e.ShippedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Shipper>(entity =>
        {
            entity.HasKey("_shipperId");
            entity.Property<int>("_shipperId").HasColumnName("ShipperID");
            entity.Property(e => e.CompanyName).HasMaxLength(40);
            entity.Property(e => e.Phone).HasMaxLength(24);
        });

        modelBuilder.Entity<SummaryOfSalesByQuarter>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("Summary of Sales by Quarter");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ShippedDate).HasColumnType("datetime");
            entity.Property(e => e.Subtotal).HasColumnType("money");
        });

        modelBuilder.Entity<SummaryOfSalesByYear>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("Summary of Sales by Year");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ShippedDate).HasColumnType("datetime");
            entity.Property(e => e.Subtotal).HasColumnType("money");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey("_supplierId");
            entity.Property<int>("_supplierId").HasColumnName("SupplierID");
            entity.Property(e => e.Address).HasMaxLength(60);
            entity.Property(e => e.City).HasMaxLength(15);
            entity.Property(e => e.CompanyName).HasMaxLength(40);
            entity.Property(e => e.ContactName).HasMaxLength(30);
            entity.Property(e => e.ContactTitle).HasMaxLength(30);
            entity.Property(e => e.Country).HasMaxLength(15);
            entity.Property(e => e.Fax).HasMaxLength(24);
            entity.Property(e => e.HomePage);
            entity.Property(e => e.Phone).HasMaxLength(24);
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.Region).HasMaxLength(15);
            entity.HasIndex("CompanyName");
            entity.HasIndex("PostalCode");
        });

        modelBuilder.Entity<Territory>(entity =>
        {
            entity.HasKey("_territoryId");
            entity.Property<string>("_territoryId").HasColumnName("TerritoryID").HasMaxLength(20);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.TerritoryDescription).HasMaxLength(50).IsFixedLength();
            entity.HasOne(e => e.Region).WithMany(e => e.Territories).HasForeignKey("RegionId");
        });

    }
}
