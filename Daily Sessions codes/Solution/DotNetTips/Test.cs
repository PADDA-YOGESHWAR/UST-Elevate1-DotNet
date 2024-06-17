using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTips
{
    internal class Test
    {
        void Print()
        {
            Person person = new Person();
            Console.WriteLine(person.IsPromotable(19));
        }
    }
    sealed class Person
    {

    }
    static class PersonExtensions
    {
        public static bool IsPromotable(this Person person, int age) => age > 18;
    }
}
