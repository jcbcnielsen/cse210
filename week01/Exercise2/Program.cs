using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their numerical grade
        Console.Write("What numerical grade did you get? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        // Initialize variables
        string letterGrade;
        string gradeSign = "";
        bool pass = true;

        // Assign the letter grade and if they failed the class based on their numerical grade
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
            pass = false;
        }
        else
        {
            letterGrade = "F";
            pass = false;
        }

        // Add a + to their letter grade if appropriate
        if ((grade % 10) >= 7)
        {
            if (!(grade >= 90 || grade < 60))
            {
                gradeSign = "+";
            }
        }
        // Add a - to their letter grade if appropriate
        else if ((grade % 10) <= 3)
        {
            if (grade >= 60)
            {
                gradeSign = "-";
            }
        }

        // Print the results
        Console.WriteLine($"You got a {letterGrade}{gradeSign}.");
        if (pass == true)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you failed the course. We hope you'll do better next time!");
        }
    }
}