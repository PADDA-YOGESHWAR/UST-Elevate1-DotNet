namespace _07PropsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Student = new Student();

            var x = "hello";//var keyword takes the data type at the compile time

            //Student.Id = -1; -> this throws an invalid ID error as mentioned in student class validation while setting the value
            Student.Id = 1;//we can access only by the name of "Id" but not "id" because "id" is private
                                                                                                        
            Console.WriteLine(Student.Id);                                                              
            Console.WriteLine($"Pass mark is {Student.PassMark}");

            Student.name = "Jhon";
            Console.WriteLine("student name is "+Student.name);

            Display(5, number2: 30);
            //Console.WriteLine($"Id={Student.GetId()},Name ={Student.Name}, PassMark ={Student.GetPassMark()}");
        }

        //public static void display(var msg){} -> gives error because var cannot be used as a argument 
        public static void Display(int y, string name = "Thomas", int number1 = 10, int number2 = 20)
        {
            var x = "hello";//var can be used inside the function
            Console.WriteLine($"Hello {name}");

        }
    }
}
