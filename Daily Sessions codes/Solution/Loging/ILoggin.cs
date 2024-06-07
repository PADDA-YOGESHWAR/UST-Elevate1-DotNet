using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loging
{
    internal interface ILoggin
    {
        void Log(string message);
    }
    public class FileLogging : ILoggin
    {
        public void Log(string message)
        { 
            Console.WriteLine($"File Logging" + message);
        }
    }
    public class SQLLogging : ILoggin
    {
        public void Log(string message)
        {
            Console.WriteLine($"SQL Logging" + message);
        }
    }
    public class ConsoleLogging : ILoggin
    {
        public void Log(string message)
        {
            Console.WriteLine($"Console Logging" + message);
        }
    }

}
