using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Evans.Models.Northwind
{


    public class EmployeeTerritory
    {
        [Required]
        [Display(Name = "Employee ID")]
        public int EmployeeId { get; set; }

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Territory ID")]
        public string TerritoryId { get; set; }


        public virtual Employee Employee { get; set; }

        public virtual Territory Territory { get; set; }
    }

}

