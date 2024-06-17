using System.Reflection;

namespace _14Delegating
{
    internal class Program
    {
        public delegate void GreetingDelegate(string message);
        public delegate void MethodDelegate();
        public delegate int GetNumberDelegate();
        static void Main(string[] args)
        {
            Program program = new Program();
            GreetingDelegate greetingDelegate = new GreetingDelegate(program.Greet);
           
            greetingDelegate("Hellloooo man");
            MethodDelegate methodDelegateOne = new MethodDelegate(MethodOne);
            MethodDelegate methodDelegateTwo = new MethodDelegate(MethodTwo);
            MethodDelegate methodDelegateThree = new MethodDelegate(MethodThree);
            //methodDelegateOne(); //explicitly calling
            //methodDelegateTwo();
            //methodDelegateThree();

            MethodDelegate methodDelegateFour = methodDelegateOne + methodDelegateTwo + methodDelegateThree;
            methodDelegateFour();
            //MethodDelegate methodDelegate = new MethodDelegate(MethodOne);
            //methodDelegate += MethodTwo;
            //methodDelegate += MethodThree;
            //
            //methodDelegate();
            //methodDelegate -= MethodOne;
            //
            //methodDelegate();

            GetNumberDelegate NumberDelegate = new GetNumberDelegate(GetFirstNumber);
            NumberDelegate += GetSecondNumber;
            int result = NumberDelegate();
            Console.WriteLine(result);

        }
        void Greet(string message)
        {
            Console.WriteLine(message);
        }
        static void MethodOne()
        {
            Console.WriteLine("Methos One");
        }
        static void MethodTwo()
        {
            Console.WriteLine("Methos Two");
        }
        static void MethodThree()
        {
            Console.WriteLine("Methos Three");
        }

        static int GetFirstNumber()
        {
            return 1;
        }
        static int GetSecondNumber()
        {
            return 2;
        }
    }
}
