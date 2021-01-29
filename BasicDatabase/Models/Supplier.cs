using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicDatabase.Models
{
    public class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        [EmailAddress]
        public string Address { get; set; }
        public string City { get; set; }
        public Region Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        [Phone]
        public string Phone { get; set; }
        public int Fax { get; set; }
        [Url(ErrorMessage = "Please use a valid URL")]
        public string HomePage { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
