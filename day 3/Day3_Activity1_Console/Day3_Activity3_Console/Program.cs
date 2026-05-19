namespace Day3_Activity3_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string secretWord = "csharp";
            string guess = "";

            while (guess != secretWord)
            {
                Console.Write("Enter your secrt word: ");
                guess = Console.ReadLine().ToLower();
            }

           
            Console.WriteLine("Congratulations! You guessed the secret word correctly!");
        }
    }
}
