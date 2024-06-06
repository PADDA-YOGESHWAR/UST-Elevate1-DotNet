namespace _04MethodReferenceValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 10;
            Console.WriteLine("x = "+firstNumber);
            valuePrint(firstNumber);
            Console.WriteLine("Passed as a value x = "+firstNumber);
            referencePrint(ref firstNumber);//use of ref keyword is to pass the value as reference to the function
            Console.WriteLine("Passed as a reference x = " + firstNumber);
            Calculate(5, 5, out int sum, out int product);//use of out keyword -> out keyword is used to get the multiple values as output from the function
            Console.WriteLine($"Sum = {sum} \nproduct = {product}");

        }
        public static void valuePrint(int n)
        {
            n = 30;
        }
        public static void referencePrint(ref int n)
        {
            n = 30;
        }
        public static void Calculate(int n1,int n2,out int sum, out int product)
        {
            sum = n1 + n2;
            product = n1*n2;
        }
    }
}
