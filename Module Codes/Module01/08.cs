/*
Arrays:
	-Collection of values of the same data type
	-Reference type variable --> address value of first variable(element) will be stored in arr 
	-Declaring an array
		datatype[] ArrayName;
	-Initialising an array
		int[] arr;
		arr = new int[10];
			or
		int arr = new int[10];
	- Assigning the values to array
		int[] score = {1,2,3};
		int[] arr = new int[]{10,20,30,40,50};
		int[] arr = new int[5]{10,20,30,40,50};
	- Index is also known as subscript and used to manipulate array elements.
	- Assigning the values after declaration: --> using index(subscript)
		arr[0] = 10;

	-copying array inside another array:
		int[] source = new int[10]{1,2,3,4}; -->
		int[] target = source;
		-address of starting element of source is copied to target,It means both, the target and source array refers to the same memory location
*/

using System;
class arrays{
	public static void Main(String[] args)
	{
		int[] arr = new int[10];
		int sum =0;
		for(int m=0;m<10;m++)
		{
			Console.Write($"ENTER THE {m+1}th ELEMENT : ");
			arr[m] = Convert.ToInt32(Console.ReadLine());
			sum = sum + arr[m];
		}

		Console.WriteLine("The Sum = {0}",sum);
		Console.WriteLine("PROGRAM TO CHECK THE GIVEN STRING IS PALINDROME OR NOT");
		char[] array;
		Console.WriteLine("Enter  string");
		array = Console.ReadLine().ToCharArray();//converted string to character array
		int i=0,flag =0;
		int j = array.Length-1;
		while(i<=j)
		{
			if(array[i] == array[j])
			{
				i++;
				j--;
			}
			else{
				flag = 1;
				break;
			}
		}
		if(flag==0)
		{
			Console.WriteLine("Palindrome");
		}
		else
		{
			Console.WriteLine("Not a Palindrome");
		}
		
				
	}

}