namespace Day1_Activity3_Console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter a temperature in Celsius");
            double c = double.Parse(Console.ReadLine());
            double F = (c * 9 / 5) + 32;
            Console.WriteLine($"celsu:{c}°C is equal to {F}°F. ");



        }
    }
}
