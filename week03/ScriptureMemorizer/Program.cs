/* To exceed requirements and show creativity, I had the program randomly choose from
a small list of scriptures instead of only providing one. I also exceeded the core
requirements by ensuring the Scriptures.HideRandomWords() method did not attempt
to hide a word that was already hidden, instead searching for a word that was being
shown. */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Make list of scriptures to choose from
        List<Scripture> scriptures = new List<Scripture>();
        Reference ref0 = new Reference("John", 3, 16);
        Reference ref1 = new Reference("John", 17, 3);
        Reference ref2 = new Reference("Ephesians", 2, 8);
        Reference ref3 = new Reference("James", 5, 14, 15);
        Reference ref4 = new Reference("1 John", 4, 7, 8);
        Scripture script0 = new Scripture(ref0, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Scripture script1 = new Scripture(ref1, "And this is life eternal, that they might know thee the only true God, and Jesus Christ, whom thou hast sent.");
        Scripture script2 = new Scripture(ref2, "For by grace are ye saved through faith; and that not of yourselves: it is the gift of God:");
        Scripture script3 = new Scripture(ref3, "Is any sick among you? let him call for the elders of the church; and let them pray over him, anointing him with oil in the name of the Lord: And the prayer of faith shall save the sick, and the Lord shall raise him up; and if he have committed sins, they shall be forgiven him.");
        Scripture script4 = new Scripture(ref4, "Beloved, let us love one another: for love is of God; and every one that loveth is born of God, and knoweth God. He that loveth not knoweth not God; for God is love.");
        scriptures.Add(script0);
        scriptures.Add(script1);
        scriptures.Add(script2);
        scriptures.Add(script3);
        scriptures.Add(script4);

        // Randomly choose a scripture
        Random random = new Random();
        int scriptIndex = random.Next(0, scriptures.Count);

        string userInput;
        do
        {
            Console.Clear();
            Console.WriteLine(scriptures[scriptIndex].GetDisplayText());
            if (scriptures[scriptIndex].IsCompletelyHidden() != true)
            {
                Console.Write("Press Enter to continue or type quit: ");
                userInput = Console.ReadLine();
                if (userInput == "")
                {
                    scriptures[scriptIndex].HideRandomWords(random.Next(1, 6));
                }
            }
            else
            {
                userInput = "quit";
            }
        } while (userInput.ToLower() != "quit");
    }
}