using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _15DelegateUseDemo
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(Employee[] employees, PromoteDelegate PromoteBySalary)
        {
            foreach (Employee employee in employees)
            {
                if (PromoteBySalary(employee))
                {
                    Console.WriteLine($"{employee.Name}");
                }
    
            }

        }

        //public static Action<Employee[], Predicate<Employee>> PromoteEmployeeDelegate =  (Employee[] employees, Predicate<Employee> AnonymousDelegate) =>
        //{
        //    foreach (Employee employee in employees)
        //    {
        //        if (AnonymousDelegate(employee))
        //        {
        //            Console.WriteLine($"{employee.Name}");
        //        }

        //    }
        // };
        
    }
}
