using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicDatabase.Models
{
    public class Shipper
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        [Phone]
        public string Phone { get; set; }
        public ICollection<Order> orders { get; set; }
    }
}
