/*
Data types in c#
*/
using System;
class program{
	public static void Main()
	{
		int num1=100,num2=200;
		int sum = num1 + num2;
		Console.WriteLine("The sum of {0} and {1} is {2}",num1,num2,sum);
		int num3,num4;
		Console.Write("Enter first number : ");
		num3 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter second number : ");
		num4 = Convert.ToInt32(Console.ReadLine());
		int sum2 = num3+num4;
		Console.WriteLine("The sum of {0} and {1} is {2}",num3,num4,sum2);
		
		
	}
}

//Console.ReadLine reads only strings