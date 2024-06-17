namespace _19EqualsDemo
{
    class person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
    }
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (!(obj is Customer customer)) return false;
            return (this.FirstName == ((Customer)obj).FirstName && this.LastName == ((Customer)obj).LastName);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }

    internal class Program
    {
       
        static void Main(string[] args)
        {
            int firstNumber = 10;
            int secondNumber = 10;
            Console.WriteLine(firstNumber == secondNumber);
            Customer customer1 = new Customer() { FirstName = "tina", LastName ="John"};
            person person1 = new person() { FirstName = "tina", LastName = "John" };
            Customer customer2 = new Customer() { FirstName = "akhil", LastName = "Jon" };
            Console.WriteLine(customer1 == customer2);
            Customer customer3 = customer1;
            Console.WriteLine(customer1 == customer3);
            Console.WriteLine(customer1.Equals(customer2));
            Console.WriteLine(customer1.Equals(customer3));
            Console.WriteLine(customer2.GetHashCode());
            Console.WriteLine(customer1.GetHashCode());
            Console.WriteLine(customer1.GetHashCode()+"    "+(customer1.LastName.GetHashCode() ^ customer1.FirstName.GetHashCode()));
            Console.WriteLine($"{customer1.FirstName.GetHashCode()} ---- {customer1.LastName.GetHashCode()}");
            Console.WriteLine($"{customer2.FirstName.GetHashCode()} ---- {customer2.LastName.GetHashCode()}");
            Console.WriteLine($"{customer3.FirstName.GetHashCode()} ---- {customer3.LastName.GetHashCode()}");
            Console.WriteLine($"{person1.FirstName.GetHashCode()} ---- {person1.LastName.GetHashCode()}");
        }
    }
}
//value types value is equal or not for ==
//reference types is checks for the references and memory referencing for ==