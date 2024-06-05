/*
Machanism to pass parameters:
	-Value
		<return type> methodName(<data type> variableName)
		{
			\\\\--
		}
		- here the original value of the varible doesn't change out side the function
		- here the original value of the varible doesn't change in the main
	-Reference
		<return type> methodName(ref <data type> variableName)
		{
			\\\\--
		}

		-The reference of variable will be passed into the function
		-It doesn't create a new storage location for function variable
	-output
		<return type> methodName(out <data type> variableName)
		{
			\\\\--
		}
		- here we can pass an empty variable as a parameter for a function and can get the result from that function without any return type
		- This is mainly used when we want a function to return multiple results/values.
		- out parameter must be assigned with some value in the function or else it will give an error
USE OF PARAMS:
	-by using params keyword before the parameter type in the function we can handle any number of parameters in the function
	<return type> methodName(<data type> variableName , params <data type>[] arrayVariableName)
	{
		\\\\--
	}
	- params must be always at the last of the all the parameters
	-one method can have only one params.
*/

using System;
class parameters{
	
	public int increment(int num) //-> value
	{
		num++;
		return num;
	}
	
	public int refrenceIncrement(ref int num) //-> reference
	{
		num++;
		return num;
	}

	public void doSumOrProduct(int n1,int n2,out int result,out int product) //-> output parameters
	{
			result = n1+n2;
			product = n1*n2;
	}
	

	public void display(String str ,params int[] arr)
	{	
		Console.Write(str+" ");
		foreach(int i in arr)
		{
			Console.Write($"{i} ");
		}
		Console.WriteLine();	
	}
	public static void Main(String[] args)
	{
		int n = 45;
		parameters obj = new parameters();
		obj.increment(n); //call by value
		int val = obj.increment(n);
		Console.WriteLine("PASSED BY VALUE : ");
		Console.WriteLine($"{n}");
		Console.WriteLine($"{val}");

		int n2 = 45;
		parameters obj2 = new parameters();
		obj2.refrenceIncrement(ref n2); //call by reference
		int val2 = obj2.refrenceIncrement(ref n2);
		Console.WriteLine("PASSED BY REFERENCE : ");
		Console.WriteLine($"{n2}");
		Console.WriteLine($"{val2}");
		
		Console.WriteLine("PASSED BY OUTPUT : ");
		int r,p;
		obj.doSumOrProduct(10,40,out r,out p);
		Console.WriteLine(r);
		Console.WriteLine(p);

		Console.WriteLine("USE OF PARAM IN FUNCTION PARAMETERS: ");
		int[] intArray = {10,20,30};
		obj.display("param",intArray);
		int[] intArray2 = {10,20,30,40}; // we can pass variable length of array
		obj.display("param",intArray2);
		obj.display("param",1,2,3,4,5,6);//we can pass any number of parameters to the function and print 
		
		
	}

}