using System;

namespace IntroductionToCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Doe";

            Console.WriteLine("Welcome {0} {1}", firstName, lastName);//index way of printing values
            Console.WriteLine("Welcome " + firstName + " " + lastName);//normal way of using print values
            Console.WriteLine($"Welcome {firstName},{lastName}");// efficient way of using print values

            Console.WriteLine("\"James\"");//escape characteres

            int maxValue =   int.MaxValue;//int.maxValue returns the maximum value that an integer can store
            int minValue = int.MinValue;
            Console.WriteLine("maximum value an integer can store is "+maxValue);//this gives the maximum value that 
            Console.WriteLine("minimum value an integer can store is "+ minValue);//this gives the maximum value that an integer can store


            int size = sizeof(int);//sizeof() returns the size of the datatype that is passed as a parameter
            Console.WriteLine("size of int is "+size);//returns size of integer
           // int count = null; -> this gives an error because for int we cannot assaign null values

            string name = null;//string can be assigned with null values. it is showing warning error because  <Nullable>enable</Nullable> is enabled
            int? count = null;
            string? fullname = null;//it is showning warning saying that it is not used in the progam
            Console.WriteLine(count);//simply prints empty space
            Console.WriteLine("value "+count);
            Console.WriteLine(fullname);//simply prints empty space
            Console.WriteLine("fullname"+fullname);

        }
    }
}
