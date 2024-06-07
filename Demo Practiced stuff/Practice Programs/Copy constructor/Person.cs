using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_constructor
{
    internal class Person
    {
        private int personAge;
        private string personName;
        public int Age
        { 
            get
            {
                return personAge;
            }
            set
            {
                personAge = value;
            }
        }
        public string Name
        {
            get
            {
                return personName;
            }
            set
            {
                personName = value;
            }
        }
        public Person(string name,int age)//instance constructor
        {
            personAge = age;
            personName = name;
        }
        public Person(Person personObj)
        {
            personName = personObj.personName;
            personAge = personObj.personAge;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"person name is {personName} and age is {personAge}");
        }
    }
}
