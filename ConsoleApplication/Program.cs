using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n==== Main Menu ====");
                Console.WriteLine("1. Grade Calculator");
                Console.WriteLine("2. Exit");
                Console.Write("Select an option: ");
                string? input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        var gradeCalculator = new GradeCalculator();
                        gradeCalculator.Run();
                        break;
                    case "2":
                        Console.WriteLine("Exiting application. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}