using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeValue = int.Parse(grade);
        string letter;

        if (gradeValue >= 90)
        {
            //Console.WriteLine("Your grade is A.");
            letter = "A";
        }

        else if (gradeValue >= 80)
        {
            //Console.WriteLine("Your grade is B.");
            letter = "B";
        }

         else if (gradeValue >= 70)
        {
            //Console.WriteLine("Your grade is C.");
            letter = "C";
        }

         else if (gradeValue >= 60)
        {
            //Console.WriteLine("Your grade is D.");
            letter = "D";
        }

         else
        {
            //Console.WriteLine("Your grade is F.");
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (gradeValue >= 70)
        {
            Console.WriteLine("You passed!");
        }

        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}