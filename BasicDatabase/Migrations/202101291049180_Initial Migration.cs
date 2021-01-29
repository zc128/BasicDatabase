namespace BasicDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(maxLength: 4000),
                        Picture = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        CategoryID = c.Int(nullable: false),
                        SupplierID = c.Int(nullable: false),
                        QuantityPerLabel = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UnitsInStock = c.Int(nullable: false),
                        UnitsOnOrder = c.Int(nullable: false),
                        ReorderLevel = c.String(),
                        Discontinued = c.String(),
                        Order_OrderID = c.Int(),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Category", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Supplier", t => t.SupplierID, cascadeDelete: true)
                .ForeignKey("dbo.Order", t => t.Order_OrderID)
                .Index(t => t.CategoryID)
                .Index(t => t.SupplierID)
                .Index(t => t.Order_OrderID);
            
            CreateTable(
                "dbo.Supplier",
                c => new
                    {
                        SupplierID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        ContactName = c.String(),
                        ContactTitle = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        PostalCode = c.String(),
                        Country = c.String(),
                        Phone = c.String(),
                        Fax = c.Int(nullable: false),
                        HomePage = c.String(),
                        Region_RegionID = c.Int(),
                    })
                .PrimaryKey(t => t.SupplierID)
                .ForeignKey("dbo.Region", t => t.Region_RegionID)
                .Index(t => t.Region_RegionID);
            
            CreateTable(
                "dbo.Region",
                c => new
                    {
                        RegionID = c.Int(nullable: false, identity: true),
                        RegionDescription = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.RegionID);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        Title = c.String(),
                        TitleOfCourtesy = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        RegionID = c.Int(),
                        PostalCode = c.String(),
                        Country = c.String(),
                        HomePhone = c.String(),
                        Extension = c.String(),
                        Photo = c.String(),
                        Notes = c.String(),
                        ReportsTo = c.String(),
                        PhotoPath = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.Region", t => t.RegionID)
                .Index(t => t.RegionID);
            
            CreateTable(
                "dbo.Territory",
                c => new
                    {
                        TerritoryID = c.Int(nullable: false, identity: true),
                        TerritoryDescription = c.String(maxLength: 4000),
                        RegionID = c.Int(),
                    })
                .PrimaryKey(t => t.TerritoryID)
                .ForeignKey("dbo.Region", t => t.RegionID)
                .Index(t => t.RegionID);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        Name = c.String(),
                        ContactTitle = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        RegionID = c.Int(nullable: false),
                        PostalCode = c.String(),
                        Country = c.String(),
                        Phone = c.String(),
                        Fax = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Region", t => t.RegionID, cascadeDelete: true)
                .Index(t => t.RegionID);
            
            CreateTable(
                "dbo.OrderDetail",
                c => new
                    {
                        OrderDetailID = c.Int(nullable: false, identity: true),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        Discount = c.Double(nullable: false),
                        order_OrderID = c.Int(),
                        Product_ProductID = c.Int(),
                    })
                .PrimaryKey(t => t.OrderDetailID)
                .ForeignKey("dbo.Order", t => t.order_OrderID)
                .ForeignKey("dbo.Product", t => t.Product_ProductID)
                .Index(t => t.order_OrderID)
                .Index(t => t.Product_ProductID);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                        ShipVia = c.String(),
                        Freight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ShipName = c.String(),
                        ShipAddress = c.String(),
                        ShipCity = c.String(),
                        ShipRegion = c.String(),
                        ShipPostalCode = c.String(),
                        ShipCountry = c.String(),
                        ShipperID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customer", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Employee", t => t.EmployeeID, cascadeDelete: true)
                .ForeignKey("dbo.Shipper", t => t.ShipperID, cascadeDelete: true)
                .Index(t => t.CustomerID)
                .Index(t => t.EmployeeID)
                .Index(t => t.ShipperID);
            
            CreateTable(
                "dbo.Shipper",
                c => new
                    {
                        ShipperID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.ShipperID);
            
            CreateTable(
                "dbo.TerritoryEmployee",
                c => new
                    {
                        Territory_TerritoryID = c.Int(nullable: false),
                        Employee_EmployeeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Territory_TerritoryID, t.Employee_EmployeeID })
                .ForeignKey("dbo.Territory", t => t.Territory_TerritoryID, cascadeDelete: true)
                .ForeignKey("dbo.Employee", t => t.Employee_EmployeeID, cascadeDelete: true)
                .Index(t => t.Territory_TerritoryID)
                .Index(t => t.Employee_EmployeeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetail", "Product_ProductID", "dbo.Product");
            DropForeignKey("dbo.OrderDetail", "order_OrderID", "dbo.Order");
            DropForeignKey("dbo.Order", "ShipperID", "dbo.Shipper");
            DropForeignKey("dbo.Product", "Order_OrderID", "dbo.Order");
            DropForeignKey("dbo.Order", "EmployeeID", "dbo.Employee");
            DropForeignKey("dbo.Order", "CustomerID", "dbo.Customer");
            DropForeignKey("dbo.Customer", "RegionID", "dbo.Region");
            DropForeignKey("dbo.Supplier", "Region_RegionID", "dbo.Region");
            DropForeignKey("dbo.Territory", "RegionID", "dbo.Region");
            DropForeignKey("dbo.TerritoryEmployee", "Employee_EmployeeID", "dbo.Employee");
            DropForeignKey("dbo.TerritoryEmployee", "Territory_TerritoryID", "dbo.Territory");
            DropForeignKey("dbo.Employee", "RegionID", "dbo.Region");
            DropForeignKey("dbo.Product", "SupplierID", "dbo.Supplier");
            DropForeignKey("dbo.Product", "CategoryID", "dbo.Category");
            DropIndex("dbo.TerritoryEmployee", new[] { "Employee_EmployeeID" });
            DropIndex("dbo.TerritoryEmployee", new[] { "Territory_TerritoryID" });
            DropIndex("dbo.Order", new[] { "ShipperID" });
            DropIndex("dbo.Order", new[] { "EmployeeID" });
            DropIndex("dbo.Order", new[] { "CustomerID" });
            DropIndex("dbo.OrderDetail", new[] { "Product_ProductID" });
            DropIndex("dbo.OrderDetail", new[] { "order_OrderID" });
            DropIndex("dbo.Customer", new[] { "RegionID" });
            DropIndex("dbo.Territory", new[] { "RegionID" });
            DropIndex("dbo.Employee", new[] { "RegionID" });
            DropIndex("dbo.Supplier", new[] { "Region_RegionID" });
            DropIndex("dbo.Product", new[] { "Order_OrderID" });
            DropIndex("dbo.Product", new[] { "SupplierID" });
            DropIndex("dbo.Product", new[] { "CategoryID" });
            DropTable("dbo.TerritoryEmployee");
            DropTable("dbo.Shipper");
            DropTable("dbo.Order");
            DropTable("dbo.OrderDetail");
            DropTable("dbo.Customer");
            DropTable("dbo.Territory");
            DropTable("dbo.Employee");
            DropTable("dbo.Region");
            DropTable("dbo.Supplier");
            DropTable("dbo.Product");
            DropTable("dbo.Category");
        }
    }
}
