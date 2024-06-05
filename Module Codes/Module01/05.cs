/*
Loop constructs:
1. Fixed loops
2. variable loops

	for loop -> for(initialization;condition;increment/decrement){ logic / statements }
	for(int i=0;i<10;i++){
            Console.WriteLine(i);
        }
	
*/

using System;
class loops{
	public static void Main(){
        int num, evenCount=0, oddCount=0;
		for(int i = 1; i<=10;i++)
		{
			Console.Write($"Enter {i}th number :");
			num = Convert.ToInt32(Console.ReadLine());
			if(num%2==0)
            		{
                		evenCount++;
            		}
			else{
				oddCount++;
			}
		}
		Console.WriteLine($"Total even numbers are {evenCount} and odd numbers are {oddCount}");
		Console.WriteLine("PROGRAM TO PRINT THE DESIGN 1");
		int row;
		Console.Write("Enter the number of rows : ");
		row = Convert.ToInt32(Console.ReadLine());
		for(int i=1;i<=row;i++)
        	{
			for(int j=1;j<=i;j++)
            		{
				Console.Write("* ");
			}
			Console.WriteLine();
		}
		for(int i=1;i<=row;i++)
		{
			for(int j=1;j<=i;j++)
			{
				Console.Write($"{i} ");
			}
			Console.WriteLine();
		}
		for(int i=1;i<=row;i++)
		{
			for(int j=1;j<=i;j++)
			{
				Console.Write($"{j} ");
			}
			Console.WriteLine();
		}
		int cnt =0;
		for(int i=1;i<=row;i++)
		{
			for(int j=1;j<=i;j++)
			{	cnt++;
				Console.Write($"{cnt} ");
			}
			Console.WriteLine();
		}
		for(int i=row;i>=1;i--)
		{
			for(int j=i;j>=1;j--)
			{
				Console.Write("* ");
			}
			Console.WriteLine();
		}
		
    }
}