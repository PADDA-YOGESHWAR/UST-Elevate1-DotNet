using System.Diagnostics;

namespace Assignment_5_FlipKoApp
{
    internal class Program : InputValidation
    {
        static void Main(string[] args)
        {
            //List<Product> products = new List<Product>();
            //Product product = new Product("Face Wash","Only for Women","Ponds",235.56);
            //products.Add(product);

            FlipKo flipKo = new FlipKo();

            string RunAgainOption;
            do
            {
                Options.OriginalManuOptions();
                int Option = GetPositiveInegerValuesBetween1To4();
                switch (Option)
                {
                    case 1:
                        String ProductName = GetProductName(flipKo);
                        Console.Write("Enter Product Discription : ");
                        string ProductDescription = Console.ReadLine();
                        string ManufacturedCompany = GetCompanyName();
                        Console.Write("Enter the cost of the Product : ");
                        double ProductPrice = GetDoubleValue();
                        Product product = new Product(ProductName, ProductDescription, ManufacturedCompany, ProductPrice, flipKo);
                        break;
                    case 2:
                        flipKo.DisplayAllProducts();
                        break;
                    case 3:
                        
                        flipKo.DisplayAllProductsPriceGreaterThan1000();
                        break;
                    case 4:
                        flipKo.DeleteAllProductRecords();
                        break;
                   
                }
                Console.WriteLine("Do you want to run the application again? press(y/n): ");
                RunAgainOption = GetRerunOperation();
            } while (RunAgainOption == "Y" || RunAgainOption == "y");


        }
    }
}
