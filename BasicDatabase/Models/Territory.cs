using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicDatabase.Models
{
    public class Territory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TerritoryID { get; set; }
        [StringLength(4000)]
        public string TerritoryDescription { get; set; }
        public int? RegionID { get; set; }
        [ForeignKey("RegionID")]
        public Region Region { get; set; }
        public ICollection<Employee> Employees { get; set;}
    }
}
