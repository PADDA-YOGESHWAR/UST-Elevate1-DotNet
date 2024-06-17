using System.Globalization;
using System.Reflection;
using CustomerLibrary;

namespace _18Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assembly assembly = Assembly.Load("CustomerLibrary");
            //Type T = assembly.GetType("CustomerLibrary.Customer");
            Type T = Type.GetType("CustomerLibrary.Customer, CustomerLibrary");
            //Type T = Type.GetType("Customer");

           
            //Console.WriteLine(T.FullName);
            //Console.WriteLine(T.Name);
            //Console.WriteLine(T.Namespace);
            //Console.WriteLine();
            //Console.WriteLine("Properties");
            //Console.WriteLine();
           
            //PropertyInfo[] properties = T.GetProperties();
            //foreach (var property in properties)
            //{
            //    Console.WriteLine(property.Name +" "+ property.PropertyType.Name);
            //}
            //Console.WriteLine();
            //Console.WriteLine("members");
            //Console.WriteLine();
            MemberInfo[] members = T.GetMembers();
            foreach (var member in members)
            {
                Console.WriteLine(member.Name+" "+member.MemberType);
            }
            //Console.WriteLine();
            //Console.WriteLine("methods");
            //Console.WriteLine();
            //MethodInfo[] methodInfos = T.GetMethods();
            //foreach (MethodInfo method in methodInfos)
            //{
            //    Console.WriteLine($"{method.Name} {method.ReturnType.Name}");
            //}

            //ConstructorInfo[] constructors = T.GetConstructors();
            //Console.WriteLine();
            //Console.WriteLine("constructors");
            //Console.WriteLine();
            //foreach (ConstructorInfo constructor in constructors)
            //{
            //    Console.Write(constructor.MemberType+ " ");
            //    ParameterInfo[] parameters = constructor.GetParameters();
            //    foreach (ParameterInfo parameter in parameters)
            //    {
            //        Console.Write(parameter.Name + " ");
            //    }
            //    Console.WriteLine();
            //}
        }
       
    }
}
