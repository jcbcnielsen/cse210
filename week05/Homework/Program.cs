using System;

class Program
{
    static void Main(string[] args)
    {
        string name0 = "Alex";
        string topic0 = "Fractions";
        Assignment fractionAssignment = new Assignment(name0, topic0);
        Console.WriteLine(fractionAssignment.GetSummary());
        Console.WriteLine();

        string name1 = "Bob";
        string topic1 = "Integrals";
        string section1 = "7.4";
        string problems1 = "21 - 25";
        MathAssignment integralHomework = new MathAssignment(name1, topic1, section1, problems1);
        Console.WriteLine(integralHomework.GetSummary());
        Console.WriteLine(integralHomework.GetHomeworkList());
        Console.WriteLine();

        string name2 = "Chris";
        string topic2 = "World History";
        string title2 = "Effects of the Norman Conquest";
        WritingAssignment historyPaper = new WritingAssignment(name2, topic2, title2);
        Console.WriteLine(historyPaper.GetSummary());
        Console.WriteLine(historyPaper.GetWritingInfo());
        Console.WriteLine();
    }
}