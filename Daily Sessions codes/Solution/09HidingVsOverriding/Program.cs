namespace _09HidingVsOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // FullTimeEmployee emp = new FullTimeEmployee();
            //emp.PrintFullName();
            Employee employee = new FullTimeEmployee();
            employee.PrintFullName();
        }
    }
}
