using System;

namespace Day4_Activity3_Console
{
    internal class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
   
        public static double Divide(double a, double b)
        {

            return a / b;
        }

        static void Main(string[] args)
        {
          
            int num1 = 10;
            int num2 = 5;

            Console.WriteLine("Addition: " + Add(num1, num2));
            Console.WriteLine("Subtraction: " + Subtract(num1, num2));
            Console.WriteLine("Multiplication: " + Multiply(num1, num2));
            Console.WriteLine("Division: " + Divide(num1, num2));
        }
    }
}
