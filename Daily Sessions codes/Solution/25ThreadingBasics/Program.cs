using System;
using System.ComponentModel;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _25ThreadingBasics
{
    class Number
    {
        int _result;
        public Number(int result)
        {
            _result = result;
        }
        public  void Print()
        {
            for (int i = 0; i < _result; i++)
            {
                Console.WriteLine(i);
            }

        }
        //public static void Print(object target)
        //{
        //    if(int.TryParse(target.ToString(), out int number))
        //    {
        //        for (int i = 0; i < number; i++)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }

        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Thread.CurrentThread.Name = "MyMainThread";



            //Thread threadOne = new Thread(new ThreadStart(Number.Print));
            //threadOne.Start();

            //Thread threadOne = new Thread(Number.Print);
            //threadOne.Start();

            //Thread threadOne = new Thread( ()=> Number.Print());
            //threadOne.Start();
            //Thread threadOne = new Thread(new ParameterizedThreadStart(Number.Print));
            //threadOne.Start(10);
            Number number = new Number(30);
            Thread threadOne = new Thread(number.Print);
            threadOne.Start();
            threadOne.Join();
            //Thread.Sleep(100);
            Console.WriteLine(Thread.CurrentThread.Name);

        }
    }
}
