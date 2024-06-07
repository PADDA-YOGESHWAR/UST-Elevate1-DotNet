using Lesson_6_StaticDemo;

namespace _06StaticDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float pi = Circle._pi;//static constructor is called first and only once in a program
            Console.WriteLine(pi);
            Circle firstCircle = new Circle(5); //instance constructor is called when every object is created
            firstCircle.CalculateArea();

            Circle secondCircle = new Circle(6);
            secondCircle.CalculateArea();

        }
    }
}
