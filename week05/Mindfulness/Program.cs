/* To exceed requirements and show creativity, I had each activity keep track of how many times it was repeated,
and had it display the repetitions and total time spent to the user upon completion. */

using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity();
        ReflectionActivity reflection = new ReflectionActivity();
        ListingActivity listing = new ListingActivity();
        string userInput;

        do
        {
            Console.Clear();
            Console.WriteLine("Menu options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();
            Console.Clear();

            switch (userInput)
            {
                case "1":
                    breathing.Run();
                    break;
                case "2":
                    reflection.Run();
                    break;
                case "3":
                    listing.Run();
                    break;
            }
        } while (userInput != "4");
    }
}