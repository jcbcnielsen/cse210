using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their first and last names
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Print the names recieved
        Console.WriteLine($"\nYour name is {lastName}, {firstName} {lastName}.");
    }
}