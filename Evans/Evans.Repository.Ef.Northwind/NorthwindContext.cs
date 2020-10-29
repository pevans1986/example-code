using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

using Evans.Models.Northwind;

namespace Evans.Repository.Ef.Northwind
{
	public class NorthwindContext : DbContext
	{
		#region Public Constructors

		static NorthwindContext()
		{
			Database.SetInitializer<NorthwindContext>(null);
		}

		public NorthwindContext()
			: base("Name=NorthwindContext")
		{
		}

		public NorthwindContext(string connectionString)
			: base(connectionString)
		{
		}

		#endregion Public Constructors

		#region Public Properties

		public DbSet<Category> Categories { get; set; }

		public DbSet<CustomerCustomerDemo> CustomerCustomerDemoes { get; set; }

		public DbSet<CustomerDemographic> CustomerDemographics { get; set; }

		public DbSet<Customer> Customers { get; set; }

		public DbSet<Employee> Employees { get; set; }

		public DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }

		public DbSet<OrderDetail> OrderDetails { get; set; }

		public DbSet<Order> Orders { get; set; }

		public DbSet<Product> Products { get; set; }

		public DbSet<Region> Regions { get; set; }

		public DbSet<Shipper> Shippers { get; set; }

		public DbSet<Supplier> Suppliers { get; set; }

		public DbSet<Territory> Territories { get; set; }

		#endregion Public Properties
	}
}