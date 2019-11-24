using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL
{
    public class UserManagement
    {
        private NorthwindContext database;
        public UserManagement()
        {
            database = new NorthwindContext();
        }    

        public User AddUser(User user)
        {
            return database.Set<User>().Add(user);
        }
        public int UserChangeSave()
        {
            return database.SaveChanges();
        }
    }
}
