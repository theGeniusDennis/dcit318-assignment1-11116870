
using System;

namespace HelloWorld
{
    public class TicketPriceCalculator
    {
        public void Run()
        {
            int age = -1;
            while (true)
            {
                Console.Write("Enter your age: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input ?? string.Empty, out age) && age >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a non-negative integer for age.");
                }
            }

            int price = (age <= 12 || age >= 65) ? 7 : 10;
            Console.WriteLine($"Ticket Price: GHC {price}");
        }
    }
}
