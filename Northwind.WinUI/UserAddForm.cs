using MaterialSkin.Controls;
using Northwind.BLL;
using Northwind.Entities;
using System;
using System.Windows.Forms;

namespace Northwind.WinUI
{
    public partial class UserAddForm : MaterialForm
    {
        public UserAddForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            User user = new User()
            {
                Firstname = txtFirstName.Text,
                Lastname=txtLastName.Text,
                MailAddress=txtMail.Text,
                PhoneNumber=txtPhone.Text,
                UserPassword=txxtPassword.Text
             
            };
            userController.AddUser(user);
        }
    }
}
