public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    private int _count = 0;
    private int _totalTime = 0;

    public Activity(string name, string desc)
    {
        _name = name;
        _description = desc;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Hello, welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
    }
    public void DisplayEndMessage()
    {
        _count++;
        _totalTime += _duration;
        Console.WriteLine("Well Done!!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed the {_name} activity {_count} times for a total of {_totalTime} seconds.");
        ShowSpinner(3);
    }
    public void ShowSpinner(int sec)
    {
        DateTime endTime = DateTime.Now.AddSeconds(sec);
        while (DateTime.Now < endTime)
        {
            Console.Write("|\b");
            Thread.Sleep(250);
            Console.Write("/\b");
            Thread.Sleep(250);
            Console.Write("-\b");
            Thread.Sleep(250);
            Console.Write("\\\b");
            Thread.Sleep(250);
        }
        Console.Write(" ");
    }
    public void ShowCountdown(int sec)
    {
        for (int i = sec; i > 0; i--)
        {
            Console.Write($"{i}");
            for (int j = 0; j < i.ToString().Length; j++)
            {
                Console.Write("\b");
            }
            Thread.Sleep(1000);
        }
        Console.Write(" ");
    }
    public int GetDuration()
    {
        return _duration;
    }
}