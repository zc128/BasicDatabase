using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicDatabase.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public Customer customer { get; set;}
        public int EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
       /* public DateTime OrderDate { get; set; }
        public DateTime RequireDate { get; set; }
        public DateTime ShippedDate { get; set; }*/
        public string ShipVia { get; set; }
        public decimal Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public int ShipperID { get; set; }
        [ForeignKey("ShipperID")]
        public Shipper Shipper { get; set; }
        public ICollection<Product> Products { get; set;}
 
    }
}
