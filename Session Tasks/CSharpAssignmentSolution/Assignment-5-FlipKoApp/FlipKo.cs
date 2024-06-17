using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_FlipKoApp
{
    public class FlipKo
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine($"Product {product.GetName()} is Added");
        }

        public void DisplayAllProducts()
        {
            if ( products.Count > 0 )
            {
                Console.WriteLine("\nList of all the products available");
                Console.WriteLine();
                foreach (Product product in products)
                {
                    Product.DisplayProductDetails(product);
                }
            }
            else
            {
                Console.WriteLine("List is Empty");
            }
        }

        public void DisplayAllProductsPriceGreaterThan1000()
        {
            bool Availability = false;
            if (products.Count > 0)
            {
                Console.WriteLine();
                foreach (Product product in products)
                {
                    if (product.GetPrice() > 1000)
                    {
                        Availability = true;
                        Product.DisplayProductDetails(product);
                    }
                }
                if( !Availability )
                {
                    Console.WriteLine("There are no products available whose price is above 1000") ;
                }
            }
            else
            {
                Console.WriteLine("List is Empty");
            }
            
        }

        public void DeleteAllProductRecords()
        {
            if (products.Count > 0)
            {
                products.Clear();
                Console.WriteLine("All products deleted successfully");
            }
            else
            {
                Console.WriteLine("There are no records to delete..");
            }
        }
        public bool CheckProductAvailability(string productName)
        {
            foreach (Product product in products)
            {
                if(product.GetName() == productName) return true;
            }
            return false;
        }

    }
}
