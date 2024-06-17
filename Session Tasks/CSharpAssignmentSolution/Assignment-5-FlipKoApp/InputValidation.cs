using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment_5_FlipKoApp
{
    public  class InputValidation
    {
        private static int IntValue { get;  set; }
        private static double DoubleValue { get;  set; }  
        private static string RerunOperator { get; set; }

        private static string NameCheck {  get; set; }

        private static string CompanyName {  get; set; }

        //returns only Double Value
        public static double GetDoubleValue()
        {
            bool Valid = false;

            while (!Valid)
            {
                if (double.TryParse(Console.ReadLine(), out double DoubleValue) )
                {
                    if (DoubleValue > 0)
                    {
                        Valid = true;
                        InputValidation.DoubleValue = DoubleValue;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!!! Only +ve values are allowed");
                        Console.WriteLine("Please Try Again");
                        Console.Write("Enter the cost of the Product : ");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input!!! Please enter only integer values");
                    Console.WriteLine("Please Try Again");
                }
            }

            return DoubleValue;
        }

        //returns only integer Value
        public static int GetInegerValue()
        {
            bool Valid = false;

            while (!Valid)
            {
                if (int.TryParse(Console.ReadLine(), out int IntValue))
                {
                    Valid = true;
                    InputValidation.IntValue = IntValue;
                }
                else
                {
                    Console.WriteLine("Invalid Input!!! Please enter only integer values");
                    Console.WriteLine("Please Try Again");
                }
            }
            return IntValue;
        }


        //returns only Y or N

        public static string GetRerunOperation()
        {
            bool Valid = false;

            while (!Valid)
            {
                InputValidation.RerunOperator = Console.ReadLine().Trim();
                if(RerunOperator == "y" ||  RerunOperator == "Y" || RerunOperator == "n" || RerunOperator == "N")
                {
                    Valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid Opetator!!! Please enter only 'Y' or 'N'");
                    Console.WriteLine("Please Try Again");
                }
            }
            return RerunOperator;
        }


        //
        public static string GetProductName(FlipKo flipko)
        {
            bool Valid = false;

            while (!Valid)
            {
                Console.Write("Enter Product Name : ");
                string productName = CapitalizeFirstLetter(Console.ReadLine().Trim());
                
                if (!flipko.CheckProductAvailability(productName))
                {
                    Valid = true;
                    NameCheck = productName;
                }
                else
                {
                    Console.WriteLine("Product already exists!!! Please add another product");
                    Console.WriteLine("Please Try Again");
                }
            }
            return NameCheck;
        }

        public static string GetCompanyName()
        {
            bool Valid = false;

            while (!Valid)
            {
                Console.Write("Enter Company Name : ");
                string companyName = Console.ReadLine();
                if (int.TryParse(companyName, out int IntValue))
                {

                    Console.WriteLine("Invalid Input!!! Company Name can't be only integers");
                    Console.WriteLine("Please Try Again");
                }
                else
                {
                    Valid = true;
                    CompanyName = companyName;
                }
            }
            return CompanyName;
        }

        public static int GetPositiveInegerValuesBetween1To4()
        {
            bool Valid = false;

            while (!Valid)
            {
                if (int.TryParse(Console.ReadLine(), out int IntValue))
                {
                    if(IntValue < 4 && IntValue > 0)
                    {
                        Valid = true;
                        InputValidation.IntValue = IntValue;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!!! try entering values between 1 - 4");
                       
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input!!! Please enter only integer values");
                    Console.WriteLine("Please Try Again");
                }
            }
            return IntValue;
        }

        static string CapitalizeFirstLetter(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            return char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }
    }
}
