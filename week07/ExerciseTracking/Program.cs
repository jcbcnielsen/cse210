using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime today = DateTime.Now;
        DateTime yesterday = DateTime.Now.AddDays(-1);
        DateTime yesterweek = DateTime.Now.AddDays(-7);
        int dur1 = 60;
        int dur2 = 20;
        int dur3 = 30;
        float distRun = 5f;
        float cycleSpeed = 10.2f;
        int lapsSwam = 30;

        List<Activity> activities = new List<Activity>([
            new RunningActivity(today, dur1, distRun),
            new CyclingActivity(yesterday, dur2, cycleSpeed),
            new SwimmingActivity(yesterweek, dur3, lapsSwam)
        ]);

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}