namespace _11Interfaces
{
    interface ICustomerone
    {
        void print();
    }
    interface ICustomertwo 
    {
        void print();
    }
    class Customer : ICustomertwo, ICustomerone
    {
        void ICustomertwo.print()
        {
            Console.WriteLine("2");
        }

        public void print()
        {
            Console.WriteLine("1");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            
            ((ICustomerone)customer).print();
            ((ICustomertwo)customer).print();
            ICustomerone customerone = new Customer();
            customerone.print();
            ICustomertwo customertwo = new Customer();
            customertwo.print();
            
        }
    }
}
