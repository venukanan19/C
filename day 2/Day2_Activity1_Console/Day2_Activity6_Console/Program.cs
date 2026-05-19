namespace Day2_Activity6_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("It is a leap year.");
            }
            else
            {
                Console.WriteLine("It is not a leap year.");
            }
            
        }
    }
}

