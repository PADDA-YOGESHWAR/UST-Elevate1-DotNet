/*
OOP(OBJECT ORIENENTED PROGRAMMING):
	Class - A blueprint or prototype from which objects are created which contains attributes and methods.
	Objects - Instance of a class
	- unique name of a class/object is the identity of it.	
	- state of the object will always change by time. for example the weight/age of a person changes.


Features of Object oriented Approach
	-Realistic Modeling
		- It immitates the way the things happen in real life.
	-Inheritance(Reusability)
		-  Enables creating a new class by adding the features to existing class
			Ex: by inheriting the properties and upgrading 2 wheel car to 4 wheel car
	-Polymorphism(Existence as different forms)
		- one task can be performed by different ways
			Ex: can speaks meaw, dog barks bow,etc..
	-Abstraction(Hiding the details and showing Functionality):
		Ex: phone call, we don't know the internal processing.
	-Encapsulation(Binding/wrapping code and data together into a single unit)
		Ex: Capsule, it is a wrapped with different medicines.


WORKING WITH METHODS:
	Method -> set of one or more program statements
		Syntax for defining a method
			<Access Specifier> <Return type> <method Name>(parameter List)
			{
				Method body
			}
		Syntax for
	
	
*/

using System;
class Employee{
	string name,email;  //member variabes
	int phn;
	
	public void assign() //member functions/methods
	{
		Console.Write("Enter your name: ");	
		name = Console.ReadLine();
		Console.Write("Enter your email: ");	
		email= Console.ReadLine();
		Console.Write("Enter your name: ");	
		phn= Convert.ToInt32(Console.ReadLine());
		
	}
	public void print()
	{
		Console.WriteLine("Name of the employee is {0}",name);
		Console.WriteLine("Email ID of the employee is {0}",email);
		Console.WriteLine("Phone of the employee is {0}",phn);
	}

	public static void Main(String[] args)
	{	
		Employee Emp1  = new Employee();
		Emp1.assign();
		Emp1.print();
		Employee Emp2  = new Employee();
		Emp2.assign();
		Emp2.print();
	
	}
	
}