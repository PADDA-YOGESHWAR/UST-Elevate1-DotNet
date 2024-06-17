namespace _17EnumDemo
{
    enum Gender
    {
        Unknown,
        Male,
        Female,
    }
    enum Mobile
    {
        Samsung,
        Apple,
        Oppo
    }
    class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
       // public int Gender { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Customer[] customers = new Customer[4];
            customers[0] = new Customer
            {
                Name = "John",
                Gender = Gender.Male//
            };
            customers[1] = new Customer
            {
                Name = "Tina",
                Gender = Gender.Female
            };
            customers[2] = new Customer
            {
                Name = "Abc",
                Gender = Gender.Unknown
            };
            customers[3] = new Customer
            {
                Name = "Ajay",
                Gender = Gender.Male,
            };
            foreach(Customer customer in customers)
            {
                Console.WriteLine($"{customer.Name} {customer.Gender}");// 1 2 
            }
            int[] genderValues = (int[])Enum.GetValues(typeof(Gender));
           
            foreach(var i in Enum.GetValues(typeof(Gender)))
            {
                Console.WriteLine(i);
            }
            foreach(var i in Enum.GetNames(typeof(Gender)))
            {
                Console.WriteLine(i);
            }
            //Gender gender = (Gender)2;
            //int myGender = (int)Gender.Male;
            //Gender newGender = (Gender)Mobile.Samsung;
            //Console.WriteLine(gender);
            //Console.WriteLine(myGender);
            //Console.WriteLine(newGender);

        }
        //1 -> male

        //static string GetGender(Gender gender)
        //{
        //    switch (gender)
        //    {
        //        case Gender.Unknown:
        //            return "Unknown";
        //        case Gender.Male:
        //            return "Male";
        //        case Gender.Female:
        //            return "Female";
        //        default:
        //            return "Invalid";
        //    }
        //}

    }
}
