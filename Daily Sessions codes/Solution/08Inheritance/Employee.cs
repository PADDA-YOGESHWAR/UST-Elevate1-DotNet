using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Inheritance
{
    public class Employee
    {
        public string FirstName = "John";
        public string LastName = "Thomas";


        public virtual void PrintFullName()
        {
            Console.WriteLine($"FirstName: {FirstName}, LastName: {LastName}");
        }
    }

    public class FullTimeEmployee : Employee
    {

        public override void PrintFullName()
        {

            Console.WriteLine($"FirstName: {FirstName}, LastName: {LastName} - Full Time");
        }

    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {

            Console.WriteLine($"FirstName: {FirstName}, LastName: {LastName} - Part Time");
        }
    }

    public class TemporaryTimeEmployee : Employee
    {
        public override void PrintFullName()
        {

            Console.WriteLine($"FirstName: {FirstName}, LastName: {LastName} - Temp Time");
        }
    }
}
