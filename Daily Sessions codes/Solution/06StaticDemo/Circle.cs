using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_StaticDemo
{
    public class Circle
    {
        int _radius;
        public static float _pi;
        static Circle() //static constructor doesn't require any object. it just requires the class name to access
        {
            _pi = 3.14F; //static constructor can only access static variables
            Console.WriteLine("I am static constructor");
        }

        public Circle(int radius)//parameterised  instance constructor
        {
            _radius = radius;
            Console.WriteLine("I am instance constructor");
        }

        public void CalculateArea()
        {
            float area = _pi * this._radius * this._radius; 
            Console.WriteLine($"Area is {area}");
        }
    }
}
