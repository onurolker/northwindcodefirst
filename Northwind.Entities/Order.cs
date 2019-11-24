using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Northwind.Entities.ShippingTypeEnum;

namespace Northwind.Entities
{
   public class Order
    {
        public int OrderId { get; set; }
        public string ShipName { get; set; }
        public string ShippingAddress { get; set; }
        public DateTime OrderDate { get; set; }
        public string Description { get; set; }
        public ShippingType ShippingType { get; set; }
        public User User { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
