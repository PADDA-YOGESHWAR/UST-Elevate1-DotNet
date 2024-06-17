using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;  
        }
        int Subtract(int firstNumber,int secondNumber)
        {
            return (firstNumber - secondNumber);
        }
        protected int Multiply(int firstNumber, int secondNumber)
        {
            return (firstNumber * secondNumber);
        }
    }

    public class Hello : Calculator
    {
        public void Print()
        {
            Console.WriteLine(base.Multiply(1, 2));
            Console.WriteLine(this.Multiply(1, 3));
            Console.WriteLine(this.Add(1, 2));
        }
    }

}
