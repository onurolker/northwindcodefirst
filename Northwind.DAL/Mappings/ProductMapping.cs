using Northwind.Entities;
using System.Data.Entity.ModelConfiguration;
namespace Northwind.DAL.Mappings
{
    class ProductMapping : EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
            HasKey(i => i.ProductId);
            Property(i => i.ProductName).IsRequired().HasMaxLength(50);
            Property(i => i.PurchasePrice).IsRequired().HasColumnType("money");
            Property(i => i.SellPrice).IsRequired().HasColumnType("money");
            Property(i => i.UnitsInStock).IsRequired();
            Property(i => i.ProductStatus).IsRequired().HasColumnType("bit");
        }
    }
}
