/* To show creativity and exceed requirements, I added an extra prompt to
the user asking them what they think will happen tomorrow, and added that to
their response in each journal entry. The relevant code is in Journal.cs */

using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Declare and initialize Main variables
        string option = "";
        string filename = "";
        Journal theJournal = new Journal();

        Console.WriteLine("Welcome to your journal program!");
        do
        {
            Entry newEntry = new Entry();
            // Display the menu and prompt the user to pick a choice
            Console.WriteLine("\nWould you like to:");
            Console.WriteLine("Write a new journal entry? (entry)");
            Console.WriteLine("Display your journal entries? (display)");
            Console.WriteLine("Save your journal to a file? (save)");
            Console.WriteLine("Load your journal from a file? (load)");
            Console.WriteLine("Close the program? (close)");
            Console.Write("Please type your option: ");
            option = Console.ReadLine().ToLower();

            switch (option)
            {
                case "entry":
                    // Get a prompt, display the prompt, and recieve input from the user
                    theJournal.AddEntry(newEntry);
                    break;

                case "display":
                    // Display all of the journal entries
                    theJournal.DisplayJournal();
                    break;

                case "save":
                    // Prompt the user for a filename and save the journal to that file
                    Console.Write("Enter a filename to save the journal to: ");
                    filename = Console.ReadLine();
                    theJournal.SaveFile(filename);
                    break;

                case "load":
                    // Prompt the user for a filename and load the journal at that file
                    Console.Write("Enter the filename to load the journal from: ");
                    filename = Console.ReadLine();
                    theJournal.LoadFile(filename);
                    break;

                case "close":
                    // Do nothing here, and the loop will exit at the end
                    break;

                default:
                    // Inform the user that what they typed is not a choice
                    Console.WriteLine("That was not a valid choice. Please type a valid option.");
                    break;
            }
        } while (option != "close");
    }
}