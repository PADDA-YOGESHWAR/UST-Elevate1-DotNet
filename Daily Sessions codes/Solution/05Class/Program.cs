namespace _05Class
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Virat","Kohli");
            customer.Print("Hey it's a demo message");
            customer.printFullName();
            Customer customer2 = new Customer();
            customer2.printFullName();
        }
    }
}
