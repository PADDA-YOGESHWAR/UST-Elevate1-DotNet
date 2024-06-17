namespace UseOfFinallyBlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operation started");
            if (HandlingTheDatabase())
            {
                Console.WriteLine("Operation success");
            }
            else
            {
                Console.WriteLine("Operation Failed");
            }
            
        }
        static bool HandlingTheDatabase()
        {
            try
            {
                
                return true;
            }
            catch
            {
                return false;
            }
            ///Console.WriteLine("Connection Not Closed");
            //Console.WriteLine("These Statements are not executed");
            finally
            {
                Console.WriteLine("Connection Closed");
            }
        }
    }
}
