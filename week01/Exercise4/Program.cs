using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Initialize list
        Console.WriteLine("Enter a list of numbers. Enter 0 when finished.");
        List<int> nums = new List<int>();
        int userInput;

        // Ask user for numbers to add to the list
        do
        {
            Console.Write("Enter a number: ");
            userInput = int.Parse(Console.ReadLine());
            if (userInput != 0)
            {
                nums.Add(userInput);
            }
        } while (userInput != 0);

        // Initialize calculation variables
        float sum = 0;
        int max = -2147483648;
        int min = 2147483647;
        if (nums.Count > 0)
        {
            // Calculate sum and check for maximum and minimum
            foreach (int num in nums)
            {
                sum += num;
                if (num > max)
                {
                    max = num;
                }
                if (num > 0 && num < min)
                {
                    min = num;
                }
            }
        }

        // Calculate average
        float avg = sum / nums.Count;

        // Print results
        if (nums.Count > 0)
        {
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {avg}");
            Console.WriteLine($"The largest number is: {max}");
            Console.WriteLine($"The smallest positive number is: {min}");
            nums.Sort();
            Console.WriteLine("The sorted list is:");
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}