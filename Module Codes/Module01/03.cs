/*
Operators in C#

1.Unary Operators:
	INCREMENT OPERATOR (++):
	a++(postfix)  --> b = a++; --> int b = a; a = a+1; --> ans: b =10, a =11
	++a(prefix)   --> b = ++a; --> int a = a+1; b = a; --> ans: b =11, a =11

	DECREMENT OPERATOR (--):
	a--(postfix)  --> b = a--; --> int b = a ; a = a-1; --> ans: b = 10, a = 9
	--a(prefix)   --> b = --a; --> int a = a-1; b = a; --> ans: b = 9, a = 9
	
	
2.Mathematical Operators:
	add(+), subtract(-), multiply(*), divide(/), remainder(%)

3.Assignment Operators:
	=; -> a = b;
	+=; -> a += b; -> a = a+b;
	-=; -> a -= b; -> a = a-b;
	*=; -> a *= b; -> a = a*b;
	/=; -> a /= b; -> a = a/b;
	%=; -> a %= b; -> a = a%b;

4.Comparision Operators:
	==;
	!=;
	>;
	<;
	>=;
	<=;

5.Conditional Operators:
	&& (AND) --> a&&b -> true only if both are true
	|| (OR)  --> a||b -> true if atleast any one of them are true

6.BitWise Operators: eg : a = 1; b =0; //these work at bit level of variables
	&(AND) --> a & b -> 1 if both are 1 => 0
	|(OR) --> a | b -> 1 if either is 1 => 1
	^(XOR) --> a ^ b -> 0 if both are 1 or 0 =>1

*/

using System;
class Operators{

	public static void Main(){
		//Unary Operators
		Console.WriteLine("UNARY OPERATORS ");
		int a,b;
		a = 10;
		b = ++a;
		Console.WriteLine($"Prefix ++, a = {a}, b = {b}");
		a = 10;
		b = a++;
		Console.WriteLine($"Postfix ++, a = {a}, b = {b}");
		a = 10;
		b = --a;
		Console.WriteLine($"Prefix --, a = {a}, b = {b}");
		a = 10;
		b = a--;
		Console.WriteLine($"Postfix --, a = {a}, b = {b}");
		Console.WriteLine();

		//Mathematical Operators
		Console.WriteLine("MATHEMATICAL OPERATORS ");
		a= 10;
		b = 3;
		Console.WriteLine($"a + b = {a+b}");
		Console.WriteLine($"a - b = {a-b}");
		Console.WriteLine($"a * b = {a*b}");
		Console.WriteLine($"a / b = {a/b}");
		Console.WriteLine($"a % b = {a%b}");
		float f  = 10.0f;
		Console.WriteLine($"f / b = {f/b}");
		Console.WriteLine();
		
		//Assignment Operators
		Console.WriteLine("ASSIGNMENT OPERATORS ");
		a = 10;
		a += 5;
		Console.WriteLine($"a += 5 :{a}");a = 10;
		a -= 5;
		Console.WriteLine($"a -= 5 :{a}");a = 10;
		a *= 5;
		Console.WriteLine($"a *= 5 :{a}");a = 10;
		a /= 5;
		Console.WriteLine($"a /= 5 :{a}");
		Console.WriteLine();

		//Comparison Operators
		Console.WriteLine("COMPARISON OPERATORS ");
		a = 60;
		Console.WriteLine($"a : {a}");
		Console.WriteLine($"a == 50 :{a == 50}");
		Console.WriteLine($"a != 50 :{a != 50}");
		Console.WriteLine($"a >= 50 :{a >= 50}");
		Console.WriteLine($"a <= 50 :{a <= 50}");
		Console.WriteLine($"a > 50 :{a > 50}");
		Console.WriteLine($"a < 50 :{a < 50}");
		Console.WriteLine();

		//Conditional Operators
		Console.WriteLine("CONDITIONAL OPERATORS ");
		bool c = false;
		bool d = true;
		
		Console.WriteLine($"c d : { c } {d }");
		Console.WriteLine($"c && d : { c && d }");
		Console.WriteLine($"c || d : { c || d }");
		Console.WriteLine();
	



	}
}