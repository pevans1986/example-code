using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Evans.Models.Northwind
{


    public class Territory
    {
        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Territory ID")]
        public string TerritoryId { get; set; }

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Territory description")]
        public string TerritoryDescription { get; set; }

        [Required]
        [Display(Name = "Region ID")]
        public int RegionId { get; set; }

        public virtual List<EmployeeTerritory> EmployeeTerritories { get; set; } = new List<EmployeeTerritory>();


        public virtual Region Region { get; set; }
    }

}

