namespace Day3_Activity4_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            while (true)
            {
                Console.Write("Enter a positive integer N: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out N) && N > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }

            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of numbers from 1 to {N} is: {sum}");
        }
    }
}
