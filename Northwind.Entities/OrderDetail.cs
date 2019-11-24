

namespace Northwind.Entities
{
   public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Order Orders { get; set; }
        public Product Products { get; set; }
    }
}
