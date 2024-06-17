namespace Assignment_1_Odd_Even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the target value");
            int targetNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select the appropriate option(1-2): ");
            Console.WriteLine("1. To print all the even numbers that are less than target value ");
            Console.WriteLine("2. To print all the odd numbers that are less than target value ");
            int SelectedOption = Convert.ToInt32(Console.ReadLine());
            switch (SelectedOption)
            {
                case 1:
                   
                    PrintAllUptoTarget(2,targetNumber);
                    break;
                case 2:
                    
                    PrintAllUptoTarget(1,targetNumber);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }

        static void PrintAllUptoTarget(int start,int number)
        {
            while(start< number)
            {
                Console.Write($"{start} ");
                start += 2;
            }
         
        }
    }
}
