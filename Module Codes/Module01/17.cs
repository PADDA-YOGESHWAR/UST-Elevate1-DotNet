/*
Constructor:
	Instance constructor -> for initialising instance variables
	static constructor -> for initialising static variables
	parameterised constructor

Destructor:
	It is a part of CLR(common Language Runtime). CLR has a program called as Grabage collector. this garbage collector takes the decision of when to call the destructor
	Automatically run by the .Net framework
*/

using System;
class con{
	int num;//instance variable
	static int cnt;//static variable
	con()//default
	{
		num = 100;
	}
	static con()//static constructor
	{
		cnt = 200;
	}
	con(int n)//parameterised constructor- (poly-morph-ism) -(constructor overloading)
	{
		num = n;
	}
	~con()
	{
		Console.WriteLine("Destructor is called");
	}

	static void Main(string[] args)
	{
		Console.WriteLine("static count : {0}",con.cnt);//calling static constructor before creating the object
		con obj = new con();
		Console.WriteLine("Instance number : {0}",obj.num);
		con obj2 = new con(30);
		Console.WriteLine("Parameterised constructor number : {0}",obj2.num);
	}
}