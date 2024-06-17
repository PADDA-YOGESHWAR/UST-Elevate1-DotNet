namespace _20UtilityGeneric
{
    class Utility//<Tem> where Tem : struct
    {
        //public static bool AreEqual(double firstNumber, double secondNumber)
        //{
        //    return firstNumber == secondNumber;
        //}

        //public static bool AreEqual(object a, object b)
        //{
        //    return a == b;
        //}

        
        public static bool AreEqual<T>(T firstNumber,T secondNumber)
        {
            return firstNumber.Equals(secondNumber);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Utility.AreEqual(1.2,3.4));
            Console.WriteLine(Utility.AreEqual(3, 3));
            //Utility.AreEqual(1, "abc");
            Console.WriteLine(Utility.AreEqual("a","a"));
            Console.WriteLine(Utility.AreEqual<int>(1, 1));
            Console.WriteLine(Utility.AreEqual<string>("a","a"));
        }
    }
}

//boxing -> value(stack- memory can be easily released) to referece(heap -> memory is handled by garbage collector)