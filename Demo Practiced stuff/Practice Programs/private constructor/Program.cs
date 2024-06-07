using System.ComponentModel.Design;

namespace private_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            constructor.IncrementValue();
            Console.WriteLine(constructor.value);
        }
    }
    class constructor
    {
        private constructor() 
        {
            value = 100;
        }
        public static int value;
        public static int IncrementValue()
        {
            return value++;
        }
    }

}
