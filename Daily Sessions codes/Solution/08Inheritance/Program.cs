namespace _08Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee fullTimeEmployee = new FullTimeEmployee();
            fullTimeEmployee.FirstName = "John";
            fullTimeEmployee.LastName = "Thomas";
            fullTimeEmployee.PrintFullName();

            // ((Employee)fullTimeEmployee).PrintFullName();

            //Employee[] employees = new Employee[4];
            //employees[0] = new Employee();
            //employees[1] = new FullTimeEmployee();
            //employees[2] = new PartTimeEmployee();
            //employees[3]=new TemporaryTimeEmployee();

            //foreach(Employee employee in employees) 
            //{
            //    employee.PrintFullName();
            //}
        }
    }
}
