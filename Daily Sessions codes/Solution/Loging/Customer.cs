using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loging
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        ILoggin _loggin;
        public Customer(ILoggin login) { 
            _loggin = login;
        }
        public void login()
        {
            _loggin.Log($" {Id}, {Name}");
        }
    }
}
