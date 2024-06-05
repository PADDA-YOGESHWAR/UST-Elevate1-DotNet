/*

	polymorphism:
		-Ability to allow a function to exist in the different forms
		-Types of polymorphism:
			-static -> the decision is taken at compile time
				-Function Overloading -> same name of function but signature(parameters) differs
				-Operator Overloading
					-provides additional capabilities to operators
					- helps to add the user defined variables like objects/classes
					student s1;
					student s2;
					student s3 = s1+s2;
			-dynamic -> the decision is taken at runtime
				Implementation of dynamic polymorphism is done by
				-Abstract classes
				-Virtual Functions
*/

using System;


class hour{
	int hr,mnt;
	public hour(int h,int m)
	{
		hr= h;
		mnt= m;
	}
	public static hour operator +(hour a,hour b)//operator overloading
	{
		hour c = new hour(0,0);
		c.hr = a.hr + b.hr;
		c.mnt = a.mnt + b.mnt;
		return c;
	}

	public void display()
	{
		Console.WriteLine($"{hr} {mnt}");
	}
	public static void Main(string[] args)
	{
		hour h1 = new hour(3,40);
		hour h2 = new hour(2,30);
		hour h3 = h1 + h2;//the values of two objects are added
		h1.display();
		Console.WriteLine("-----------");
		h2.display();
		Console.WriteLine("-----------");
		h3.display();
	}

}