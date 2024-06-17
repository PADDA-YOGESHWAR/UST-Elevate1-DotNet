namespace Assignment_3_Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        
            string RunAgainOption;
            do
            {
                TemperatureConvertor.InputValidationAndFlowOfProgram();
                

                Console.WriteLine("Do you want to run the application again? press(y/n): ");
                RunAgainOption = Console.ReadLine();
            } while (RunAgainOption == "Y" || RunAgainOption == "y");
        }
    }
}
