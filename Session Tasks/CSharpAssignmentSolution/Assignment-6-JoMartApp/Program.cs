using InputValidationLibrary;

namespace Assignment_6_JoMartApp
{
    internal class Program : GetValidInputs
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            JoMart joMart = new JoMart();
            string RunAgainOption;
            do
            {
                OriginalManuOptions();

                int Option = GetPositiveInegerValuesBetween1Ton(6);
                switch (Option)
                {
                    case 1:
                        AddMobile(joMart);
                        break;
                    case 2:
                        joMart.ViewAllMobiles();
                        break;
                    case 3:
                        joMart.MobilesPriceLessThanMaxPrice();
                        break;
                    case 4:
                        joMart.SearchByManufacturer();
                        break;

                    case 5:
                        joMart.MobilesPriceGreaterThanMinAndLessThanMaxPrice();
                        break;
                    case 6:
                        joMart.RemoveMobilesGreaterThanMinAndLessThanMaxPrice();
                        break;
                }
                Console.Write("Do you want to run the application again? press(y/n): ");
                RunAgainOption = GetRerunOperation();
            } while (RunAgainOption == "Y" || RunAgainOption == "y");
        }
        public static void OriginalManuOptions()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Choose one of the options among the given(1-4): ");
            Console.WriteLine("1. Add mobile \n2. View all mobiles available in the store.  \n3. Search mobiles whose price is less than the max price of mobiles. \n4. Search all mobiles by Manufacturer. \n5. View all mobiles whose price is greater than minimum mobile price and less than maximum mobile price. \n6. Remove mobiles whose price is greater than minimum mobile price and less than maximum mobile price.");
            Console.WriteLine();
        }

        public static void AddMobile(JoMart joMart)
        {
            string mobileName = joMart.NameValidation();
            string mobileDescription = GetDesciptionInput();
            string companyName = GetCompanyInput();
            double price = GetDoubleValue();
            Mobile mobile = new Mobile(mobileName, mobileDescription, companyName, price,joMart);
        }
    }
}
