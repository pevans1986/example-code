using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Evans.Models.Northwind
{


    public class CustomerDemographic
    {
        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Customer type ID")]
        public string CustomerTypeId { get; set; }

        [MaxLength]
        [Display(Name = "Customer desc")]
        public string CustomerDesc { get; set; }

        public virtual List<CustomerCustomerDemo> CustomerCustomerDemoes { get; set; } = new List<CustomerCustomerDemo>();
    }

}

