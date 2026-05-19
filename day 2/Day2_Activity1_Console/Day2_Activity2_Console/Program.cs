namespace Day2_Activity2_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your score");
            int score = int.Parse(Console.ReadLine());
            if (score >= 90 && score <= 100)
            {
                Console.WriteLine("Grade: A");
            }

            else if (score >= 80 && score < 90)
            {
                Console.WriteLine("Grade: B");
            }

            else if (score >= 70 && score < 80)
            {
                Console.WriteLine("Grade: C");
            }

            else if (score >= 60 && score < 70)
            {
                Console.WriteLine("Grade: D");
            }

            else if (score > 0 && score < 60)
            {
                Console.WriteLine("Grade: F");
            }

            else {
                Console.WriteLine("enter a valid score");
                  };


        }
    }
}
