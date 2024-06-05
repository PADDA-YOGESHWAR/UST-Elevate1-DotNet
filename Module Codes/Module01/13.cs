/*
	Abstraction:  Show only the necessary details to the intended user.
	
	Encapsulation: wrapping and  Hiding the data like capsule, class is the best example of encapsulation.
		
	Access Specifiers:
		Public:
			-public members/variables/methods are visible to all the classes 
		Private:
			-the default access specifiers for data members is private.
			-private members/variables/methods are accessable only in the same class itself.
		Protected:
			- Protected members/variables/methods can be accessable only within the class or in the child class.
.
		Internal:
			- internal access modifier can be accessed within the program and within the assembly level/namespace but not from another assembly/namespace.
			- The default access specifer for the class is internal
		Protected Internal;
			-It can be acessed in the same assembly and in the same class ,also the classes inherited from the same class.
	-classes are called as refernce types
	-Default value is zero for non assigned values in c sharp
	Static Variables:
		- static variable will be created with only one address memory and all the object holds the address of that varible, where for non - static variables(Instance variable) the memory will be created in every block of object.
		- Every object will be using same static variable which is indepent of the object.
		- Have only one copy of the variable for all the objects of a class.
		- static variable can be initialized outside the member function or class definition.
		- Memory for the static varible will be assigned in compile time
		- Memory for the instance variable will be assigned at runtime(while creating object).
	
	Static Functions:
		- static method can work only on static data, incase if we want to access instance variable in static method we must create object and then call the variable with object reference
		- Static functions helps us access the static variables without creating any object
*/

using System;
public class prgm{

	public static int number =0 ;
	public static void add()
	{
		number++;
	}

}

class test{
	int num;
	static int count;
	public void increment()
	{
		count++;	
		num++;
	}
	public void display()
	{
		Console.WriteLine($"num : {num} , count: {count}");

	}
	public static void Main(String[] args)
	{
		test obj1 = new test();
		obj1.increment();
		obj1.display();
		test obj2 = new test();
		obj2.increment();
		obj2.display();
		//the value of count is continously changing because a class have only one copy of the variable for all the objects of a class.
		prgm.add();//static methods can be accessed without any object
		Console.WriteLine($"Number value : {prgm.number}");
		prgm.add();
		Console.Write($"Number value : {prgm.number}");
	}
}