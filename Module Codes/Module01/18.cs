/*
	Garbage collector:
		ET framework provides  two methods Finalize() and Dispose() for releasing unmanaged resources like files, database connections, COM etc..
	

	Life Cycle of object:
		Main Method
		Constructor Called
		Block Started
		Constructor Called
		Block Ended
		Main Ended
		Destructor Called
		Destructor Called

*/


using System;
class prgm{
	prgm()
	{
		Console.WriteLine("Constructor Called");
	}
	~prgm()
	{
		Console.WriteLine("Destructor Called");

	}

	public static void Main(string[] args)
	{

		Console.WriteLine("Main Method");
		prgm obj1 = new prgm();
		{
			Console.WriteLine("Block Started");
			prgm obj2 = new prgm();
			Console.WriteLine("Block Ended");

		}
		Console.WriteLine("Main Ended");
	}//destructor called will be executed here, In .Net the destructor is called at the end of the program

}