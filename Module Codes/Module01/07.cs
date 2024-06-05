/*
	do while loop:
		Statements within the loop are executed at least once
		Syntax:
		do
		{
			Statements;
		}while(expression);
*/
using System;
class Dowhile{

	public static void Main(String[] args){
		Console.WriteLine("PROGRAM TO PERFORM THE OPERATION BETWEEN TWO NUMBERS");
		int n1,n2,r,choice;
		char yesNo;
		do{
			Console.Write("ENTER YOUR FIRST NUMBER: ");
			n1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("ENTER YOUR SECOND NUMBER: ");
			n2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("1: +");
			Console.WriteLine("2: -");
			Console.WriteLine("3: *");
			Console.WriteLine("4: /");
			Console.WriteLine("5: %");
			Console.WriteLine("6: Exit");
			Console.Write("Enter your choice----(1-6) = ");
			choice = Convert.ToInt32(Console.ReadLine());
			switch(choice)
			{
				case 1:
					r = n1+n2;
					Console.WriteLine("Addition is {0}",r);
					break;
				case 2:
					r = n1-n2;
					Console.WriteLine("Subtraction is {0}",r);
					break;
				case 3:
					r = n1*n2;
					Console.WriteLine("Multiplition is {0}",r);
					break;
				case 4:
					r = n1/n2;
					Console.WriteLine("Division is {0}",r);
					break;
				case 5:
					r = n1%n2;
					Console.WriteLine("Reminder is {0}",r);
					break;
				case 6:
					break;
				default:
					Console.WriteLine("Invalid Operation");
					break;
			}
			Console.Write("Do you want to continue?(Y/N) :");
			yesNo = Convert.ToChar(Console.ReadLine());
		}while(yesNo == 'y' || yesNo == 'Y');
		
	}
}