using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10MoreInfo
{
    public struct person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public person(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public void print()
        {
            Console.WriteLine($"{Id},{Name}");
        }
    }
    class customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id is {Id} ,name is {Name}";
        }
    }
}
