/*
	Memory Allocation:
		-Memory allocation depends on the type of variables:
		 ->Value type
			ex1:
				int num1;
				num1 = 50;
				int num2;
				num2 = num1;
				- now if we do changes to num1, it will not effect the num2 value
				- value types are stored on stack memory
		
		 ->Reference type
			ex:
				car ford = new car();//new keyword allocates dynamic memory for the object
				ford.model = 10;
				car bmw;//creating another object of the car class
				bmw = ford;//initializing the bmw object with the ford object
				- here the memory address of ford object will be copied to bmw object
				- Reference types are stored on heap memory
				
	Structure datatype:
			- this is used to group different types of datatypes to one
			- Do not support inheritance
			- Cannot have default constructor
*/
using System;

struct student
{
	public int rollno;
	public string name;

}
class structure{

	public static void Main(string[] args)
	{
		student s1 = new student();
		s1.name = "lucky";
		s1.rollno = 01;
		Console.WriteLine($"Name    : {s1.name}");
		Console.WriteLine($"Roll no : {s1.rollno}");
	}
}