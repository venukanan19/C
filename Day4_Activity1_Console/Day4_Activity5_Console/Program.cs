using System;

namespace Day3_Activity2_Console
{
    class Program
    {
        public static void PrintMultiplicationTable(int number)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number to print multiplication table: ");
            int num = Convert.ToInt32(Console.ReadLine());

            PrintMultiplicationTable(num);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
