namespace Day3_Activity6_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int userNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 1000; i++)
            {

                if (i % userNumber == 0)
                {
                    Console.WriteLine($"The first multiple of {userNumber} is: {i}");
                    break;
                }
               
            }
            Console.WriteLine("Program ended.");
        }
    }
}
