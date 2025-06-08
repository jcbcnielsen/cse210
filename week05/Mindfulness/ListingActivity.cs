public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing",
    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = 0;
        _prompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];
    }

    public void Run()
    {
        DisplayStartMessage();

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        DisplayPrompt();
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        _count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"You listed {_count} items!");

        Console.WriteLine();
        DisplayEndMessage();
    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(0, _prompts.Count)];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"\n ---{GetRandomPrompt()}---\n");
    }
}