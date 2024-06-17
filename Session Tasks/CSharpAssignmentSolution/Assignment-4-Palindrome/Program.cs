namespace Assignment_4_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value to check the palindrome or not : ");
            String Value = Console.ReadLine();
            if(CheckPalindrome(Value))
            {
                Console.WriteLine($"{Value} is a Palindrome");
            }
            else
            {
                Console.WriteLine($"{Value} is not a Palindrome");
            }
        }
        static bool CheckPalindrome(String Content)
        {
            int i = 0;
            int j = Content.Length-1;
            while (i<=j)
            {
                if (Content[i] != Content[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}
