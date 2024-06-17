namespace _23Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> countries = new Dictionary<int,string>();
            countries.Add(1, "India");
            countries.Add(2, "USA");
            countries.Add(3, "UK");
            countries.Add(4, "Australia");
            //foreach (KeyValuePair<int, string> keyValuePair in countries)
            //{
            //    Console.WriteLine($"{keyValuePair.Key} - {keyValuePair.Value}");
            //}
            if(countries.ContainsKey(5))
            {
                Console.WriteLine(countries[2]);
            }
            if(countries.TryGetValue(4,out string value))
            {
                Console.WriteLine($"{value} {countries[4]}");
            }
            countries[5] = "Africa";
            foreach (KeyValuePair<int, string> keyValuePair in countries)
            {
                Console.WriteLine($"{keyValuePair.Key} - {keyValuePair.Value}");
            }
            countries.Remove(5);
            foreach (KeyValuePair<int, string> keyValuePair in countries)
            {
                Console.WriteLine($"{keyValuePair.Key} - {keyValuePair.Value}");
            }
            countries.Clear();
        }
    }
}
