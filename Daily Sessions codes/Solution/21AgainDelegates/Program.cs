namespace _21AgainDelegates
{
    public delegate void PrintDelegate(int number);
    public delegate void NameDelegate(string name);
   // public delegate int AddDelegate(int firstNumber, int secondNumber);
    internal class Program
    {
        static void Display(PrintDelegate printDelegate, int number)
        {
            printDelegate(number);
        }
        static void Main(string[] args)
        {
            //ananumous function
            PrintDelegate printDelegate = delegate (int number)
            {
                Console.WriteLine(number); 
            };
            printDelegate(10);

            Display(
                delegate (int value)
                {
                    Console.WriteLine(value);
                }, 10
             );
          
            PrintName
            (
                delegate (string name)
                {
                    Console.WriteLine(name);
                },
                "Yogesh"
            );
            
            Func<int, int, int> addDelegate = Add;
            int result = addDelegate(1, 2);
            Func<int> testDelegate = test;
            Func<int, int, int> anonymousAddDelegate = delegate (int firstNumber, int secondNumber)
            {
                return firstNumber + secondNumber;
            };

            Func<int,int,int> addLamda = ( int firstNumber, int  secondNumber) => firstNumber + secondNumber; //2 input 
            Func<int, int, int> addLamdawithoutDatatype = (firstNumber, secondNumber) =>
            {
                firstNumber += 5;
                //some processing logic
                return firstNumber + secondNumber;
             };

            Action<int, int> actionDelegate = AddVoid;
            actionDelegate(2, 4);

            

            Action action = Display;
            action();
            
            Predicate<int> predicate = Isvalid;
            Predicate<int> predicateDelegate = (int firstNumber) => firstNumber!=0;

            print(
          delegate (int value)
          {
              Console.WriteLine(value);
          }, 10);

        }
        static void print(PrintDelegate printDelegate, int value)
        {
            value += 10;
            printDelegate(value);
        }
        static void PrintName(NameDelegate nameDelegate,string name)
        {
            nameDelegate(name);
        }
        //static void Print(int number)
        //{
        //    Console.WriteLine($"Number is {number}");
        //}

        static int Add(int firstNumber, int secondNumber) => (firstNumber + secondNumber);
        static int test() => 1;

        static void AddVoid(int firstNumber, int secondNumber) => Console.WriteLine(firstNumber + secondNumber);

        static void Display() => Console.WriteLine("hello");

        static bool Isvalid(int age) => age > 0;
        
            
        
    }

}
