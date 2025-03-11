using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of number, type 0 when finished.");
        List<int> numbers = new List<int>();

        // Adding numbers to the list
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number !=0)
            {
                numbers.Add(number);
            }

        }

        // Adding the list of numbers
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Getting the average of number
        double average = 0;
        if (numbers.Count > 0)
        {
            average = (double)sum / numbers.Count;
        }
        
        // Finding the largest value on the list
        int largest = numbers[0]; // Considering the first number is the largest 
        foreach (int value in numbers)
        {
            if (value > largest) // Comparing each number
            {
                largest = value; // Updating largest value if we find another number
            }
        }

        // Printing results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}