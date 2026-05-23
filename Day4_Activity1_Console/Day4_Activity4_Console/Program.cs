using System;

namespace Day4_Activity4_Console
{
    class Program
    {
        public static string ReverseString(string text)
        {
            string reversed = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed += text[i];
            }
            return reversed;
        }

        public static bool IsPalindrome(string text)
        {
            string reversed = ReverseString(text);
            return text.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }

        static void Main(string[] args)
        {
            string[] testStrings = { "racecar", "hello", "madam", "world", "level", "Civic" };

            foreach (string s in testStrings)
            {
                Console.WriteLine($"Original: {s}");
                Console.WriteLine($"Reversed: {ReverseString(s)}");
                Console.WriteLine($"Is Palindrome? {IsPalindrome(s)}");
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
