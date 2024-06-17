using System.Collections;
using System.Globalization;

namespace _22Collections
{
    class customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[]{1, 2, 3, 4,};
            //int[] numbers = new int[4];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;

            //ArrayList numbers2 = new ArrayList();
            //numbers2.Add(1);
            //numbers2.Add("Ok");
            //numbers2.Add(3);
            //Console.WriteLine(numbers2[0]);
            //int number = (int)numbers2[0];
            //string ok = (string)numbers2[1];


            //List<int> numberlist = new List<int>();
            //numberlist.Add(1);
            //numberlist.Add(2);
            //numberlist.Add(5);
            customer customer = new customer { Name  = "test" };
            List<int> list = new List<int>() { 1, 2, 3, 4 };
            list.Add(5);
            list.Insert(0, 5);
            
            foreach (int item in list)
            {
                //Console.WriteLine(item);
            }
            //var evenList = list.FindAll(number => number%2==0);
            //foreach (int item in evenList)
            //{
            //    Console.WriteLine($"{item}");
            //}
            IEnumerable<int> evenlist = list.FindAll(number => number % 2 == 0);

            Console.WriteLine(list.Find(x => x % 2 == 0));
            list.Contains(1);
            list.Exists(x => x % 2 == 5);
            list.RemoveAll(x  => x % 2 == 0);
            list.ForEach(x => Console.WriteLine(x));
            
        }
    }
}
