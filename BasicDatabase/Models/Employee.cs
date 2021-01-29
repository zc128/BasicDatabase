using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicDatabase.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
    /*    public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }*/
        [EmailAddress]
        public string Address { get; set; }
        public string City { get; set; }   
        public int? RegionID { get; set; }
        [ForeignKey("RegionID")]
        public Region Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        [Phone]
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        [Url(ErrorMessage = "Please use a valid URL")]
        public string Photo { get; set; }
        public string Notes { get; set; }
        public string ReportsTo { get; set; }
        [Url(ErrorMessage = "Please use a valid URL")]
        public string PhotoPath { get; set; }
        public ICollection<Territory> Territories { get; set; }

    }
}
