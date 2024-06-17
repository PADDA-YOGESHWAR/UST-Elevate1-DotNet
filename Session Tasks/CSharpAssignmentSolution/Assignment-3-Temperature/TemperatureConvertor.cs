using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Temperature
{
    public class TemperatureConvertor
    {
        public static int IntValue { get; private set; }

        public static double DoubleValue {  get; private set; }
        static double ConvertToCelsius(double Fahrenheit)
        {
            return ((Fahrenheit - 32) * 5) / 9;
        }
        static double ConvertToFahrenheit(double Celsius)
        {
            return ((Celsius * 9) / 5) + 32;
        }
        public static void InputValidationAndFlowOfProgram()
        {
            Console.Write("Enter the temperature value : ");
            double TemperatureValue = GetDoubleValue();
                Console.WriteLine("Choose the correct option to convert the temperature value to (1-2) : ");
                Console.WriteLine("1.Celsius");
                Console.WriteLine("2.Fahrenheit");
            int Operation = GetInegerValue();
                
                    switch (Operation)
                    {
                        case 1:
                            
                            Console.WriteLine($"The celcius value of temperature {TemperatureValue}°F is {ConvertToCelsius(TemperatureValue)}°C");
                            break;
                        case 2:
                            
                            Console.WriteLine($"The Fahrenheit value of temperature {TemperatureValue}°C is {ConvertToFahrenheit(TemperatureValue)}°F");

                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
           
        }
        public static int GetInegerValue()
        {
            bool Valid = false;
           
            while(!Valid)
            {
                if (int.TryParse(Console.ReadLine(),out int IntValue))
                {
                    Valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input!!! Please enter only integer values");
                    Console.WriteLine("Please Try Again");
                }
            }
            return IntValue;
        }
        public static double GetDoubleValue()
        {
            bool Valid = false;

            while (!Valid)
            {
                if (double.TryParse(Console.ReadLine(), out double DoubleValue))
                {
                    Valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input!!! Please enter only integer values");
                    Console.WriteLine("Please Try Again");
                }
            }
            return DoubleValue;
        }
    }
}
