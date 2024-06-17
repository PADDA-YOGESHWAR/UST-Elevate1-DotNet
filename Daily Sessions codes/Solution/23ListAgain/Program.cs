namespace _23ListAgain
{
    class Customer : IComparable<Customer>
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        int IComparable<Customer>.CompareTo(Customer? other)
        {
            Console.WriteLine($"{this.Name} - {other.Name}");
            if (this.Salary > other.Salary)
            {
                return 1;
            }
            else if (this.Salary < other.Salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 8, 3, 6, 9, 5 };
            numbers.Sort();
            numbers.Reverse();
            numbers.ForEach(x => Console.Write(x));
            Console.WriteLine();
            List<string> numbers2 = new List<string>() { "Z", "A", "D" };
            numbers2.Sort();
            numbers2.Reverse();
            numbers2.ForEach(x => Console.Write(x));
            Console.WriteLine();
            List<Customer> customers = new List<Customer>()
            {
                new Customer {Name = "Jhon" , Salary = 50000},
                new Customer {Name = "Adithya" , Salary = 10000},
                new Customer {Name = "Praveen" , Salary = 90000},
                new Customer {Name = "Akhil" , Salary = 20000}
            };
            customers.Sort();
            customers.ForEach(x => Console.WriteLine(x.Name));
        }
    }
}
