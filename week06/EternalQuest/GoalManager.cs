using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private List<Goal> _archive = new List<Goal>();
    private int _level = 1;
    private int _xp = 0;
    private int _toNext = 2000;

    public void Start()
    {
        string userInput;
        Console.Clear();
        Console.WriteLine("Hello, welcome to the Eternal Quest goal program.\n");
        Pause();
        do
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("  1. Display your current stats");
            Console.WriteLine("  2. Record an event");
            Console.WriteLine("  3. Display your active goals");
            Console.WriteLine("  4. Display your archived goals");
            Console.WriteLine("  5. Create a new goal");
            Console.WriteLine("  6. Archive a goal");
            Console.WriteLine("  7. Save your data to a file");
            Console.WriteLine("  8. Load data from a file");
            Console.WriteLine("  9. Quit the program");
            Console.Write("Your choice: ");
            userInput = Console.ReadLine();
            Console.Clear();

            switch (userInput)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ListGoalDetails(_goals);
                    break;
                case "4":
                    ListGoalNames(_archive);
                    Pause();
                    break;
                case "5":
                    CreateGoal();
                    break;
                case "6":
                    ArchiveGoal();
                    break;
                case "7":
                    SaveGoals();
                    break;
                case "8":
                    LoadGoals();
                    break;
                case "9":
                    break;
                default:
                    Console.WriteLine("That was not a valid input. Please try again.");
                    Pause();
                    break;
            }
        } while (userInput != "9");
    }
    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"Level: {_level}. XP: {_xp}.\nXP to next Level: {_toNext - _xp}.\nActive Goals: {_goals.Count()}.");
        Pause();
    }
    private void ListGoalNames(List<Goal> goalList)
    {
        int i = 1;
        foreach (Goal g in goalList)
        {
            Console.WriteLine($"{i}. {g.GetName()}");
            i++;
        }
    }
    private void ListGoalDetails(List<Goal> goalList)
    {
        int i = 1;
        foreach (Goal g in goalList)
        {
            Console.WriteLine($"{i}. {g.GetDetailStr()}");
            i++;
        }
        Pause();
    }
    private void CreateGoal()
    {
        // User chooses what type of goal to make
        bool validChoice;
        string choice;
        do
        {
            Console.Write("There are:\n  1. simple goals\n  2. eternal goals\n  3. checklist goals\nWhich would you like to create? ");
            choice = Console.ReadLine();
            validChoice = true;
            if (choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("That was not a valid option. Please try again.\n");
                validChoice = false;
            }
        } while (validChoice == false);

        // User gives details about the goal
        Console.Write("What will you name your goal? ");
        string name = Console.ReadLine();
        Console.Write("Provide a description for your goal: ");
        string desc = Console.ReadLine();
        int points;
        int target;
        int bonus;
        switch (choice)
        {
            case "1":
                // Simple goal details
                Console.Write("How much XP should you get when your complete the goal? ");
                points = int.Parse(Console.ReadLine());
                _goals.Add(new SimpleGoal(name, desc, points));
                break;
            case "2":
                // Eternal goal details
                Console.Write("How much XP should you get each time you complete this goal? ");
                points = int.Parse(Console.ReadLine());
                _goals.Add(new EternalGoal(name, desc, points));
                break;
            case "3":
                // Checklist goal details
                Console.Write("How much XP should you get when you make progress towards this goal? ");
                points = int.Parse(Console.ReadLine());
                Console.Write("How many repetitions should you have to do before you complete this goal? ");
                target = int.Parse(Console.ReadLine());
                Console.Write("How much extra XP should you get when you complete the goal? ");
                bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
        }
        Console.WriteLine("Goal created!");
        Pause();
    }
    private void ArchiveGoal()
    {
        if (_goals.Count() != 0)
        {
            ListGoalNames(_goals);
            Console.Write("Which goal would you like to archive? ");
            int i = int.Parse(Console.ReadLine()) - 1;
            _archive.Add(_goals[i]);
            _goals.RemoveAt(i);
            Console.WriteLine("Goal archived!");
        }
        else
        {
            Console.WriteLine("You don't have any goals yet!");
        }
        
        Pause();
    }
    private void RecordEvent()
    {
        if (_goals.Count() != 0)
        {
            ListGoalNames(_goals);
            Console.Write("Which goal would you like to record an event for? ");
            int i = int.Parse(Console.ReadLine()) - 1;
            int oldXP = _xp;
            _xp += _goals[i].RecordEvent();
            if (oldXP == _xp)
            {
                // If the goal was already finished
                Console.WriteLine("You already completed that goal!");
            }
            else
            {
                // If the goal was not already complete
                if (_goals[i].IsComplete())
                {
                    Console.WriteLine($"Goal complete! You gained {_xp - oldXP} XP!");
                }
                else
                {
                    Console.WriteLine($"Event recorded! You gained {_xp - oldXP} XP!");
                }

                if (_xp >= _toNext)
                {
                    // Level up if needed
                    _xp -= _toNext;
                    _level++;
                    _toNext = (int)Math.Floor(2000 * Math.Pow(1.2, _level - 1));
                    Console.WriteLine($"\nLevel Up! You are now Level {_level}!");
                }
            }
        }
        else
        {
            Console.WriteLine("You don't have any goals yet!");
        }
        
        Pause();
    }
    private void SaveGoals()
    {
        string filename = "EternalQuest-Player.csv";
        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine($"{_level},{_xp},{_toNext}");
        }

        filename = "EternalQuest-Goals.csv";
        using (StreamWriter output = new StreamWriter(filename))
        {
            foreach (Goal g in _goals)
            {
                output.WriteLine(g.GetStrRep());
            }
        }

        filename = "EternalQuest-Archive.csv";
        using (StreamWriter output = new StreamWriter(filename))
        {
            foreach (Goal g in _archive)
            {
                output.WriteLine(g.GetStrRep());
            }
        }

        Console.WriteLine("Profile and goals saved!");
        Pause();
    }
    private void LoadGoals()
    {
        while (_goals.Count() > 0)
        {
            _goals.RemoveAt(0);
        }
        while (_archive.Count() > 0)
        {
            _archive.RemoveAt(0);
        }

        string filename = "EternalQuest-Player.csv";
        string[] playerParts = System.IO.File.ReadAllLines(filename)[0].Split(",");
        _level = int.Parse(playerParts[0]);
        _xp = int.Parse(playerParts[1]);
        _toNext = int.Parse(playerParts[2]);

        filename = "EternalQuest-Goals.csv";
        foreach (string line in System.IO.File.ReadAllLines(filename))
        {
            string[] parts = line.Split(",");
            if (parts[0] == "simple")
            {
                // type,name,description,points,isComplete
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
            }
            else if (parts[0] == "eternal")
            {
                // type,name,deescription,points
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (parts[0] == "checklist")
            {
                // type,name,description,points,amount,target,bonus
                _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
            }
        }

        filename = "EternalQuest-Archive.csv";
        foreach (string line in System.IO.File.ReadAllLines(filename))
        {
            string[] parts = line.Split(",");
            if (parts[0] == "simple")
            {
                // type,name,description,points,isComplete
                _archive.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
            }
            else if (parts[0] == "eternal")
            {
                // type,name,description,points
                _archive.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (parts[0] == "checklist")
            {
                // type,name,description,points,amount,target,bonus
                _archive.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
            }
        }

        Console.WriteLine("Loaded profile and goals!");
        Pause();
    }
    private void Pause()
    {
        Console.Write("\nPress enter to continue... ");
        Console.ReadLine();
    }
}