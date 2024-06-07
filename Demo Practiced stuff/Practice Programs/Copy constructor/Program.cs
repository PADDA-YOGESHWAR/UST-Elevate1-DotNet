namespace Copy_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Virat", 37);
            p1.PrintDetails();
            Person p2 = new Person(p1);
            p2.PrintDetails();
            p1.Age = 40;
            p1.Name = "Dhoni";
            Console.WriteLine("After we change the values of object 1");
            p1.PrintDetails();
            p2.PrintDetails();
        }
    }
}
