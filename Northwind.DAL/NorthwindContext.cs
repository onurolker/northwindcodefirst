using Northwind.DAL.Mappings;
using Northwind.Entities;
using Northwind.Helpers;
using System.Data.Entity;


namespace Northwind.DAL
{
    public class NorthwindContext:DbContext
    {
        public NorthwindContext():base(ConnectionTools.ConnectionString)
        {
            var ensureDLLIsCopied =
              System.Data.Entity.SqlServer.SqlProviderServices.Instance; //TODO TERRIBLE HACK DIYE GECIYOR
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Configurations.Add(new ProductMapping());
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Configurations.Add(new OrderMapping());
            modelBuilder.Entity<Order>().ToTable("Orders");
            modelBuilder.Configurations.Add(new OrderDetailsMapping());
            modelBuilder.Entity<OrderDetail>().ToTable("OrderDetails");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
