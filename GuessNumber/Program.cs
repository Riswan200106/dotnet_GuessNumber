using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Guess the Number Game!");
        Console.WriteLine("I have picked a number between 1 and 100. Can you guess what it is?");

        Random random = new Random();
        int secretNumber = random.Next(1, 101); // Generates a random number between 1 and 100
        int guess = 0; // User's guess
        int attempts = 0; // Count of attempts

        while (guess != secretNumber)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            // Validate input
            if (int.TryParse(input, out guess))
            {
                attempts++;
                if (guess < secretNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the correct number {secretNumber} in {attempts} attempts.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        Console.WriteLine("Thanks for playing the Guess the Number Game!");
    }
}