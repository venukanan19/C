namespace Day1_Activity5_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hight");
            double H = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter width");
            double W = double.Parse(Console.ReadLine());
            double Area = W*H;
            Console.WriteLine($"Area of the rectangle: {Area}");
            Console.WriteLine("radius of a circle");
            double R = double.Parse(Console.ReadLine());
            double circleArea = Math.PI * R * R;
            Console.WriteLine($"Area of the circle: {circleArea}");

        }
    }
}
