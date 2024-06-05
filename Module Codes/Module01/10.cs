/*
Multi Dimensional Array:
	- Multi Dimensional Array stores data in more than one rows, where as single dimensional array stores data in a row.

	Declaration of 	MultiDemnsional Array:
		int[,] arr = new int[3,3]{{1,2,3},{4,5,6},{7,8,9}};
	Assigning the values:
		arr[0,0] = 1;
		arr[0,1] = 2;


	Memory allocation:
		arr stores 2000
		arr[0] address 2000 , stores 3000 --> arr[0,0] address 3000 -> stores value, arr[0,1] address 30001 -> stores value
		arr[1] address 2001 , stores 4000 --> arr[1,0] address 4000 -> stores value, arr[1,1] address 40001 -> stores value
		arr[2] address 2002 , stores 5000 --> arr[2,0] address 5000 -> stores value, arr[2,1] address 50001 -> stores value
	-If we want to create 4 rows and 2 columns mutidimentional array
		int[,] array = new int[4,2];//rows comes first	
		

		array[1,3] means it's 2nd row 4th element;

*/

using System;
class multiDim{
	public static void Main(String[] args)
	{
		int[,] arr  = new int[3,3];
		for(int i=0;i<3;i++)
		{
			for(int j=0;j<3;j++)
			{
				Console.Write("Enter Number : ");
				arr[i,j] = Convert.ToInt32(Console.ReadLine());
			}
		}
		for(int i=0;i<3;i++)
		{
			for(int j=0;j<3;j++)
			{
				Console.Write("{0} ",arr[i,j]);
			}
			Console.WriteLine();
		}
		int rowsum = 0;
		int total =0;
		for(int i=0;i<3;i++)
		{
			for(int j=0;j<3;j++)
			{
				rowsum = rowsum + arr[i,j];
			}
			Console.WriteLine("Row Sum is : {0}",rowsum);
			total = total + rowsum;
			rowsum =0;
		}
		Console.WriteLine("The total: {0}",total);


	}
}