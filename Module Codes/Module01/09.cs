/*
Manipulating array:
	foreach(type identifier in expression)
	{
		// statements
	}
	-foreach loop is used when we don't know the size of array
*/
using System;
class forEachLoop{
	public static void Main(String[] args)
	{
		char[] ch;
		Console.Write("Enter a String: ");
		ch = Console.ReadLine().ToCharArray();
		foreach(char c in ch)
		{
			Console.Write("{0}\t",c);	
		}
		Console.WriteLine();
		//IMPORTANT SORTING	
		Console.WriteLine("PROGRAM TO PRINT/SORT ARRAY IN DECENDING ORDER");
		int[] arr = new int[7];
		for(int i=0;i<7;i++)
		{
			Console.Write("Enter "+i+1+"th element: ");
			arr[i] = Convert.ToInt32(Console.ReadLine());
		}
		Console.Write("The array is : ");	
		foreach(int i in arr)
		{
			Console.Write(i+" ");
		}
		int temp;
		for(int i=0;i<6;i++)
		{
			for(int j=i+1;j<7;j++)
			{
				if(arr[i]<arr[j])
				{
					temp = arr[i];
					arr[i] = arr[j];
					arr[j] = temp;
				}
			}		
		}
		Console.WriteLine();	
		Console.Write("The Sorted array is : ");	
		foreach(int i in arr)
		{
			Console.Write(i+" ");
		}
		
	}	
	
}