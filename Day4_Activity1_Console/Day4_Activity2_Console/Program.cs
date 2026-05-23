namespace Day4_Activity2_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void GreetUser(string name)
            {
                Console.WriteLine($"hello {name}");

            }
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            GreetUser(name);
            
        }
    }
}
