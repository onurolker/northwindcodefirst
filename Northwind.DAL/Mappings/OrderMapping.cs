using Northwind.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Northwind.DAL.Mappings
{
    class OrderMapping:EntityTypeConfiguration<Order>
    {
        public OrderMapping()
        {
            HasKey(i => i.OrderId);
            Property(i => i.ShipName).IsRequired().HasMaxLength(50);
            Property(i => i.ShippingAddress).IsRequired().HasMaxLength(250);
            Property(i => i.OrderDate).IsRequired().HasColumnType("date");
            Property(i => i.ShippingType).IsRequired();
            Property(i => i.Description).IsRequired().HasMaxLength(2000);


        }
    }
}
