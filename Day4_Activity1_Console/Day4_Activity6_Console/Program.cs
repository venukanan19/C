using System;

namespace Day4_Activity6_Console
{
    public static class TempConverter
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double celsius = 25;
            double fahrenheit = 77;

            Console.WriteLine($"{celsius}°C = {TempConverter.CelsiusToFahrenheit(celsius)}°F");
            Console.WriteLine($"{fahrenheit}°F = {TempConverter.FahrenheitToCelsius(fahrenheit)}°C");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
