
using System.Collections.Generic;

namespace Northwind.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }       
        public decimal PurchasePrice { get; set; }
        public decimal SellPrice { get; set; }
        public int UnitsInStock { get; set; }
        public bool ProductStatus { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
