/*
	Boxing:
		value types are converted to reference types.
		Ex:
			Array(value) to ArrayList(reference)
	Unboxing:
		Reference types are converted to value types.

	Collections:
		- Declared in the System.Collections namespace and sub-namespaces.
		- Elements are of object type
		- objects are of reference type
		-->classes of the System.Collections namespace
			-> ArrayList
			-> Queue
			-> Stack
			-> Hashtable
	ArrayList class:
		- Methods:
			-Add
			-Remove
			-Clear
			-Insert
			-TrimToSize
			-Sort
			-Reverse


*/
using System;
using System.Collections;
class ArrayListDemo{
	public static void Main(string[] args)
	{
		ArrayList arr = new ArrayList();
		arr.Add(01);
		arr.Add("Lucky");
		arr.Add(3.14);
		arr.Add("%");
		for(int i=0; i<arr.Count;i++)
		{
			Console.Write($"{arr[i]} ");
		}
		Console.WriteLine("----------------");
		arr.Remove(3.14);
		for(int i=0; i<arr.Count;i++)
		{
			Console.Write($"{arr[i]} ");
		}
		arr.TrimToSize();//De-allocates the extra space

	}
}