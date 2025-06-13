/* To show creativity and exceed requirements, I added a level up feature and the ability to
archive old goals to reduce clutter. Both additions are seen in the GoalManager class. */

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}