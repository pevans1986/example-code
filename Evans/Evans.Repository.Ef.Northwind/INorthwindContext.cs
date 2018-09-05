using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Evans.Models.Northwind
{


    public interface INorthwindContext : System.IDisposable
    {
        System.Data.Entity.DbSet<Category> Categories { get; set; }
        System.Data.Entity.DbSet<Customer> Customers { get; set; }
        System.Data.Entity.DbSet<CustomerCustomerDemo> CustomerCustomerDemoes { get; set; }
        System.Data.Entity.DbSet<CustomerDemographic> CustomerDemographics { get; set; }
        System.Data.Entity.DbSet<Employee> Employees { get; set; }
        System.Data.Entity.DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }
        System.Data.Entity.DbSet<Order> Orders { get; set; }
        System.Data.Entity.DbSet<OrderDetail> OrderDetails { get; set; }
        System.Data.Entity.DbSet<Product> Products { get; set; }
        System.Data.Entity.DbSet<Region> Regions { get; set; }
        System.Data.Entity.DbSet<Shipper> Shippers { get; set; }
        System.Data.Entity.DbSet<Supplier> Suppliers { get; set; }
        System.Data.Entity.DbSet<Territory> Territories { get; set; }

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; }
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; }
        System.Data.Entity.Database Database { get; }
        System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
        System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors();
        System.Data.Entity.DbSet Set(System.Type entityType);
        System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();
    }

}

