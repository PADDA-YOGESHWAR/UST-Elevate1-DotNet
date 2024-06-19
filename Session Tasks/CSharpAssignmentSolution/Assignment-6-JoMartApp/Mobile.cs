using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_JoMartApp
{
    sealed class Mobile
    {
        public string Name;
        private string Description;
        public string ManufacturedBy;
        public double Price;
        public int Id;
        public Mobile(string name, string description, string manufacturedBy, double price,JoMart jomart)
        {
            Name = name;
            Description = description;
            ManufacturedBy = manufacturedBy;
            Price = price;
           jomart.Add(this);
        }
        public static void DisplaymobileDetails(Mobile mobile)
        {
            Console.WriteLine($"{mobile.Id}\t{mobile.Name}\t{mobile.ManufacturedBy}\t{mobile.Price}");
        }

    }
}
