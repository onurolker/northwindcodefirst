using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Northwind.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        [DataType(DataType.EmailAddress)]
        public string MailAddress { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
