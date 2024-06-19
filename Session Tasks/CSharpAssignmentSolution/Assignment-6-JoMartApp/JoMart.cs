using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InputValidationLibrary;

namespace Assignment_6_JoMartApp
{
    internal class JoMart
    {
        private List<Mobile> mobiles = new List<Mobile>();
        private string resultName;
        public void Add(Mobile mobile)
        {
            if (mobile != null)
            {
                mobile.Id = mobiles.Count == 0 ? 3000 : mobiles.Max(m => m.Id) + 1;
                mobiles.Add(mobile);
                Console.WriteLine($"Product {mobile.Name} is Added");
            }
        }

        public string NameValidation()
        {
            bool valid = false;
            while(!valid)
            {
                Console.Write("Enter the mobile name : ");
                string name = Console.ReadLine().Trim().ToUpper();
                if (name.Length > 0)
                {
                    if(!mobiles.Any(p=>p.Name == name))
                    {
                        valid = true;
                        resultName = name;
                    }
                    else
                    {
                        Console.Write("Name already exists!! Please try again with another name");
                    }
                }
                else
                {
                    Console.WriteLine("You haven't entered any name!! please try to enter the name");
                }
            }
            return resultName;
        }
        public void ViewAllMobiles()
        {
           if(mobiles.Count > 0)
            {
                mobiles.ForEach(mobile => Mobile.DisplaymobileDetails(mobile));
            }
            else
            {
                 Console.WriteLine("No Mobiles in the JoMart to view...!!!");
            }
        }

        public void MobilesPriceLessThanMaxPrice()
        {
            if(mobiles.Count>1)
            {
                mobiles.ForEach(x => {
                    if (x.Id != GetMaxPriceId())
                    {
                        Mobile.DisplaymobileDetails(x);
                    }
                });
            }
            else if(mobiles.Count == 1)
            {
                Console.WriteLine("The is only one mobile available. Hence, There are no mobiles whose price is less than the max price of mobiles.");
            }
            else
            {
                Console.WriteLine("No Mobiles are present in the JoMart.Try to add the mobiles and then perform the operation.");
            }
        } 

        public void SearchByManufacturer()
        {

            String CompanyName = GetValidInputs.GetCompanyInput();
            List<Mobile> requiredMobiles = mobiles.FindAll(mobiles => mobiles.Name == CompanyName);
            if (requiredMobiles.Count > 0)
            {
                Console.WriteLine($"The Mobiles avaialble with Manufatured by {CompanyName}");
                requiredMobiles.ForEach(Mobile.DisplaymobileDetails);
            }
            else
            {
                Console.WriteLine($"No Mobiles Found Manufactured by {CompanyName}");
            }
        }

        public void MobilesPriceGreaterThanMinAndLessThanMaxPrice()
        {
            if (mobiles.Count > 2)
            {
                mobiles.ForEach(x => {
                    if (x.Id != GetMaxPriceId() && x.Id != GetMaxPriceId())
                    {
                        Mobile.DisplaymobileDetails(x);
                    }
                });
            }
            else if (mobiles.Count==0 )
            {
                Console.WriteLine("No Mobiles are present in the JoMart.Try to add the mobiles and then perform the operation.");
            }
            else
            {
                Console.WriteLine("The is only one/two mobile available. Hence, There are no mobiles whose price is greater than minimum mobile price and less than maximum mobile price.");
            }
        }
        public void RemoveMobilesGreaterThanMinAndLessThanMaxPrice()
        {
            if (mobiles.Count > 2)
            {
                List<Mobile> requiredMobiles = mobiles.FindAll(mobiles => mobiles.Id != GetMaxPriceId() && mobiles.Id != GetMinPriceId());
                requiredMobiles.ForEach(x => {
                        Console.WriteLine($"{x.Name} is Removed from the JoMart"); 
                        mobiles.Remove(x);
                });
            }
            else if (mobiles.Count == 0)
            {
                Console.WriteLine("No Mobiles are present in the JoMart remove.Try to add the mobiles and then perform the operation.");
            }
            else
            {
                Console.WriteLine("The is only one/two mobile available. Hence, There are no mobiles whose price is greater than minimum mobile price and less than maximum mobile price.");
            }
        }
        public int GetMaxPriceId()
        {
            return mobiles.OrderByDescending(mobile => mobile.Price).First().Id;
        }
        public int GetMinPriceId()
        {
            return mobiles.OrderByDescending(mobile => mobile.Price).Last().Id;
        }

    }
}
