/*
CONDITIONAL STATEMENTS:
-Switch case
*/

using System;

class conditional{
	public static void Main(String[] args){
		char ch;
		Console.Write("Enter a character (a - z): ");
		ch = Convert.ToChar(Console.ReadLine());
		switch(ch)
		{
		 	case 'a':
				//here we skipped to write the body to the case as the body is same. Hence we write the body only once, that is in last case.
			case 'e':
				
			case 'i':
				
			case 'o':
				
			case 'u':
				Console.WriteLine("Vowel");
				break;
			default:
				Console.WriteLine("Character is not a Vowel");
				break;
		}
		
		Console.WriteLine("PROGRAM TO FIND THE LARGEST OF 3 NUMBERS");
		int a,b,c;
		Console.Write("Enter first Number : ");
		a = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter second Number : ");
		b = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter third Number : ");
		c = Convert.ToInt32(Console.ReadLine());

		if(a>b && a>c)
		{
			Console.WriteLine($"{a} is the Largest");
		}
		else if(b>a && b>c)
		{
			Console.WriteLine($"{b} is the Largest");	
		}
		else if(c>a && c>b)
		{
			Console.WriteLine($"{c} is the Largest");	
		}
		else
		{
			Console.WriteLine("All three numbers are equal");
		}
	}
}