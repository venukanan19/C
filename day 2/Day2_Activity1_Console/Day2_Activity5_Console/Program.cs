namespace Day2_Activity5_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseprice = 12.50;





            Console.WriteLine("Enter your age : ");
            int age = int.Parse(Console.ReadLine());

            if (age <= 12 || age >= 65)
            {
                baseprice = baseprice - (baseprice * 0.5);
                Console.WriteLine("you got discount : "+baseprice);
            
            }

            Console.WriteLine("you are student? yes or no");
            string student = (Console.ReadLine().ToLower());

            if (student=="yes")
            {
                baseprice = baseprice - (baseprice * 0.25);
                Console.WriteLine("you got discount : "+ baseprice);
            }

            Console.ReadLine();


            }
    }
}
