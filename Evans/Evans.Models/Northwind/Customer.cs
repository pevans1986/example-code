using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Evans.Models.Northwind
{


    public class Customer
    {
        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Customer ID")]
        public string CustomerId { get; set; }

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Company name")]
        public string CompanyName { get; set; }

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Contact name")]
        public string ContactName { get; set; }

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Contact title")]
        public string ContactTitle { get; set; }

        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "City")]
        public string City { get; set; }

        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Region")]
        public string Region { get; set; }

        [MaxLength(10)]
        [StringLength(10)]
        [DataType(DataType.PostalCode)]
        [Display(Name = "Postal code")]
        public string PostalCode { get; set; }

        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [MaxLength(24)]
        [StringLength(24)]
        [Phone]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [MaxLength(24)]
        [StringLength(24)]
        [Phone]
        [Display(Name = "Fax")]
        public string Fax { get; set; }

        public virtual List<CustomerCustomerDemo> CustomerCustomerDemoes { get; set; } = new List<CustomerCustomerDemo>();
        public virtual List<Order> Orders { get; set; } = new List<Order>();
    }

}

