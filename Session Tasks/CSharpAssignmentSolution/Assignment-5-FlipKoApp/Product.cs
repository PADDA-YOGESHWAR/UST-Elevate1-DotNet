using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_FlipKoApp
{
    public class Product
    {
        private string Name {  get; set; }
        private string Description { get; set; }
        private string ManufacturedBy { get; set; }
        private double Price { get; set; }

        private int Id { get; set; }

        private static int nextId = 1000;
        public Product(string ProductName,string ProductDiscription,string Company,double ProductPrice,FlipKo flipko)
        {
            Name = ProductName;
            Description = ProductDiscription;
            ManufacturedBy = Company;
            Price = ProductPrice;
            this.Id = nextId;
            nextId++;
            flipko.AddProduct(this);
        }
        static public void DisplayProductDetails(Product product)
        {
            Console.WriteLine($"{product.Id}\t{product.Name}\t{product.ManufacturedBy}\t{product.Price}");
        }

        public double GetPrice()
        {
            return Price;
        }
        public string GetName()
        {
            return Name;
        }

    }
   
}

