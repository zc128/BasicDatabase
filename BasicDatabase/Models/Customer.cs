using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicDatabase.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }//Renamed from customerID in schema
        public string CompanyName { get; set; }
        public string Name { get; set; }//Renamed from contactName in schema
        public string ContactTitle { get; set; }
        [EmailAddress]
        public string Address { get; set; }
        public string City { get; set; }
        public int RegionID { get; set; }
        [ForeignKey("RegionID")]
        public Region Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        [Phone]
        public string Phone { get; set; }
        public int Fax { get; set; }
    }
}
