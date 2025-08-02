
using System;

namespace HelloWorld
{
    public class TriangleTypeIdentifier
    {
        public void Run()
        {
            double[] sides = new double[3];
            for (int i = 0; i < 3; i++)
            {
                while (true)
                {
                    Console.Write($"Enter length of side {i + 1}: ");
                    string? input = Console.ReadLine();
                    if (double.TryParse(input ?? string.Empty, out double value) && value > 0)
                    {
                        sides[i] = value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a positive number.");
                    }
                }
            }

            if (!IsValidTriangle(sides[0], sides[1], sides[2]))
            {
                Console.WriteLine("The given sides do not form a valid triangle.");
                return;
            }

            string triangleType = GetTriangleType(sides[0], sides[1], sides[2]);
            Console.WriteLine($"Triangle Type: {triangleType}");
        }

        private bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        private string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c) return "Equilateral";
            if (a == b || b == c || a == c) return "Isosceles";
            return "Scalene";
        }
    }
}
