using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicDatabase.Models
{
    public class Region
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegionID { get; set; }
        [StringLength(4000)]
        public string RegionDescription { get; set; }
        public ICollection<Territory>  Territories { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
