namespace _10MoreInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            customer c = new customer() {
                Id = 1,
                Name = "Test",
            };
            Console.WriteLine(c);
            person p = new person { Id = 1, Name = "Thomas" };
            person p1 = p;
            p1.Name = "Test";
            p1.print();
            Display();
            

        }
        static void Display()
        {
            int x = 10;
            person p3 = new person();
        }
    }
}
