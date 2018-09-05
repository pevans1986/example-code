using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Evans.Models.Northwind
{


    public class CustomerCustomerDemo
    {
        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Customer ID")]
        public string CustomerId { get; set; }

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Customer type ID")]
        public string CustomerTypeId { get; set; }


        public virtual Customer Customer { get; set; }

        public virtual CustomerDemographic CustomerDemographic { get; set; }
    }

}

