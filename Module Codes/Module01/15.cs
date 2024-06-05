/*
	Enumerator:
		- a value type data
		- contains own values and cannot inherit or pass inheritance
		- symbolic names to integral constants
*/

using System;
class enumerDatatype{
	enum days
	{
		mon,
		tue,
		wed,
		thur = 55,
		fri,
		sat,
		sun
	}
	public static void Main(string[] args){

		Console.WriteLine($"{(int)days.mon}");
		Console.WriteLine($"{(int)days.tue}");
		Console.WriteLine($"{(int)days.wed}");
		Console.WriteLine($"{(int)days.thur}");
		Console.WriteLine($"{(int)days.fri}");
		Console.WriteLine($"{(int)days.sat}");
		Console.WriteLine($"{(int)days.sun}");
	}
}