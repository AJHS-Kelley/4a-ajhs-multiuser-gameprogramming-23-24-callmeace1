using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Guess the Number game!");

        // Generate a random number between 1 and 100
        Random random = new Random();
        int secretNumber = random.Next(1, 101);

        int attempts = 0;
        int guess = 0;

        do
        {
            Console.Write("Enter your guess (1-100): ");
            string input = Console.ReadLine();

            // Validate user input
            if (int.TryParse(input, out guess))
            {
                attempts++;
khni
                if (guess == secretNumber)
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Too low. Try again.");
                }
                else
                {
                    Console.WriteLine("Too high. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        } while (guess != secretNumber);

        Console.WriteLine("Thanks for playing!");
    }
}
