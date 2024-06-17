
using CalculatorLibrary;
namespace MainProject
{

    
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {

        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Hello hello = new Hello();
            hello.Print();
            demo demo = new demo();
            demo.Display();
            NewCalculator.Add(1, 2);
            NewCalculator.Add(new int[] { 1, 2, 3, 4 });
        }
    }

    class NewCalculator
    {
        [Obsolete("Use Add(int[]) instead")]
        public static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public static int Add(int[] numbers)
        {
            int sum = 0;
            foreach(int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

    }
    public class demo :Calculator
    {
        public void Display()
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(5, 5));
            Console.WriteLine(this.Add(3,5));
            Console.WriteLine(this.Multiply(3,5));
        }
    }
}


//types -> public , internal
//type members -> all


//Access Modifiers
//private -
//public
//protected
//internal 
//protected Internal
//private protected