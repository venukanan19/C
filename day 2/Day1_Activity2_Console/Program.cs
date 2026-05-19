using System.Drawing;

namespace Day1_Activity2_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your FirstName");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter your LastName");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter your FavoriteColor");
            string FavoriteColor = Console.ReadLine();
            Console.WriteLine($"userbio: {FirstName} {LastName} favorite color is {FavoriteColor}");
        }
    }
}
