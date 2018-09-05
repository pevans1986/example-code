using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Evans.Models.Northwind
{


    public class Region
    {
        [Required]
        [Display(Name = "Region ID")]
        public int RegionId { get; set; }

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Region description")]
        public string RegionDescription { get; set; }

        public virtual List<Territory> Territories { get; set; } = new List<Territory>();
    }

}

