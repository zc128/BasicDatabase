using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicDatabase.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }//Renamed from categoryID in schema
        public string Name { get; set; }//Renamed from categoryName in schema
        [StringLength(4000)]
        public string Description { get; set; }
        [Url(ErrorMessage = "Please use a valid URL")]
        public string Picture { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
