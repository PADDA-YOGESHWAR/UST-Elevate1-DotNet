using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07PropsDemo
{
    internal class Student
    {
        private int _id;
        private string Name;
        private int _passMark = 35;
        private static int count;

        public string name
        {
            get 
            {
                return Name;
            } 
            set
            {
                Name = value;
            } 
        }
        static Student()
        {
            count = 0;
        }

        public int PassMark//read only access
        {
            get
            {
                return _passMark;
            }
        }

        public int Id//input validation
        {
            get
            {
                return _id;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid ID");

                _id = value;
            }
        }

    }

    public static class LoggingDemo//static class must contain only static functions
    {
        public static void Log()
        {

        }

    }
}
