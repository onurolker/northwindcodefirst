using Northwind.DAL;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL
{
    public class UserController
    {
        private UserManagement userManagment;

        public UserController()
        {
            userManagment = new UserManagement();
        }
        public User AddUser(User user)
        {
            User addedUser = null;

            if (user == null)
                return null;

            if (user.Firstname.Length > 50)
                return null;

            addedUser = userManagment.AddUser(user);
            userManagment.UserChangeSave();

            return addedUser;
        }
    }
}
