using System;

namespace Day4_Activity8_Console
{
    class Program
    {
        public static void Greet()
        {
            Console.WriteLine("Hello, guest!");
        }
        public static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        public static void Greet(string name, int times)
        {
            for (int i = 1; i <= times; i++)
            {
                Console.WriteLine($"Hello, {name}!");
            }
        }

        static void Main(string[] args)
        {
            Greet();                        
            Greet("venu");                 
            Greet("kevin", 3);                

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
