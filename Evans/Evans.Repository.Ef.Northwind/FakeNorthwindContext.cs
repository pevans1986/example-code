using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Evans.Models.Northwind
{


    using System.Linq;

    public class FakeNorthwindContext : INorthwindContext
    {
        public System.Data.Entity.DbSet<Category> Categories { get; set; }
        public System.Data.Entity.DbSet<Customer> Customers { get; set; }
        public System.Data.Entity.DbSet<CustomerCustomerDemo> CustomerCustomerDemoes { get; set; }
        public System.Data.Entity.DbSet<CustomerDemographic> CustomerDemographics { get; set; }
        public System.Data.Entity.DbSet<Employee> Employees { get; set; }
        public System.Data.Entity.DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }
        public System.Data.Entity.DbSet<Order> Orders { get; set; }
        public System.Data.Entity.DbSet<OrderDetail> OrderDetails { get; set; }
        public System.Data.Entity.DbSet<Product> Products { get; set; }
        public System.Data.Entity.DbSet<Region> Regions { get; set; }
        public System.Data.Entity.DbSet<Shipper> Shippers { get; set; }
        public System.Data.Entity.DbSet<Supplier> Suppliers { get; set; }
        public System.Data.Entity.DbSet<Territory> Territories { get; set; }

        public FakeNorthwindContext()
        {
            _changeTracker = null;
            _configuration = null;
            _database = null;

            Categories = new FakeDbSet<Category>("CategoryId");
            Customers = new FakeDbSet<Customer>("CustomerId");
            CustomerCustomerDemoes = new FakeDbSet<CustomerCustomerDemo>("CustomerId", "CustomerTypeId");
            CustomerDemographics = new FakeDbSet<CustomerDemographic>("CustomerTypeId");
            Employees = new FakeDbSet<Employee>("EmployeeId");
            EmployeeTerritories = new FakeDbSet<EmployeeTerritory>("EmployeeId", "TerritoryId");
            Orders = new FakeDbSet<Order>("OrderId");
            OrderDetails = new FakeDbSet<OrderDetail>("OrderId", "ProductId");
            Products = new FakeDbSet<Product>("ProductId");
            Regions = new FakeDbSet<Region>("RegionId");
            Shippers = new FakeDbSet<Shipper>("ShipperId");
            Suppliers = new FakeDbSet<Supplier>("SupplierId");
            Territories = new FakeDbSet<Territory>("TerritoryId");
        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private System.Data.Entity.Infrastructure.DbChangeTracker _changeTracker;
        public System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get { return _changeTracker; } }
        private System.Data.Entity.Infrastructure.DbContextConfiguration _configuration;
        public System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get { return _configuration; } }
        private System.Data.Entity.Database _database;
        public System.Data.Entity.Database Database { get { return _database; } }
        public System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity)
        {
            throw new System.NotImplementedException();
        }
        public System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors()
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet Set(System.Type entityType)
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

    }
}

