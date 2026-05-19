using System;

namespace Day3_Activity7_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {

                    continue;
                }

                Console.WriteLine(i);
            }

            Console.ReadLine(); 
        }
    }
}
