namespace InputValidationLibrary
{
    public class GetValidInputs
    {
        private static int intValue;
        private static string stringValue;
        private static double doubleValue;
        public static string GetRerunOperation()
        {
            bool valid = false;

            while (!valid)
            {
                string RerunOperator = Console.ReadLine().Trim().ToLower();
                if (RerunOperator == "y" || RerunOperator == "n")
                {
                    valid = true;
                    stringValue = RerunOperator;
                }
                else
                {
                    Console.WriteLine("Invalid Opetator!!! Please enter only 'Y' or 'N'");
                    Console.WriteLine("Please Try Again");
                    Console.Write("Do you want to run the application again? press(y/n): ");
                }
            }
            return stringValue;
        }

        public static int GetPositiveInegerValuesBetween1Ton(int target)
        {
            bool Valid = false;
            
            while (!Valid)
            {
                Console.Write($"Enter the value(1-{target}): ");
                if (int.TryParse(Console.ReadLine(), out int IntValue))
                {
                    if (IntValue <= target && IntValue > 0)
                    {
                        Valid = true;
                        intValue = IntValue;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid Input!!! try entering values between 1 - {target} ");
                        
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input!!! Please enter only integer values ");
                }
            }
            return intValue;
        }

        public static string GetDesciptionInput()
        {
            bool valid = false;
            while (!valid)
            {
                Console.Write("Enter the Mobile Description : ");
                string name = Console.ReadLine().Trim();
                if (name.Length > 0)
                {
                   valid = true;
                   stringValue = name;
                }
                else
                {
                    Console.WriteLine("You haven't entered any description!! please try to enter the description");
                }
            }
            return stringValue;
        }
        public static string GetCompanyInput()
        {
            bool valid = false;
            while (!valid)
            {
                Console.Write("Enter the Mobile CompanyName/ManufacturedBy : ");
                string name = Console.ReadLine().Trim().ToUpper();
                if (name.Length > 0)
                {
                    valid = true;
                    stringValue = name;
                }
                else
                {
                    Console.WriteLine("You haven't entered any CompanyName/ManufacturedBy!! please try to enter the CompanyName/ManufacturedBy");
                }
            }
            return stringValue;
        }
        public static double GetDoubleValue()
        {
            bool Valid = false;

            while (!Valid)
            {
                Console.Write("Enter the mobile price : ");
                if (double.TryParse(Console.ReadLine(), out double DoubleValue))
                {
                    if (DoubleValue > 0)
                    {
                        Valid = true;
                        doubleValue = DoubleValue;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!!! Only +ve values are allowed for price");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input!!! Please enter only integer/double values");
                    Console.WriteLine("Please Try Again");
                }
            }

            return doubleValue;
        }
    }
}
