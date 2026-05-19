namespace Day2_Activity3_Console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your weight in kg :");
            double weight = Convert.ToDouble(Console.ReadLine());

  
            Console.Write("Enter your height in meters (e.g., 1.75): ");
            double height = Convert.ToDouble(Console.ReadLine());


            double bmi = weight / (height * height);


            Console.WriteLine($"Your BMI is: {bmi:F2}");

            if (bmi < 18.5)
            {
                Console.WriteLine("Category: Underweight");
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.WriteLine("Category: Normal weight");
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                Console.WriteLine("Category: Overweight");
            }
            else
            {
                Console.WriteLine("Category: Obesity");
            }

            Console.ReadKey();
        }
    }
}

