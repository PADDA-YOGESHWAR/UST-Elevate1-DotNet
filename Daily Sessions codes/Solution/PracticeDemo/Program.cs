namespace PracticeDemo
{
    public delegate void printDelegate(int number);
    public delegate bool PromoteDelegate(Employee employee);
  
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
        public static Action<Employee[], Predicate<Employee>> PromoteEmployeeDelegate = (Employee[] employees, Predicate<Employee> AnonymousDelegate) =>
        {
            foreach (Employee employee in employees)
            {
                if (AnonymousDelegate(employee))
                {
                    Console.WriteLine($"{employee.Name}");
                }
            }
        };
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Normal Delegate
            printDelegate printDelegate = new printDelegate(printValue);
            printDelegate(0);

            
            //anonymous function
            printDelegate AnonymousFunction = (int value) => Console.WriteLine(value);
            AnonymousFunction(1);


            //passing function as a parameter
            DelegateFunctionDemo((int value) => Console.WriteLine(value), 10);
            
            //Func demo
            Func<int> funcDelegate = () => 1;
            Func<int,int> funcDelegate2 = (int num) =>num;
            //Action 
            //Predicate
            
            
            //modifying the functions with delegate to inbuilt delegates with anonymous functions
            Employee[] employees = new Employee[3];
            employees[0] = new Employee() { Id = 1, Name = "Yogesh", Salary = 12000, Experience = 2 };
            employees[1] = new Employee() { Id = 2, Name = "Lucky", Salary = 8000, Experience = 1 };
            employees[2] = new Employee() { Id = 3, Name = "Praveen", Salary = 20000, Experience = 5 };
            PromoteDelegate IsPromoteDelegate = new PromoteDelegate(PromoteBySalary);
            Console.WriteLine("Promote by Salary");
            Employee.PromoteEmployee(employees, IsPromoteDelegate);
            Console.WriteLine("Promote by salary");
            Predicate<Employee> AnonymousDelegate = (Employee employee) => employee.Salary > 10000;
            Employee.PromoteEmployeeDelegate(employees, AnonymousDelegate);
        }
        static void printValue(int number)
        {
            Console.WriteLine(number);
        }
        static void DelegateFunctionDemo(printDelegate printDelegate,int value)
        {
            printDelegate(value);
        }
        static bool PromoteBySalary(Employee employee)
        {
            if (employee.Salary > 10000)
            {
                return true;
            }
            return false;
        }
       
    }
}

//delegate + anonymous function
