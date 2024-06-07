namespace privateConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // privateConstructor obj = new privateConstructor(); -> this gives an error as the constructor is inaccessable
           //private constructor restricts to create an object for the class
           //it is reasonable to use only static members and methods in that class as we cannot create any object
            privateConstructor.firstNumber = 100;
            privateConstructor.IncrementValue();
            privateConstructor.printValue();
        }
    }
    class privateConstructor
    { 
        private privateConstructor() { }
        static public int firstNumber;
        static public int IncrementValue()
        {
            return firstNumber++;
        }
        static public void printValue()
        {
            Console.WriteLine($"value is {firstNumber}");
        }
    }

}
