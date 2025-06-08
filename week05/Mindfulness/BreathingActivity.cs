public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing",
    "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    public void Run()
    {
        DisplayStartMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe In... ");
            ShowCountdown(5);
            Console.Write("\nBreathe Out... ");
            ShowCountdown(5);
            Console.WriteLine();
        }

        Console.WriteLine();
        DisplayEndMessage();
    }
}