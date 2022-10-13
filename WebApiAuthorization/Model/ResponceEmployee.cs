using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiAuthorization.Models;

namespace WebApiAuthorization.Model
{
    public partial class ResponceEmployee
    {
        public ResponceEmployee(User employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Login = employee.Login;
            Password = employee.Password;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }

   
}
