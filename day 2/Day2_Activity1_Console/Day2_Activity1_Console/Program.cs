namespace Day2_Activity1_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your user age :");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote");

            }
            else
            {
                Console.WriteLine("You are not eligible to vote");
            }
        }
    }
}
