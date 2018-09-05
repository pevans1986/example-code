using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Evans.Models.Northwind
{


    public class Shipper
    {
        [Required]
        [Display(Name = "Shipper ID")]
        public int ShipperId { get; set; }

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Company name")]
        public string CompanyName { get; set; }

        [MaxLength(24)]
        [StringLength(24)]
        [Phone]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        public virtual List<Order> Orders { get; set; } = new List<Order>();
    }

}

