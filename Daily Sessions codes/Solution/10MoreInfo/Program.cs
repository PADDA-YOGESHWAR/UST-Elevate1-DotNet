namespace _10MoreInfo
{
    internal class Program
    {
        //objects are stored in stack. where as the values of the objects are stored in the heap
        //for struct the values are also stored in the stack
        //struct is value type. class is reference type
        static void Main(string[] args)
        {
            customer c = new customer() {
                Id = 1,
                Name = "Test",
            };
            Console.WriteLine(c);
            c.Name = "val";

            Console.WriteLine(c);
            person p = new person { Id = 1, Name = "Thomas" };
            person p1 = p;
            p1.Name = "Test";
            p1.print();
            p.print();
            Display();
            

        }
        static void Display()
        {
            int x = 10;//memory will be released after the function for value types
            person p3 = new person();
        }
    }
}
