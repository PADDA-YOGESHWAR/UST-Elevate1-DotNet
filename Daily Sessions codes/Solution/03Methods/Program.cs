using System.Net.Http.Headers;

namespace _03Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
           printHelloWorld();//function without parameters
           printHelloWorld("Hey man");//function with parameters
           printSum(new int[] { 1,2,3,4,5});//using params keyword and printing the sum of elements without storing in array
            printSum(1, 2, 3, 4);//printing the sum of values
            printSum([1,2,3,4,5]);//passing values in an array format
            int[] arr = new int[2];
            arr[0] = 1;
            arr[1] = 2; 
            printSum(arr);  //passing the array
            ParamSumTest(1, 2, 3, 4);//passing parameters with params as argument


        }
        public static void printHelloWorld()
        {
            Console.WriteLine("Hello World");
        }
        public static void printHelloWorld(string msg)
        {
            Console.WriteLine(msg);
        }
        public static void printSum(params int[] values)
        {
            int sum = 0;
            foreach (int value in values) { 
                sum += value;
            }
            Console.WriteLine("sum of the values is = "+sum);
        }
        public static void ParamSumTest(int x , params int[] values)//params must be always present at last argument
        {
            int sum = 0;
            foreach (int value in values)
            {
                sum += value;
            }
            Console.WriteLine($"The first argument value {x}");
            Console.WriteLine("sum of the values is = " + sum);
        }
    }
}
