using System.Reflection;

namespace DemoEnum
{
    enum Gender
    {
        Unknown,
        Male,
        Female,
    }
    class person
    {
        
        public string Name { get; set; }
        public Gender gender { get; set; }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            person[] persons = new person[3];
            persons[0] = new person
            {
                Name = "Test",
                gender = Gender.Female,
            };
            persons[1] = new person
            {
                Name = "Test2",
                gender = Gender.Male,
            };
            persons[2] = new person
            {
                Name = "Test3",
                gender = Gender.Male,
            };
            foreach(var person in persons)
            {
                Console.WriteLine($"{person.Name} {person.gender}");
            }

            foreach (string i in Enum.GetNames(typeof(Gender)))
            {
                Console.WriteLine(i);
            }
        }
        //static public string GetGender(int gender)
        //{
        //    switch (gender)
        //    {
        //        case 1:
        //            return "Unknown";
        //        case 2:
        //            return "Male";
        //        case 3:
        //            return "Female";
        //        default:
        //            return "Invalid";
        //    }
        //}
    }
}
