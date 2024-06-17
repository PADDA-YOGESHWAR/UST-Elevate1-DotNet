/*
Dot Net Notes:

c# vs .NET framework:
-> c# is a programming language and .NET is a framework
	for building application.
->we can use various languages in .NET framework to build
	applications like FSharp, VB.net etc..
->.NET framework, it consists of major 2 components one is
	CLR(common Language runtime) or Class library for
	building applications.

-----------------------------

CLR:
-we compile c# code and get translated to Intermediate Language(IL)
- Transilation of IL -> Native code(Machine level code) is done by CLR(Common Language Runtime)

-----------------------------
.Net Architecture

-Class
-functions
-Attributes
-Collections of all the classes is a Namespace

----------------------------
console.write(); -> continue in same line
console.writeLine();
----------------------------

*/

using System;

class program
{
	public static void Main()
	{
		Console.Write("Enter Your Name: ");
		string name = Console.ReadLine();
		Console.WriteLine(name);
		string num = Console.ReadLine();
	}
}