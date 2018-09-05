using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Evans.Models.Northwind
{


    public class OrderDetail
    {
        [Required]
        [Display(Name = "Order ID")]
        public int OrderId { get; set; }

        [Required]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Unit price")]
        public decimal UnitPrice { get; set; } = 0m;

        [Required]
        [Display(Name = "Quantity")]
        public short Quantity { get; set; } = 1;

        [Required]
        [Display(Name = "Discount")]
        public float Discount { get; set; } = 0f;


        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }

}

