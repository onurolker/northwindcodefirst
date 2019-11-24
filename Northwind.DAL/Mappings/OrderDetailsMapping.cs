using Northwind.Entities;
using System.Data.Entity.ModelConfiguration;


namespace Northwind.DAL.Mappings
{
    class OrderDetailsMapping: EntityTypeConfiguration<OrderDetail>
    {

        public OrderDetailsMapping()
        {
            HasKey(i => i.OrderDetailId);
            Property(i => i.Quantity).IsRequired();
            Property(i => i.Price).IsRequired().HasPrecision(16,2);
        }
    }
}
