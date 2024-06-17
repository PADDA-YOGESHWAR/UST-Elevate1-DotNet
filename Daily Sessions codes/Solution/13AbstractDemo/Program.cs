using System.Security.Cryptography;

namespace _13AbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Paper();
        }
    }

    interface IPrinter
    {
        //feilds are not allowed
        string Name { get; set; }
        public abstract string color {  get; set; }
    }


    abstract class Printer 
    {
        public abstract void Print();
        public void Paper()
        {
            Console.WriteLine("Paper");
        }
    }

    class Customer : Printer
    {
        public override void Print()
        {
            Console.WriteLine("Abstract method");
        }
    }


}
