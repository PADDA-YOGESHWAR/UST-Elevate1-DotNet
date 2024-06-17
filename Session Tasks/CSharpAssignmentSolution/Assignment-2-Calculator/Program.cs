namespace Assignment_2_Calculator
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            string RunAgainOption;
            do
            {
                Console.WriteLine("Enter the operation that you want to perform(1-4)");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Divide");
                int Operation = Convert.ToInt32(Console.ReadLine());
                switch (Operation)
                {
                    case 1:
                        AddTwoNumbers();
                        break;
                    case 2:
                        SubtractTwoNumbers();
                        break;
                    case 3:
                        MultiplyTwoNumbers();
                        break;
                    case 4:
                        DivideTwoNumbers();
                        break;
                    default:
                        Console.WriteLine("Invalid Operation value");
                        break;
                }
                Console.WriteLine("Do you want to run the application again? press(y/n): ");
                RunAgainOption = Console.ReadLine();
            } while (RunAgainOption == "Y" || RunAgainOption == "y");
        }
        static void AddTwoNumbers()
        {
            Console.Write("Enter first number : ");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sum of {FirstNumber} and {SecondNumber} is {FirstNumber + SecondNumber}");
        }
        static void SubtractTwoNumbers()
        {
            Console.Write("Enter first number : ");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Subtraction of {FirstNumber} and {SecondNumber} is {FirstNumber - SecondNumber}");
        }
        static void MultiplyTwoNumbers()
        {
            Console.Write("Enter first number : ");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Multiplication of {FirstNumber} and {SecondNumber} is {FirstNumber * SecondNumber}");
        }
        static void DivideTwoNumbers()
        {
            Console.Write("Enter first number : ");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            if (SecondNumber != 0)
            {
                Console.WriteLine($"Division of {FirstNumber} and {SecondNumber} is {FirstNumber / SecondNumber}");
            }
            else
            {
                Console.WriteLine($"Divide by zero error!! Second number cannot be zero");
            }
        }
    }
}
/*
 * create class
 * naming convensions
 * code reuse using functions
 */