namespace _16Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                try
                {
                    throw new UserAlreadyLoggedInException("First number cannot be zero");
                    Console.Write("Enter First Number : ");
                    //int firstNumber = Convert.ToInt32(Console.ReadLine());

                    if (int.TryParse(Console.ReadLine(), out int firstNumber))
                    {
                        Console.Write("Enter Second Number : ");
                        int secondNumber = Convert.ToInt32(Console.ReadLine());
                        int result = firstNumber / secondNumber;
                        Console.WriteLine($"Result is {result}");
                    }
                    else
                    {
                        Console.WriteLine("Conversion is not possible");
                    }
                }
                catch (FormatException ex)
                {
                    logging.logerrors(ex.StackTrace);
                    Console.WriteLine(ex.Message);
                }
                catch (OverflowException ex)
                {
                    logging.logerrors(ex.StackTrace);
                    Console.WriteLine(ex.Message);
                }
                catch (DivideByZeroException ex)
                {
                    logging.logerrors(ex.StackTrace);
                    Console.WriteLine(ex.Message,ex);
                }
                catch (Exception ex)
                {
                    //logging.logerrors(ex.StackTrace);
                    Console.WriteLine(ex.Message,ex);
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
    }
    class logging
    {
        public static void logerrors(string message)
        {
            //write logic to push it to a file server or sql server
            Console.WriteLine($"This is for the developer end {message}");
        }
    }
}
//ex.InnerException.Message