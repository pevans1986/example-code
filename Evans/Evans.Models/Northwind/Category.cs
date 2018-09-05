using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Evans.Models.Northwind
{


    public class Category
    {
        [Required]
        [Display(Name = "Category ID")]
        public int CategoryId { get; set; }

        [Required(AllowEmptyStrings = true)]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Category name")]
        public string CategoryName { get; set; }

        [MaxLength]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [MaxLength(2147483647)]
        [Display(Name = "Picture")]
        public byte[] Picture { get; set; }

        public virtual List<Product> Products { get; set; } = new List<Product>();
    }

}

