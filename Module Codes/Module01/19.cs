/*
Types of Relationships:
	
	-Inheritance
		-classes inherit state and behaviour from other classes
		-Inherited classes are superclasses(parent)(base)
		-Classses that inherit are subclasses(child)(derived)
		
		Superclass:
			- Represents Generalization
			ex:
				AutomobileVechicle class
		Subclass:
			- Represents Specilization
			- can redefine the function of the superclass(overriding)
			ex:
				car class
	-Composition
		- objects includes another object as its part
		- 'has-a' relationship between objects
		EX:
		 	car class, engine class
		 
	-Utilization
		-A class makes 'use' of another class
		Ex:
			driver class, car/bus class, uses driving method
	-Instantiation
		-It is a relation between a class and it's object
		Ex:
			funiture class can create the object of furniture class as a chair class
			<chair object>---> furiture class --> int lenght,breadth; string color;
*/

using System;

class employee{
	public int empid;
	public string name;

}
class partTime:employee{
	public int numberOfHours;
}

class fulltime:employee{
	public int numberOfShits;

}
class inherit{

	public static void Main(string[] args)
	{	
		fulltime obj = new fulltime();
		obj.numberOfShits = 5;
		obj.empid = 01;
		obj.name = "Lucky";
		partTime obj2 = new partTime();
		obj2.numberOfHours = 10;
		obj2.empid = 02;
		obj2.name = "yogesh";
		Console.WriteLine($"{obj.numberOfShits} {obj.empid} {obj.name}");
		Console.WriteLine($"{obj2.numberOfHours} {obj2.empid} {obj2.name}");
		
	}

}