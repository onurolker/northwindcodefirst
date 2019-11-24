using Northwind.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Northwind.DAL.Mappings
{
    public class UserMapping:EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            HasKey(i => i.Id);
            Property(i => i.Firstname).IsRequired().HasMaxLength(50);
          
        }
    }
}
