using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicDatabase.Models
{
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderDetailID { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
/*        public int OrderID { get; set; }
        [ForeignKey("OrderID")]*/
        public Order order { get; set; }
/*        public int ProductID { get; set; }
        [ForeignKey("ProductID")]*/
        public Product Product { get; set; }
    }
}
