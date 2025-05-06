using System;

class Program
{
    static void DisplayWelcome()
    {
        // Print the welcome message
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        // Ask the user for their name
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        // Ask the user for their favorite number
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        // Calculate the square of the given number
        return number * number;
    }

    static void DisplayResult(string name, int number)
    {
        // Inform the user of the square of their favorite number
        Console.WriteLine($"{name}, the square of your favorite number is {number}.");
    }
    static void Main(string[] args)
    {
        // Call the funcions
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int square = SquareNumber(userNumber);
        DisplayResult(userName, square);
    }
}