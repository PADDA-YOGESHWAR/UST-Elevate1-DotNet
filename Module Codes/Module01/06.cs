/*
while loop:
	syntax:
		while(condition)
		{
			statements;
			Increment/Decrement;
		}
*/ 

using System;
class loops{
	public static void Main(String[] args){
		Console.WriteLine("PROGRAM TO CHECK FIRST N Prime Numbers");
		int num,count = 0,init = 1,flag = 0;
		Console.Write("Enter the number: ");
		num = Convert.ToInt32(Console.ReadLine());
		while(count<num)
		{
			flag = 0;
			init++;
			for(int i=2;i<init;i++)
			{
				if(init%i==0)
				{
					flag = 1;
					break;
				}
			}
			if(flag ==0)
			{
				Console.Write($"{init} ");
				count++;
			}
		}
	}
}