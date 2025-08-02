
using System;

namespace HelloWorld
{
    public class GradeCalculator
    {
        public void Run()
        {
            int grade = -1;
            while (true)
            {
                Console.Write("Enter a numerical grade (0-100): ");
                string? input = Console.ReadLine();
                if (int.TryParse(input ?? string.Empty, out grade) && grade >= 0 && grade <= 100)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                }
            }

            string letterGrade = GetLetterGrade(grade);
            Console.WriteLine($"Letter Grade: {letterGrade}");
        }

        private string GetLetterGrade(int grade)
        {
            if (grade >= 90) return "A";
            if (grade >= 80) return "B";
            if (grade >= 70) return "C";
            if (grade >= 60) return "D";
            return "F";
        }
    }
}
