using System;

namespace Day4_Activity9_Console
{
    public static class Validator
    {
        public static bool IsPositive(double number)
        {
            return number > 0;
        }

        public static bool IsInRange(int number, int min, int max)
        {
            return number >= min && number <= max;
        }

        public static bool IsPasswordValid(string password)
        {
            return password.Length >= 8;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Is 5 positive? {Validator.IsPositive(5)}");
            Console.WriteLine($"Is -3 positive? {Validator.IsPositive(-3)}");

            Console.WriteLine($"Is 7 in range 1–10? {Validator.IsInRange(7, 1, 10)}");
            Console.WriteLine($"Is 15 in range 1–10? {Validator.IsInRange(15, 1, 10)}");

            Console.WriteLine($"Is 'mypassword' valid? {Validator.IsPasswordValid("mypassword")}");
            Console.WriteLine($"Is 'short' valid? {Validator.IsPasswordValid("short")}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
