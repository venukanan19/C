namespace Day1_Activity4_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            int num2 = int.Parse(Console.ReadLine());
            int sum1 = num1 + num2;
            int Difference = num1 - num2;
            int product = num1 * num2;
            double Quotient = num1 / num2;
            Console.WriteLine($"sum: {sum1}");
            Console.WriteLine($"sub: {Difference}");
            Console.WriteLine($"pro: {product}");
            Console.WriteLine($"quo: {Quotient}");

        }
    }
}
