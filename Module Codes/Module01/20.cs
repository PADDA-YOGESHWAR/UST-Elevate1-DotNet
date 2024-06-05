using System;
class animal{
	public animal()
	{
		Console.WriteLine("Amimal Constructor");
	}
	public animal(int w)
	{
		Console.WriteLine("param animal Consturctor :{0}",w);
	}
	~animal()
	{
		Console.WriteLine("Animal Destructor");
	}
}

class cat:animal
{

	public cat()
	{
		Console.WriteLine("Cat Constructor");
	}
	public cat(int n):base(n)
	{
		Console.WriteLine("param cat Consturctor :{0}",n);
	}
	~cat()
	{
		Console.WriteLine("Cat destructor");
	}
}

class prgm{
	public static void Main(string[] args)
	{
		cat obj = new cat();	
		Console.WriteLine("-----------------------");
		cat obj2 = new cat(20);
	}
}