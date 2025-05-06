using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize variables
        Random randGen = new Random();
        string userInput;
        int number;
        int guess;
        int count;
        string replay = "yes";

        // Loop to replay game if user chooses
        while (replay == "yes")
        {
            // Reset game variables
            number = randGen.Next(1, 101);
            count = 0;

            // Main game loop
            do
            {
                // Ask user for their next guess
                Console.Write("What is your guess? ");
                userInput = Console.ReadLine();
                guess = int.Parse(userInput);
                count++;

                // Check if number is higher or lower than guess
                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
            } while (guess != number);

            // Print results if they guess correctly and ask if the user wants to play again
            Console.WriteLine($"You guessed it! It took you {count} tries.");
            Console.Write("Would you like to play again (yes/no)? ");
            replay = Console.ReadLine();
        }
    }
}