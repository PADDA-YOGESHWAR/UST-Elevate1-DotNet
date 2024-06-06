namespace _02DataConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicit conversion - done by the framework(automatic)
            int firstNumber = 10;
            float secondNumber = firstNumber;
            //Explicit conversion - should be done by the developer
            int thirdNumber = (int)secondNumber;
            int fouthNumber = Convert.ToInt32(secondNumber);//conversion using Convert class
            string fifthNumber = "50";
            //int sixthNumber = (int)fifthNumber; gives an error because it checks the data type 
            int sixthNumber = Convert.ToInt32(fifthNumber);

            double a = 5.46;
            int b = (int)a;
            int c = Convert.ToInt32(a);
            Console.WriteLine(b);//gives the roundof to the ground value(i.e) onky integer part will be taken
            Console.WriteLine(c);// value depends on 0.5 above or below while rounding
            string str = "12345";
            int num = int.Parse(str);//converting string to integer using parse method
            Console.WriteLine(num);
            string str2 = "123";
            //int num2 = int.Parse(str2); -> this will give an error saying that the string is not in correct format to convert it to an int
            bool canBeParsed = int.TryParse(str2, out int result);//using TryParse method for evaluating the input from the user
            if (canBeParsed )
            {
                Console.WriteLine($"Value = {result}");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
