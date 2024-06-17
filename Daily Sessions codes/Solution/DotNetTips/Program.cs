namespace DotNetTips
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Company
    {
        List<Employee> Employees;
        public Company() 
        { 
            
            Employees = new List<Employee>()
            {
                new Employee()
                {
                    Name = "Test1",
                    Id = 1,
                },
                new Employee()
                {
                    Name = "Test2",
                    Id = 2,
                },
                new Employee()
                {
                    Name = "Test3",
                    Id = 3,
                }
            };
        }
        public string this[int id]
        {
            get
            {
                Employee employee = Employees.Find(x => x.Id == id);
                    return employee.Name;
            }
            set
            {
                Employee employee = Employees.Find(x => x.Id == id);
                employee.Name= value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            Console.WriteLine(company[2]);
            company[2] = "modified";
            Console.WriteLine(company[2]);
            int x = 10;
            Console.WriteLine(x.checkGreater(100));
        }
    }
    static class check
    {
        public static bool checkGreater(this int x, int y) => x>y;
    }
}
//string Vs StringBuilder