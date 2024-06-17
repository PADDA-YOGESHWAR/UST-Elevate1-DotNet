using System.Reflection.Metadata.Ecma335;

namespace _15DelegateUseDemo
{
    public delegate bool PromoteDelegate(Employee employee);
   
    public class Program
    {
        
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            employees[0] = new Employee() { Id = 1, Name="Yogesh", Salary = 12000, Experience = 2 };
            employees[1] = new Employee() { Id = 2, Name = "Lucky", Salary = 8000, Experience = 1 };
            employees[2] = new Employee() { Id = 3, Name = "Praveen", Salary = 20000, Experience = 5 };
            PromoteDelegate IsPromoteDelegate = new PromoteDelegate(PromoteBySalary);
            Console.WriteLine("Promote by Salary");
            Employee.PromoteEmployee(employees, IsPromoteDelegate);

            //IsPromoteDelegate += PromoteByExperiece;
            //Console.WriteLine("Promote by Experience");
            //Employee.PromoteEmployee(employees, IsPromoteDelegate);
            //IsPromoteDelegate += PromoteByBoth;
            //Console.WriteLine("Promote by Experience and salary");
            //Employee.PromoteEmployee(employees, IsPromoteDelegate);


            //Console.WriteLine("Promote by salary");
            //Predicate<Employee> AnonymousDelegate =  (Employee employee) => employee.Salary > 10000;
            //Employee.PromoteEmployeeDelegate(employees, AnonymousDelegate);


            //Console.WriteLine("Promote by experience");
            //Predicate<Employee> AnonymousDelegate2 = (Employee employee) => employee.Experience > 2;
            //Employee.PromoteEmployeeDelegate(employees, AnonymousDelegate2);
            //Console.WriteLine("Promote by salary and experience");
            //Predicate<Employee> AnonymousDelegate3 = (Employee employee) => employee.Salary > 10000 && employee.Experience > 2;
            //Employee.PromoteEmployeeDelegate(employees, AnonymousDelegate3);
        }
        static bool PromoteBySalary(Employee employee)
        {
            if (employee.Salary > 10000)
            {
                return true;
            }
            return false;
        }
        //static bool PromoteByExperiece(Employee employee)
        //{
        //    if (employee.Experience > 3)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        //static bool PromoteByBoth(Employee employee)
        //{
        //    if (employee.Experience > 2 && employee.Salary >1000)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }

}
