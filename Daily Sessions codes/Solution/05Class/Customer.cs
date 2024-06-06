using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Class
{
    internal class Customer
    {
        string _firstName;
        string _lastName;
        public Customer() : this("No firstName","No LastName")//this means the current instance of the class
        {
            
        }
        public Customer(string firstname , string lastname) {
            _firstName = firstname;
            _lastName = lastname;
        }
        public void printFullName()
        {
            Console.WriteLine($"Full name is {_firstName},{_lastName}");
        }
        public void Print(string s)
        {
            Console.WriteLine(s);  
        }
    }
}
