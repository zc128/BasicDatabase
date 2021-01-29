using System;
using System.Collections;
using System.Collections.Generic;
using BasicDatabase.Models;
using BasicDatabase.Contexts;
using System.Linq;

namespace BasicDatabase
{
    public class Program
    {   
        static void Main(string[] args)
        {
            Category catA = new Category()
            {
                Name = "Category A",
                Description = "This is Category A",
                Picture = "https://www.google.com/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png"
            }; 
            Category catB = new Category()
            {
                Name = "Category B",
                Description = "This is Category B",
                Picture = "https://www.google.com/images/branding/googlelogo/2x/googlelogo_color_92x30dp.png"
            };
         
            Region reA = new Region()
            {
                RegionDescription = "Eastern North-America"
            };
            Region reB = new Region()
            {
                RegionDescription = "Western North-America"
            };
            Territory terrA = new Territory()
            {
                TerritoryDescription = "East-Canada",
                Region = reA
            };
            Territory terrB = new Territory()
            {
                TerritoryDescription = "West-Canada",
                Region = reB
            };           
            ICollection<Territory> TerritoryListA = new List<Territory>();
            TerritoryListA.Add(terrA);
            ICollection<Territory> TerritoryListB = new List<Territory>();
            TerritoryListB.Add(terrB);
            Shipper shipperA = new Shipper()
            {
                CompanyName = "Shipping Company A",
                Phone = "11111111"
            };
            Shipper shipperB = new Shipper()
            {
                CompanyName = "Shipping Company B",
                Phone = "22222222"
            };
     
            Supplier supA = new Supplier()
            {
                CompanyName = "supplierA",
                ContactName = "Tommy",
                ContactTitle = "Mr.",
                Address = "supplierA@gmail.com",
                City = "Toronto",
                Region = reA,
                PostalCode = "P3L 3A3",
                Country = "Canada",
                Phone = "123321321",
                Fax = 999654312,
                HomePage = "https://www.supplierA.com/"
            };
            Supplier supB = new Supplier()
            {
                CompanyName = "supplierB",
                ContactName = "Johnny",
                ContactTitle = "Mr.",
                Address = "supplierB@gmail.com",
                City = "Toronto",
                Region = reA,
                PostalCode = "P4L 4A3",
                Country = "Canada",
                Phone = "123431321",
                Fax = 944654312,
                HomePage = "https://www.supplierB.com/"
            };
            Product prodA = new Product()
            {
                ProductName = "product A",
                Category = catA,
                Supplier = supB,
                QuantityPerLabel = 4,
                UnitPrice = 10.00M,
                UnitsInStock = 26,
                UnitsOnOrder = 5,
                ReorderLevel = "High",
                Discontinued = "None"
            };
            Product prodB = new Product()
            {
                ProductName = "product B",
                Category = catB,
                Supplier = supA,
                QuantityPerLabel = 5,
                UnitPrice = 11.00M,
                UnitsInStock = 25,
                UnitsOnOrder = 6,
                ReorderLevel = "High",
                Discontinued = "None"
            };
            Product prodC = new Product()
            {
                ProductName = "product C",
                Category = catA,
                Supplier = supA,
                QuantityPerLabel = 6,
                UnitPrice = 12.00M,
                UnitsInStock = 24,
                UnitsOnOrder = 7,
                ReorderLevel = "High",
                Discontinued = "None"
            };
            Product prodD = new Product()
            {
                ProductName = "product D",
                Category = catB,
                Supplier = supB,
                QuantityPerLabel = 7,
                UnitPrice = 13.00M,
                UnitsInStock = 23,
                UnitsOnOrder = 8,
                ReorderLevel = "High",
                Discontinued = "None"
            };
            Product prodE = new Product()
            {
                ProductName = "product E",
                Category = catA,
                Supplier = supB,
                QuantityPerLabel = 8,
                UnitPrice = 14.00M,
                UnitsInStock = 22,
                UnitsOnOrder = 9,
                ReorderLevel = "High",
                Discontinued = "None"
            };
            ICollection<Product> ProductListA = new List<Product>();
            ProductListA.Add(prodA);
            ProductListA.Add(prodB);
            ProductListA.Add(prodC);
            ProductListA.Add(prodD);
            ProductListA.Add(prodE);
            ICollection<Product> ProductListB = new List<Product>();
            ProductListB.Add(prodA);
            ProductListB.Add(prodD);
            ProductListB.Add(prodE);
            ICollection<Product> ProductListC = new List<Product>();
            ProductListC.Add(prodA);
            ProductListC.Add(prodB);        
            ICollection<Product> ProductListD = new List<Product>();
            ProductListD.Add(prodA);
            ProductListD.Add(prodB);
            ProductListD.Add(prodC);           
            ICollection<Product> ProductListE = new List<Product>();
            ProductListE.Add(prodA);
            ProductListE.Add(prodB);
            ProductListE.Add(prodC);
            ProductListE.Add(prodD);

            Customer cusA = new Customer()
            {
                CompanyName = "comA",
                Name = "Krystyna Jarvie",
                ContactTitle = "Ms.",
                Address = "1213@gmail.com",
                City = "Sudbury",
                Region = reA,
                PostalCode = "P1P 5S5",
                Country = "Canada",
                Phone = "232333123",
                Fax = 113123123,
                
            };
            Customer cusB = new Customer()
            {
                CompanyName = "comA",
                Name = "Enda Bascom",
                ContactTitle = "Ms.",
                Address = "1223@gmail.com",
                City = "Toronto",
                Region = reB,
                PostalCode = "P4P 2S2",
                Country = "Canada",
                Phone = "232345423",
                Fax = 123123123,
               
            };
            Customer cusC = new Customer()
            {
                CompanyName = "comA",
                Name = "Newton Amedee",
                ContactTitle = "Mr.",
                Address = "1233@gmail.com",
                City = "Sudbury",
                Region = reA,
                PostalCode = "P2P 3S2",
                Country = "Canada",
                Phone = "232334543",
                Fax = 133123123,
                
            };
            Customer cusD = new Customer()
            {
                CompanyName = "comA",
                Name = "Hang Figaro",
                ContactTitle = "Mr.",
                Address = "1243@gmail.com",
                City = "Toronto",
                Region = reB,
                PostalCode = "P1P 4S2",
                Country = "Canada",
                Phone = "245433123",
                Fax = 143123123,
               
            };
            Customer cusE = new Customer()
            {
                CompanyName = "comA",
                Name = "Janna Piano",
                ContactTitle = "Ms.",
                Address = "1253@gmail.com",
                City = "Sudbury",
                Region = reA,
                PostalCode = "P1Z 2S2",
                Country = "Canada",
                Phone = "452333125",
                Fax = 153123123,
                
            };
            Employee empA = new Employee()
            {
                LastName = "Cai",
                FirstName = "Zhihong",
                Title = "Marketing Coordinator",
                TitleOfCourtesy = "Mr.",
                Address = "789@gmail.com",
                City = "Sudbury",
                PostalCode = "P3A 3S3",
                Country = "Canada",
                HomePhone = "125123654",
                Extension = "0325",
                Photo = "https://i.pinimg.com/736x/f8/2f/ba/f82fbac7514f944aacc0257445c1f89e.jpg",
                Notes = "None",
                ReportsTo = "CEO",
                Territories = TerritoryListA,
                Region = reA,
                PhotoPath = "https://i.pinimg.com/736x/f8/2f/ba/f82fbac7514f944aacc0257445c1f89e.jpg"
            };
            Employee empB = new Employee()
            {
                LastName = "Jones",
                FirstName = "Alberto",
                Title = "Web Designer",
                TitleOfCourtesy = "Mr.",
                Address = "7839@gmail.com",
                City = "Sudbury",
                PostalCode = "P4A 3S3",
                Country = "Canada",
                HomePhone = "235123654",
                Extension = "0326",
                Photo = "https://i.pinimg.com/736x/f8/2f/ba/f82fbac7514f944aacc0257445c1f89e.jpg",
                Notes = "None",
                ReportsTo = "CEO",
                Territories = TerritoryListA,
                Region = reA,
                PhotoPath = "https://i.pinimg.com/736x/f8/2f/ba/f82fbac7514f944aacc0257445c1f89e.jpg"
            };
            Employee empC = new Employee()
            {
                LastName = "Williams",
                FirstName = "Ara",
                Title = "President of Sales",
                TitleOfCourtesy = "Ms.",
                Address = "7849@gmail.com",
                City = "Sudbury",
                PostalCode = "P5A 3S3",
                Country = "Canada",
                HomePhone = "345123654",
                Extension = "0327",
                Photo = "https://i.pinimg.com/736x/f8/2f/ba/f82fbac7514f944aacc0257445c1f89e.jpg",
                Notes = "None",
                ReportsTo = "CEO",
                Territories = TerritoryListA,
                Region = reA,
                PhotoPath = "https://i.pinimg.com/736x/f8/2f/ba/f82fbac7514f944aacc0257445c1f89e.jpg"

            };
            Employee empD = new Employee()
            {
                LastName = "Johnson",
                FirstName = "Leah",
                Title = "Project Manager",
                TitleOfCourtesy = "Mr.",
                Address = "4559@gmail.com",
                City = "Sudbury",
                PostalCode = "P6A 3S3",
                Country = "Canada",
                HomePhone = "455123654",
                Extension = "0328",
                Photo = "https://i.pinimg.com/736x/f8/2f/ba/f82fbac7514f944aacc0257445c1f89e.jpg",
                Notes = "None",
                ReportsTo = "CEO",
                Territories = TerritoryListB,
                Region = reB,
                PhotoPath = "https://i.pinimg.com/736x/f8/2f/ba/f82fbac7514f944aacc0257445c1f89e.jpg"

            };
            Employee empE = new Employee()
            {
                LastName = "Smith",
                FirstName = "Carla",
                Title = "Marketing Consultant",
                TitleOfCourtesy = "Ms.",
                Address = "7869@gmail.com",
                City = "Sudbury",
                PostalCode = "P7A 3S3",
                Country = "Canada",
                HomePhone = "565123654",
                Extension = "0329",
                Photo = "https://i.pinimg.com/736x/f8/2f/ba/f82fbac7514f944aacc0257445c1f89e.jpg",
                Notes = "None",
                ReportsTo = "CEO",
                Territories = TerritoryListB,
                Region = reB,
                PhotoPath = "https://i.pinimg.com/736x/f8/2f/ba/f82fbac7514f944aacc0257445c1f89e.jpg"

            };

            Order ordA = new Order()
            {
                customer = cusA,
                Employee = empA,
                ShipVia = "Train",
                Freight = 1000.00M,
                ShipName = "ShipA",
                ShipAddress = "123 ABCStreet, NorthBay",
                ShipCity = "NorthBay",
                ShipRegion = "NA",
                ShipPostalCode = "P1P 2K2",
                ShipCountry = "Canada",
                Shipper = shipperB,
                Products = ProductListA
            };
            Order ordB = new Order()
            {
                customer = cusB,
                Employee = empB,
                ShipVia = "Train",
                Freight = 1200.00M,
                ShipName = "ShipB",
                ShipAddress = "1223 ABCStreet, Toronto",
                ShipCity = "Toronto",
                ShipRegion = "NA",
                ShipPostalCode = "P2P 2K2",
                ShipCountry = "Canada",
                Shipper = shipperA,
                Products = ProductListB
            };
            Order ordC = new Order()
            {
                customer = cusC,
                Employee = empC,
                ShipVia = "Train",
                Freight = 1300.00M,
                ShipName = "ShipC",
                ShipAddress = "233 ABCStreet, Montreal",
                ShipCity = "Montreal",
                ShipRegion = "NA",
                ShipPostalCode = "P4P 2K2",
                ShipCountry = "Canada",
                Shipper = shipperB,
                Products = ProductListC
            };
            Order ordD = new Order()
            {
                customer = cusD,
                Employee = empD,
                ShipVia = "Train",
                Freight = 1400.00M,
                ShipName = "ShipD",
                ShipAddress = "888 ABCStreet, London",
                ShipCity = "London",
                ShipRegion = "NA",
                ShipPostalCode = "P6P 3K2",
                ShipCountry = "Canada",
                Shipper = shipperA,
                Products = ProductListD
            };
            Order ordE = new Order()
            {
                customer = cusE,
                Employee = empE,
                ShipVia = "Train",
                Freight = 1500.00M,
                ShipName = "ShipE",
                ShipAddress = "999 ABCStreet, NorthBay",
                ShipCity = "NorthBay",
                ShipRegion = "NA",
                ShipPostalCode = "P1K 4K3",
                ShipCountry = "Canada",
                Shipper = shipperA,
                Products = ProductListE
            };
            OrderDetail ordDetailA = new OrderDetail()
            {
                UnitPrice = 20.00M,
                Quantity = 9,
                Discount = 0.80d,
                order = ordA,
                Product = prodA
            };
            OrderDetail ordDetailB = new OrderDetail()
            {
                UnitPrice = 10.00M,
                Quantity = 5,
                Discount = 0.70d,
                order = ordB,
                Product = prodB
            };
            using (OrderContext orderctx = new OrderContext())
            {
                orderctx.Products.Add(prodA);
                orderctx.Products.Add(prodB);
                orderctx.Products.Add(prodC);
                orderctx.Products.Add(prodD);
                orderctx.Products.Add(prodE);
                orderctx.Customers.Add(cusA);
                orderctx.Customers.Add(cusB);
                orderctx.Customers.Add(cusC);
                orderctx.Customers.Add(cusD);
                orderctx.Customers.Add(cusE);
                orderctx.Employees.Add(empA);
                orderctx.Employees.Add(empB);
                orderctx.Employees.Add(empC);
                orderctx.Employees.Add(empD);
                orderctx.Employees.Add(empE);
                orderctx.Orders.Add(ordA);
                orderctx.Orders.Add(ordB);
                orderctx.Orders.Add(ordC);
                orderctx.Orders.Add(ordD);
                orderctx.Orders.Add(ordE);
                orderctx.Categories.Add(catA);
                orderctx.Categories.Add(catB);
                orderctx.OrderDetails.Add(ordDetailA);
                orderctx.OrderDetails.Add(ordDetailB);
                orderctx.Regions.Add(reA);
                orderctx.Regions.Add(reB);
                orderctx.Shippers.Add(shipperA);
                orderctx.Shippers.Add(shipperB);
                orderctx.Suppliers.Add(supA);
                orderctx.Suppliers.Add(supB);
                orderctx.Territories.Add(terrA);
                orderctx.Territories.Add(terrB);
                orderctx.SaveChanges();

            }
        }
    }
}
