namespace _09HidingVsOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new FullTimeEmployee();
            employee.PrintFullName();
        }
    }
}
