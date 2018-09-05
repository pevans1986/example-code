using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Evans.Models.Northwind
{


    public class Order
    {
        [Required]
        [Display(Name = "Order ID")]
        public int OrderId { get; set; }

        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Customer ID")]
        public string CustomerId { get; set; }

        [Display(Name = "Employee ID")]
        public int? EmployeeId { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Order date")]
        public DateTime? OrderDate { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Required date")]
        public DateTime? RequiredDate { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Shipped date")]
        public DateTime? ShippedDate { get; set; }

        [Display(Name = "Ship via")]
        public int? ShipVia { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Freight")]
        public decimal? Freight { get; set; } = 0m;

        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Ship name")]
        public string ShipName { get; set; }

        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "Ship address")]
        public string ShipAddress { get; set; }

        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Ship city")]
        public string ShipCity { get; set; }

        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Ship region")]
        public string ShipRegion { get; set; }

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Ship postal code")]
        public string ShipPostalCode { get; set; }

        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Ship country")]
        public string ShipCountry { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();


        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Shipper Shipper { get; set; }
    }

}

