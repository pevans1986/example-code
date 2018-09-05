using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Evans.Models.Northwind
{


    public class Product
    {
        [Required]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; }

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Product name")]
        public string ProductName { get; set; }

        [Display(Name = "Supplier ID")]
        public int? SupplierId { get; set; }

        [Display(Name = "Category ID")]
        public int? CategoryId { get; set; }

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Quantity per unit")]
        public string QuantityPerUnit { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Unit price")]
        public decimal? UnitPrice { get; set; } = 0m;

        [Display(Name = "Units in stock")]
        public short? UnitsInStock { get; set; } = 0;

        [Display(Name = "Units on order")]
        public short? UnitsOnOrder { get; set; } = 0;

        [Display(Name = "Reorder level")]
        public short? ReorderLevel { get; set; } = 0;

        [Required]
        [Display(Name = "Discontinued")]
        public bool Discontinued { get; set; } = false;

        public virtual List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();


        public virtual Category Category { get; set; }

        public virtual Supplier Supplier { get; set; }
    }

}

