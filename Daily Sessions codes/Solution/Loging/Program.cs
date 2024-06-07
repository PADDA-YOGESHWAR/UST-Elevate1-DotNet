namespace Loging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILoggin loggin = new SQLLogging();
            Customer customer = new Customer(loggin);
            customer.Id = 1;
            customer.Name = "Test";
            customer.login();
        }
    }
}