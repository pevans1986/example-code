using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Evans.Models.Northwind
{


    public class Employee
    {
        [Required]
        [Display(Name = "Employee ID")]
        public int EmployeeId { get; set; }

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Title of courtesy")]
        public string TitleOfCourtesy { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Birth date")]
        public DateTime? BirthDate { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Hire date")]
        public DateTime? HireDate { get; set; }

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
        [Display(Name = "Home phone")]
        public string HomePhone { get; set; }

        [MaxLength(4)]
        [StringLength(4)]
        [Display(Name = "Extension")]
        public string Extension { get; set; }

        [MaxLength(2147483647)]
        [Display(Name = "Photo")]
        public byte[] Photo { get; set; }

        [MaxLength]
        [Display(Name = "Notes")]
        public string Notes { get; set; }

        [Display(Name = "Reports to")]
        public int? ReportsTo { get; set; }

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Photo path")]
        public string PhotoPath { get; set; }

        public virtual List<Employee> Employees { get; set; } = new List<Employee>();
        public virtual List<EmployeeTerritory> EmployeeTerritories { get; set; } = new List<EmployeeTerritory>();
        public virtual List<Order> Orders { get; set; } = new List<Order>();


        public virtual Employee Employee_ReportsTo { get; set; }
    }

}

